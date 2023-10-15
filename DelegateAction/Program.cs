/* Delegate Action 
 * 
 * 
 * É um delegate que representa um método que não retorna nenhum valor pode receber de um a 16 argumentos do tipo T.
 * 
 * Ele encapsula um método que não retorna nenhum valor(void) e pode receber de zero a 16 parâmetros de entrada.
 * Ex: delegate void Action<in T>(T obj);
 * 
 * Sua assinatura possui 17 sobrecargas: Action<T>, Action<T1,T2>, ...Action<T1,...,T16>
 * 
 */

using System.Threading.Channels;

Console.WriteLine("Informe um número inteiro :");
int numero = Convert.ToInt32(Console.ReadLine());

/* Usando sobrecarga do Action que aceita 2 inteiros */
Action<int, int> dobra = (x, y) => Console.WriteLine((x + y) * 2);
dobra(numero, numero);

/* Usando sobrecarga do Action que aceita 1 inteiros */
Action<int> dobra2 = x => Console.WriteLine(x * 2);
dobra2(numero);

Console.ReadKey();
