/* Programação assíncrona x Programação paralela 
 * 
 * 
 * - Programação assincrona
 * 
 * A programação assincrona é um modelo de programação que permite que o aplicativo execute várias tarefas ao mesmo
 * tempo sem bloquear a thread principal.
 * 
 * Isso é feito usando as palavras-chaves 'async/await' e a biblioteca de tarefas TPL (Task Parallel Library) do .NET
 * 
 * 
 * - Programação paralela
 * 
 * A programação paralela, por outro lado, é um modelo de programação que permite que o aplicativo execute várias tarefas
 * ao mesmo tempo, aproveitando os recursos do processador.
 * 
 * Isso é feito usando a biblioteca Parallel do .NET, que fornece vários métodos para executar operações em paralelo
 */


/* Programação assíncrona 
 * 
 * 
 * - Executa múltiplas tarefas simultaneamente
 * - Inicia uma tarefa e continua a executar outras tarefas enquanto a primeira tarefa está em andamento
 * - Quando a tarefa secundária é concluída, o controle é transferido de volta para a tarefa primária.
 * - Isso é feito sem bloquear a thread principal do programa
 * - É suportada pelo das palavras-chave async e await
 * - async é usada para indicar que um método pode ser executado de forma assíncrona
 * - await é usado para esperar a conclusão de uma tarefa assíncrona
 * 
 * Programação Síncrona:
 * Executa todas as tarefas em sequência aguardando que a execução de cada tarefa seja concluída antes de iniciar 
 * outra tarefa
 * 
 * Programação Assíncrona:
 * Executa mais de uma tarefa de forma simultânea e não aguarda a conclusão da execução de cada tarefa antes de iniciar
 * outra tarefa
 * 
 */



Console.WriteLine("### Programação Síncrona ### \n");
int espera = 4000; // Representa 4000 milisegundos ou 4 segundos

Console.WriteLine("Tecle algo para iniciar");
Console.ReadLine();

RealizarTarefa(espera);

Console.WriteLine($"\nTempo gasto {espera / 1000} segundos ");
Console.WriteLine("\n### Fim do processamento");

Console.ReadKey();
static void RealizarTarefa(int tempo)

{
    Console.WriteLine("\n>>> Iniciando a tarefa...");
    //Task.Delay(TimeSpan.FromSeconds(tempo));
    Thread.Sleep(tempo);
    Console.WriteLine(">>> Tarefa concluida.");
}