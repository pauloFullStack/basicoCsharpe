/* Tratamento de múltiplas exceções 
 * 
 * Se o método assíncrono criar várias tarefas(Task) ou usar o método Task.WhenAll, todas as exceções 
 * ocorridas serão capturadas em uma instância de AggregateException.
 * 
 * Aguardar(await) a instância de Task, usando apenas o bloco try-catch, vai obter apenas a primeira exceção, mesmo que várias
 * exceções possam ter sido lançadas em seu método assíncrono.
 * 
 * A palavra-chave await vai desempacotar apenas a primeira exceção da instância Task e desta forma não vamos obter todas as 
 * exceções lançadas
 * 
 */


/* Obtendo todas as exceções lançadas em um método Assíncrono 
 * 
 * Para obter todas as exceções lançadas podemos usar a propriedade InnerExceptions da classe AggregateException que representa
 * um ou mais erros que ocorrem durante a execução do método assíncrono.
 * 
 * A classe AggregateException herda da classe Exception e contém uma propriedade chamada InnerExceptions, que é uma coleção 
 * de exceções que foram lançadas durante a execução assíncrona
 * 
 * Assim basta iterar através das exceções individuais usando a propriedade InnerExceptions
 */


/* Recomendações 
 * 
 * Utilize async e await para realizar operações assíncronas(Task, Task<T>,ValueTask, ValueTask<T>)
 * 
 * Os métodos async que retornam void têm uma finalidade específica: viabilizar manipuladores de eventos assíncronos. Evite usar
 * async void.
 * 
 * O async/await é encadeado, ou seja, você não pode chamar um método assíncrono dentro de um método síncrono.(Fazer isso é muito 
 * custoso e poderá causar um deadlock)
 * 
 * Utilize o sufixo Async nos nomes dos métodos assíncronos
 * 
 * Para cancelar um método assíncrono use o CancellationToken
 * 
 * Não retorne null de um método que retorna um Task(pode causar um NullReferenceException)
 * 
 * Evite retornar void em métodos assíncronos(Quem chama não pode aguardar a operação e não há como tratar a exceção)
 * 
 * Utilize o método WhenAll para aguardar mais de uma tarefa
 * 
 */

await LancaMultiplasExcecoesAsync();
Console.ReadKey();

static async Task LancaMultiplasExcecoesAsync()
{
    Task? tarefas = null;
    try
    {
        var primeiraTask = Task.Run(() =>
        {
            Task.Delay(1000);
            throw new IndexOutOfRangeException("IndexOutOfRangeException lançada explicitamente.");
        });

        var segundaTask = Task.Run(() =>
        {
            Task.Delay(1000);
            throw new InvalidOperationException("InvalidOperationException lançada explicitamente.");
        });
        /* Deve-se usar o 'await' para capturar as exceções em metodos assincronos */
        tarefas = Task.WhenAll(primeiraTask, segundaTask);
        await tarefas;
    }
    catch
    {
        Console.WriteLine("Ocorreram as seguintes exceções :-\n");
        AggregateException? todasExceptions = tarefas?.Exception;

        if (todasExceptions != null)
            foreach (var ex in todasExceptions.InnerExceptions)
                Console.WriteLine(ex.Message);
    }
}