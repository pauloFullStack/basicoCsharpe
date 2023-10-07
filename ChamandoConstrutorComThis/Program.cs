/* Chamando um construtor chamando um outro construtor em um classe instanciada */
/* 'this' dentro de uma classe, é a propria classe instanciada */

Console.WriteLine("## this ##");

Teste t1 = new Teste(10);

Console.ReadKey();


public class Teste
{
    public Teste(int num1, int num2)
    {
        Console.WriteLine($"\nConstrutor com dois parâmetros {num1} e {num2} ");
    }

    public Teste(int num) : this(777, 888)
    {
        Console.WriteLine($"\nConstrutor com um parâmetros {num} ");
    }

}