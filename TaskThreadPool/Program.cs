/* Recursos usados na aula
 * 
 * 1. Task.Run() - Enfileira o trabalho especificado para execução no ThreadPool e retorna uma tarefa(Task) ou identificador Task<T>
 * para esse trabalho
 * 
 * A plataforma .NET usa um modelo unificado para cancelamento cooperativo de operações assíncronas ou síncronas de longa duração
 * 
 * Este modelo é baseado em um objeto leve chamado token de cancelamento
 * 
 */


/* Tipos usados para realizar o Cancelamento 
 * 
 * CancellationTokenSource - É o objeto que cria um token de cancelamento, e também emite o pedido de cancelamento para todas as cópias
 * desse token.
 * 
 * CancellationToken - Propaga a notificação de que as operações devem ser canceladas. Os ouvintes monitoram o valor da propriedade 
 * IsCancellationRequested do token por sondagem, retorno de chamada ou identificador de espera.
 * 
 * OperationCanceledException - É a exceção que é lançada em um thread após o cancelamento de uma operação que a tarefa na thread
 * estava executando.
 * 
 */


/* Padrão de implementação do cancelamento 
 * 
 * 1-Instancie um objeto CancellationTokenSource, que gerencia e envia notificação de cancelamento aos tokens de cancelamentos 
 * individuais
 * 
 * 2-Passe o token retornado pela propriedade  CancellationTokenSource.Token para cada tarefa ou thread que escuta o cancelamento
 * 
 * 3-Forneça um mecanismo para cada tarefa ou encadeamento para responder ao cancelamento
 * 
 * 4-Chame o método CancellationTokenSource.Cancel para fornecer uma notificação de cancelamento
 * 
 */


using System.Diagnostics;

internal class Program
{
    //private static CancellationTokenSource? cancellationTokenSource;

    static async Task Main(string[] args)
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();

        try
        {
            //cancellationTokenSource = new CancellationTokenSource();
            //cancellationTokenSource.Cancel();
            //var resultado = await OperacaoLongaDuracaoCancelavel(100, cancellationTokenSource.Token);
            //Console.WriteLine(resultado);

            Console.WriteLine("Cancelamento automatico após 1,5 segundos");
            await ExecutaCancelamentoComTimeout(2500);

        }
        catch (Exception)
        {
            Console.WriteLine($"Tarefa cancelada: tempo expirado após {stopWatch.Elapsed}\n");
        }

        Console.ReadKey();
    }

    private static Task<int> OperacaoLongaDuracaoCancelavel(int valor, CancellationToken cancellation = default)
    {
        Console.WriteLine("Executou Operação de longa duração");
        Task<int>? task = null;

        task = Task.Run(() =>
        {
            int resultado = 0;
            for (int i = 0; i < valor; i++)
            {
                if (cancellation.IsCancellationRequested)
                    throw new TaskCanceledException(task);

                Thread.Sleep(50);
                resultado += i;
            }
            return resultado;
        });

        return task;
    }

    /* Cancelamento após um período de tempo 
     * 
     * 1-Podemos usar a sobrecarga do construtor da classe CancellationTokenSource(int)
     * 
     * Inicializa uma nova instância da classe que será cancelada depois do intervalo de tempo definido em milisegundos
     */

    private static async Task ExecutaCancelamentoComTimeout(int tempo)
    {
        using (var cancellationTokenSource = new CancellationTokenSource(tempo))
        {

            /* Outra abordagem de cancelamento 
             * cancellationTokenSource.CancelAfter(tempo);
             */

            try
            {
                var resultado = await OperacaoLongaDuracaoCancelavel(100, cancellationTokenSource.Token);
                Console.WriteLine($"Resultado: {resultado}");
            }
            catch (TaskCanceledException)
            {
                throw;
            }
        }
    }

}