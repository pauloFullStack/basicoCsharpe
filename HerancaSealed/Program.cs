/* Herança - Modificador sealed 
 * 
 * 
 * Quando aplicado a uma classe, o modificador sealed impede que outras classes herdem dela
 * 
 * Podemos usar o modificador sealed em um método ou propriedade que substitui um método ou 
 * propriedade virtual em uma classe base.
 * 
 * Com isso você permite que classes sejam derivadas de sua classe e evita que outros desenvolvedores
 * que estejam usando suas classes substituam métodos e propriedades virtuais específicos 
 * 
 */


/* Exemplo de não permitir classes derivadas usar a classe abaixo */
//Cliente obj = new Cliente();
//obj.Nome = "José";
//obj.ExibeNome();


/* Exemplo de não permitir classes derivadas usar a classe abaixo */
//sealed class Pessoa
//{
//    public string? Nome { get; set; }

//    public void ExibeNome()
//    {
//        Console.WriteLine($"Meu nome é {Nome}");
//    }
//}

//class Cliente : Pessoa
//{
//    public new void ExibeNome()
//    {
//        Console.WriteLine($"\nNome do cliente : {Nome}");
//    }
//}


Console.ReadKey();

class ClasseBase
{
    protected virtual void Metodo1()
    {
        Console.WriteLine("ClasseBase.Metodo1()");
    }

    protected virtual void Metodo2()
    {
        Console.WriteLine("ClasseBase.Metodo2()");
    }

}


class Classe1 : ClasseBase
{
    // Não pode ser herdado é um metodo selado
    sealed protected override void Metodo1()
    {
        Console.WriteLine("Classe1.Metodo1()");
    }

    protected override void Metodo2()
    {
        Console.WriteLine("Classe1.Metodo2()");
    }

}


class Classe2 : Classe1
{
    /* Esse metodo esta dando erro, porque esta sendo bloqueado de herdar o método Metodo1 da Classe1, 
     * porque o Metodo1 esta selado, com o modificador 'sealed', que impede do método a ser herdado ou sobrescrita, 
     * sealed e usado em classes também
     */
    protected override void Metodo1()
    {
        Console.WriteLine("Classe2.Metodo1()");
    }

    protected override void Metodo2()
    {
        Console.WriteLine("Classe2.Metodo2()");
    }
}