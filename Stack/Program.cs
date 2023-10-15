/* Stack<T> - Definição e sintaxe 
 * 
 * 
 * Stack<T> é uma coleção genérica de tamanho variável que funciona com base no princípio LIFO(Last In First Out ou 
 * Último a entrar - Primeiro a sair) e esta presente no namespace System.Collections.Generic
 * 
 * Esta coleção pode ter elementos duplicados e pode aceitar null como valores
 * 
 * Ela é útil quando você precisa de armazenamento temporário para obter informações; ou seja, quando talvez
 * você queira descartar um elemento depois de recuperar seu valor.
 * 
 * 
 */


/* Stack<T> - Características 
 * 
 * 
 * Stack<T> é a uma coleção que atua ao estilo Last In First Out(LIFO)
 * 
 * Esta presente no namespace System.Collections.Generic
 * 
 * Uma Stack<T> pode conter elementos do tipo T especificado
 * 
 * Fornece verificação de tipo em tempo de compilação e não executa boxing-unboxing
 * 
 * Os elementos podem ser adicionados usando o método Push()
 * 
 * Os elementos podem ser recuperados usando os métodos Pop() e Peek()
 * 
 * Não é possível usar a sintaxe do inicializador de coleção 
 * 
 * Não oferece suporte a um indexador
 * 
 * A capacidade de uma Stack<T> é o número de elementos que ela pode conter
 * 
 * 
 */


/* Stack<T> - Construtores 
 * 
 * 
 * Stack<T>() - É usado para inicializar uma nova instância da classe Stack que está vazia e tem a capacidade inicial
 * padrão
 * 
 * Stack<T>(IEnumerable<T>) - É usado para inicializar uma nova instância da classe Stack que contém elementos copiados
 * da coleção especificada e tem capacidade suficente para acomodar o número de elementos copiados.
 * 
 * Stack<T>(int capacity) - É usado para inicializar uma nova instância da classe Stack que está vaziae e tem a capacidade
 * inicial especificada ou a capacidade inicial padrão, o que for maior.
 * 
 */



/* Stack<T> - Propriedades e Métodos 
 * 
 * 
 * Count        =  Retorna o total de elementos na pilha
 * Push()       =  Inclui um elemento no topo da pilha 
 * Pop()        =  Remove e retorna um elemento do topo da pilha
 * Peek()       =  Retorna o elemento do topo da pilha sem removê-lo
 * Contains()   =  Verifica se um existe um elemento na pilha. (true/false)
 * Clear()      =  Remove todos os elementos da pilha
 * ToArray()    =  Copia a pilha em um novo array unidimensional
 */


/* Exemplo simples */
//Stack<int> numeros = new Stack<int>();
//numeros.Push(1);
//numeros.Push(2);

//int[] array1 = new int[] { 1, 2, 3, 4 };
//Stack<int> pilha1 = new Stack<int>(array1);   

//var impares = new Stack<int>(3);
//impares.Push(5);    


Stack<int> numeros = new Stack<int>();
numeros.Push(10);
numeros.Push(20);
numeros.Push(30);
numeros.Push(40);

Console.WriteLine($"- A pilha original contém {numeros.Count} itens");
ExibirPilha(numeros);

/* Retorna sem remover */
Console.WriteLine($"\n-Item obtido da pilha (Peek) : {numeros.Peek()}");


/* Remove e retorna */
Console.WriteLine($"\n-Item removido da pilha (Pop) : {numeros.Pop()}");
ExibirPilha(numeros);

Console.WriteLine($"- A pilha atual contém {numeros.Count} itens");


if (numeros.Contains(20)) Console.WriteLine("\n-Item 20 esta na pilha");
else Console.WriteLine("\n-Item 20 não esta na pilha");

Console.WriteLine("\n-Copia a pilha usando ToArray");
var copia = new Stack<int>(numeros.ToArray());
ExibirPilha(copia);

Console.WriteLine("\n-Removendo todos os itens da pilha\n");
numeros.Clear();
Console.WriteLine($"{numeros.Count} itens na pilha ");

ExibirPilha(numeros);


Console.ReadKey();

static void ExibirPilha<T>(IEnumerable<T> numeros)
{
    Console.WriteLine();
    foreach (var item in numeros)
    {
        Console.WriteLine(item);
    }
}