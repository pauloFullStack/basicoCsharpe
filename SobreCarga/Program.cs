/* Sobrecarga de metodos, é quando se usa o nome do mesmo metodo, em varios outros mundando a apenas a escrita do metodo 'seus parametros' 
 * Exemplo:
 * teste(); teste(string nome); teste(int num1, int num2);  */

Console.WriteLine("## Métodos ##");


Cadastro cadastro = new Cadastro();

Cliente cliente = cadastro.Registrar();
cadastro.ExibirDados(cliente);    
cliente = cadastro.Registrar(cliente);
cadastro.ExibirDados("Renda alterada\n", cliente);


Console.ReadKey();

public class Cliente
{
    public string? Nome;
    public int Idade;
    public decimal Renda;


    public Cliente(string? nome, int idade, decimal renda)
    {
        Nome = nome;
        Idade = idade;
        Renda = renda;
    }


    public Cliente() { }

}

public class Cadastro
{
    public Cliente Registrar()
    {
        Cliente cliente = new Cliente("Maria", 23, 3000);
        return cliente;
    }


    public Cliente Registrar(Cliente cliente)
    {
        cliente.Renda = 3500;
        return cliente;
    }


    public void ExibirDados(Cliente cliente)
    {
        Console.WriteLine($"{cliente.Nome} {cliente.Idade} {cliente.Renda.ToString("c")}");
    }

    public void ExibirDados(string texto, Cliente cliente)
    {
        Console.WriteLine($"\n{texto}");
        Console.WriteLine($"{cliente.Nome} {cliente.Renda.ToString("c")}");
    }


}