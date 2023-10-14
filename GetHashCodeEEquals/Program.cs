/* GetHashCode e Equals 
 * 
 * 
 * São métodos da classe 'Object' que são usados para comparar se dois objetos são iguais
 * 
 * Todos objetos na linguagem C# herdam de 'Object' e assim herdam os métodos 'GetHashCode e Equals'
 * 
 * GetHashCode retorna um valor inteiro(código hash) com base nas informações do objeto(estado do objeto),
 * enquanto 'Equals' compara o objeto com outro objeto e retorna um booleano indicando se eles são iguais
 * 
 * Nos tipos definidos pelo usuário é necessário sobrescrever os métodos 'GetHashCode e Equals' para garantir
 * que a igualdade entre dois objetos do tipo seja avaliada de forma correta
 * 
 */


/* Equals 
 * 
 * 
 * Determine se duas 'instâncias' de um objeto são iguais retornando true se forem iguais ou false se forem
 * diferentes
 */


/* GetHashCode 
 * 
 * 
 * Retorna um valor inteiro(código hash) com base nas informações do objeto(estado do objeto) e é 
 * mais rápido que o método Equals
 * 
 * Objetos diferentes sempre vão gerar um número diferente para GetHashCode
 * 
 * Códigos de hash iguais não significam que os objetos são iguais pois podem existir objetos diferentes que
 * podem ter os mesmos códigos hash.
 */


/* Estratégia para localizar e comparar objetos com GetHashCode e Equals 
 * 
 * 
 * 1 - Utilizar o método 'GetHashCode' para localizar os objetos e verificar se possuem o mesmo código hash(pois é mais rápido
 * para localizar)
 * 2 - Confirmar a igualdade dos objetos usando o método Equals
 * 
 * Nos tipos definidos pelo usuário é necessário sobrescrever os métodos GetHashCode e Equals para garantir que a igualdade 
 * entre dois objetos avaliada de forma correta
 * 
 */


/* Tipos primitivos, compara o valor */
string a = "José";
string b = "José";

int x = 100;
int y = 100;

Console.WriteLine(a.Equals(b)); /* True */
Console.WriteLine(x.Equals(y)); /* True */


Console.WriteLine(a.GetHashCode());
Console.WriteLine(b.GetHashCode());
Console.WriteLine(x.GetHashCode());
Console.WriteLine(y.GetHashCode());


var pessoa1 = new Pessoa(1, "Ana");
var pessoa2 = new Pessoa(1, "Ana");


/* pessoa1 e pessoa2 não são o mesmo objeto e possuem referências diferentes */
Console.WriteLine(pessoa1.Equals(pessoa2)); /* False */

Console.WriteLine(pessoa1.GetHashCode()); /* False */
Console.WriteLine(pessoa2.GetHashCode()); /* False */




Console.ReadKey();

public class Pessoa
{
    public Pessoa(int id, string? nome)
    {
        Id = id;
        Nome = nome;
    }

    public int Id { get; set; }

    public string? Nome { get; set; }
}