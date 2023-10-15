/* Delegates - Predicate, Action e Func 
 * 
 * 
 * A linguagem C# possui delegates pré-definidos que podemos usar para passar referências a métodos como argumentos para 
 * outros métodos
 * 
 * Predicate<T> - Representa um método que recebe um único argumento do tipo T e retorna um valor booleano. Pode ser usado 
 * para testar se um objeto satisfaz uma condição especifica.
 * 
 * Action<T> - Representa um método que não retorna um valor, mas pode receber até 16 argumentos de entrada. É útil para 
 * representar um método que executa uma ação, sem retornar nenhum valor
 * 
 * Func<T,TResult> - Recebe de um até 16 argumentos do tipo T de entrada e retorna um valor do tipo TResult. É útil para 
 * representar um método que executa uma operação e retorna um resultad.
 * 
 */


/* Delegate - Predicate 
 * 
 * 
 * Representa um método que define um conjunto de critérios e determina se o objeto especificado atende os critérios.
 * 
 * Recebe um único argumento de entrada do tipo T e retorna um valor booleano
 * 
 * public delegate bool Predicate<in T>(T obj);
 * 
 * O objetivo do Predicate é testar se um objeto satisfaz uma condição específica e realizar operações baseadas em um
 * critério.
 * 
 */


Console.WriteLine("Informe um número inteiro");
int numero = Convert.ToInt32(Console.ReadLine());

Predicate<int> delegateVerifica = x => x % 2 == 0;

if (delegateVerifica(numero)) Console.WriteLine($"O número {numero} é PAR");
else Console.WriteLine($"O número {numero} IMPAR");

Console.ReadKey();