/* Programação assíncrona 
 * 
 * 
 * A programação assíncrona é implementada usando a classe Task do namespace System.Threading.Tasks
 * 
 * A classe Task é uma representação assíncrona de uma operação em execução e é usada para executar tarefas assincronas
 * 
 * O núcleo da programação assíncrona são os objetos Task e Task<T>, que modelam as operações assíncronas
 * 
 * Esses objetos oferecem suporte às palavras-chave async e await
 * - await é usado para aguardar um operação que retorna um Task ou Task<T>
 * - async é usado para sinalizar que um método é assíncrono
 * 
 * Tipos de retorno em métodos assíncronos
 * - Task ou Task<T>
 * - ValueTask ou ValueTask<T>
 * - void => A recomendação é usar void apenas em manipuladores de eventos
 * 
 * 
 * - Task: É o tipo de retorno padrão para um método assíncrono que não retorna nenhum valor
 * Um método com retorno Task retorna uma tarefa que representa a operação assíncrona que será executada em segundo plano.
 * O método pode ser marcado como async e pode conter um await para aguardar a conclusão da tarefa
 * 
 * 
 * - Task<T>: Este é o tipo de retorno para um método assíncrono que retorna um valor.
 * O tipo T especifica o tipo de valor que  método retorna
 * Task<int>, Task<string>, Task<Produto>, etc.
 */


using ProgramacaoAssincronaTaskTaskT;

Console.WriteLine("### Café da manha Síncrono ###");
CafeDaManha();
Console.WriteLine("Executa sincrona");


Console.WriteLine("### Café da manha Assincrono ###");
CafeDaManhaAsync();

Console.WriteLine("Executa assincrona");

Console.ReadKey();

static void CafeDaManha()
{
    Console.WriteLine("\n-- Prepara o café");
    var cafe = PrepararCafe();

    Console.WriteLine("\n** Preparar o pão");
    var pao = PrepararPao();

    ServirCafe(cafe, pao);
}


static Cafe PrepararCafe()
{
    Console.WriteLine("-Fervendo a água");
    Thread.Sleep(2000);
    Console.WriteLine("-Coando o café");
    Thread.Sleep(2500);
    Console.WriteLine("-Adoçando o café");
    return new Cafe();
}

static Pao PrepararPao()
{
    Console.WriteLine("*Partir o pão");
    Thread.Sleep(2000);
    Console.WriteLine("*Passar manteiga no pão");
    Thread.Sleep(2000);
    Console.WriteLine("*Tostar o pão");
    return new Pao();
}

static void ServirCafe(Cafe cafe, Pao pao)
{
    Console.WriteLine("\n>>Servindo o cafe da manhã");
    Thread.Sleep(2000);
    Console.WriteLine(">>Café servido");
}


static async void CafeDaManhaAsync()
{
    Console.WriteLine("\n-- Prepara o café");
    var tarefaCafe = PrepararCafeAsync();

    Console.WriteLine("\n** Preparar o pão");
    var tarefaPao = PrepararPaoAsync();

    var cafe = await tarefaCafe;
    var pao = await tarefaPao;

    ServirCafe(cafe, pao);
}

static async Task<Cafe> PrepararCafeAsync()
{
    Console.WriteLine("-Fervendo a água");
    await Task.Delay(2000);
    Console.WriteLine("-Coando o café");
    await Task.Delay(2500); ;
    Console.WriteLine("-Adoçando o café");
    return new Cafe();
}


static async Task<Pao> PrepararPaoAsync()
{
    Console.WriteLine("*Partir o pão");
    await Task.Delay(2000);
    Console.WriteLine("*Passar manteiga no pão");
    await Task.Delay(2000);
    Console.WriteLine("*Tostar o pão");
    return new Pao();
}