/* Classe Semaphore 
 * 
 * É usada para limitar o número de threads que podem ter acesso a um recurso compartilhado de forma simultânea
 * 
 * Usada quando temos um número limitado de recursos e queremos limitar o número de threads que podem usar o recurso de forma
 * simultânea com a segurança da thread
 * 
 * Metodos:
 * 
 * WaitOne() - Permite a entrada das threads no semáforo, este método indica ao semáforo que existe uma thread aguardando a execução
 * e incrementa a contagem dentro do semáforo.
 * 
 * Release() - Deve ser chamado sempre que um thread for finalizado, ou quando se desejar liberar a thread para que outra thread possa
 * entrar em execução, este método decrementa a contagem do semáforo
 * 
 * A contagem em um semáforo é decrementada toda vez que um thread entra no semáforo e incrementada quando um thread é liberada do semáforo.
 * 
 */


/* Classe SemaphoreSlim 
 * 
 * Representa uma alternativa mais leve à classe Semaphore
 * 
 * Usada quando temos um número limitado de recursos e queremos limitar o número de threads que podem usar o recurso de forma simultânea 
 * com a segurança da thread
 * 
 * Wait() - Bloqueia o thread atual até que possa inserir a thread no SemaphoreSlim
 * 
 * WaitAsync() - Aguarda assincronamente para inserir a thread no SemaphoreSlim
 * 
 * Release() - Deve ser chamado sempre que um thread for finalizada, ou quando se desejar liberar a thread para que outra thread possa
 * entrar em execução.
 * 
 */

internal class Program
{
    public static Semaphore threadPool = new Semaphore(3, 5);
    public static SemaphoreSlim semaforoSlim = new SemaphoreSlim(4);
    private static void Main(string[] args)
    {
        // Semaphore
        //for (int i = 0; i < 10; i++)
        //{
        //    Thread threadObject = new Thread(new ThreadStart(ProcessarOperacao));
        //    threadObject.Name = $"Thread: {i}";
        //    threadObject.Start();
        //}

        // SemaphoreSlim
        for (int i = 0; i < 6; i++)
        {
            string threadName = $"Thread {i}";
            int espera = 2 + 2 * i;

            var t = new Thread(() =>
            {
                AcessarBancoDeDados(threadName, espera);
            });

            t.Start();
        }

        Console.ReadKey();
    }

    private static void ProcessarOperacao()
    {
        threadPool.WaitOne();
        Console.WriteLine($"Thread {Thread.CurrentThread.Name} entrou na sessão critica...");

        /* Simulando um processamento */
        Thread.Sleep(10000);

        threadPool.Release();
        Console.WriteLine($"Thread {Thread.CurrentThread.Name} foi liberada...");
    }

    private static void AcessarBancoDeDados(string nome, int seconds)
    {
        Console.WriteLine($"{nome} aguarda para acessar o banco de dados...");
        semaforoSlim.Wait();

        Console.WriteLine($"{nome} foi atualizado a acessar o banco de dados");
        Thread.Sleep(TimeSpan.FromSeconds(seconds));

        Console.WriteLine($"{nome} foi concluida...");
        semaforoSlim.Release();
    }

}