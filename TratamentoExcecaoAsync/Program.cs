/* Tratamento de exceções assincronas 
 * 
 * Programação Síncrona - Na programação síncrona o código que lança uma exceção em um método se propaga para cima na pilha de chamadas
 * até que a pilha de chamadas encontre um bloco catch que possa tratar a exceção
 * 
 * Programação Assíncrona - Na programação assíncrona, como o código não é executado sequencialmente, a semântica de tratamento
 * das exceções é diferente da usada na programação assíncrona.
 * 
 */


TesteAsync t = new TesteAsync();

//t.ChamaTarefaAsync();
Console.WriteLine("-------------");
await LancaExceptionAsync();
Console.ReadKey();



static async Task LancaExceptionAsync()
{
    try
    {
        var primeiraTask = Task.Run(() =>
        {
            Task.Delay(1000);
            throw new IndexOutOfRangeException("IndexOutOfRangeException lançada explicitamente.");
        });
        /* Deve ser executado o 'await' para tratar exceções de metodos assincronos */
        await primeiraTask;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Bloco catch executado");
        Console.WriteLine(ex.Message);
    }
}

class TesteAsync
{
    public Task MinhaTarefaAsync()
    {
        return Task.Run(() =>
        {
            Task.Delay(1000);
            throw new Exception("Minha Exception...");
        });
    }

    public async void ChamaTarefaAsync()
    {
        try
        {
            await MinhaTarefaAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Bloco catch foi executado...");
            Console.WriteLine(ex.Message);
        }

    }

    /* Tratamento de exceções 
     * 
     * No C#, um método assíncrono pode retornar: void, Task ou Task<T>
     * 
     * Quando o código executado de forma assíncrona lança uma exceção, essa exceção é armazenada no objeto Task(no estado Faulted)
     * O objeto Task contém a exceção lançada na propriedade Task.Exception
     * 
     * As exceções lançadas em métodos assíncronos com tipos de retorno Task ou Task<T> são encapsulados em uma instância da classe AggregateException
     * e associadas à instância Task.
     * 
     * Se mais de uma exceção for lançada, todas elas serão armazenadas na coleção AggregateException.InnerExceptions
     * 
     * Os métodos assíncronos com um tipo de retorno void, não possuem um objeto Task associado a eles, e, assim, as exceções 
     * lançadas em um método async void não podem ser capturados fora desse método
     * 
     * As tarefas(Tasks) com falha(no estado Faulted) vão lançar uma exceção quando forem aguardadas(usar o await).
     * 
     * Se um exceção ocorrer dentro de um método assíncrono retornando um objeto Task, a exceção será agrupada em uma instância
     * da classe AggregateException e passada de volta para o método de chamada.
     * 
     * Para tratar a exceção basta colocar um bloco try-catch dentro do método assíncrono
     */


}



