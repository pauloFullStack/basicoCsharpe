/* Construtor estático : exemplo */

public class Pessoa
{
    public static int IdadeMinima;

    public string Nome { get; set; } = string.Empty;
    public int Idade { get; set; }


    public Pessoa(string nome, int idade)
    {
        Console.WriteLine("\nExecutando o construtor parametrizado");
        Nome = nome;
        Idade = idade;
    }


    public Pessoa() { }

    static Pessoa()
    {
        Console.WriteLine("\nExecutando o construtor estático");
        Console.WriteLine("Inicializando o campo IdadeMinima");
        IdadeMinima = 18;
    }
}