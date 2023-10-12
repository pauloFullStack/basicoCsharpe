/* Herança - virtual e override 
 * 
 * Se você quiser que um membro da subclasse substitua um membro com o mesmo nome na classe
 * base deve fazer o seguinte:
 * - 1. Usar o modificador 'virtual' na declaração do membro da classe base
 * 
 * 
 */


Gato gato = new Gato() { Nome = "Bichano" };
gato.ExibeNome();

Cachorro cao = new Cachorro() { Nome = "Futrica" };
cao.ExibeNome();

Console.ReadKey();


/* Classe Base */
class Animal
{
    public string? Nome { get; set; }

    public virtual void ExibeNome() => Console.WriteLine($"\nMeu nome é {Nome}");

}

/* Classe Derivada */
class Gato : Animal
{
    public override void ExibeNome() => Console.WriteLine($"\nEu sou um gato. Meu nome é: {Nome}");
}


/* Classe Derivada */
class Cachorro : Animal
{

}