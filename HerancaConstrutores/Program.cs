/* Herança - Construtores 
 * 
 * 
 * A classe base e a classe derivada podem possuir seus próprios construtores
 * 
 * A classe derivada não herda o construtor da classe base mas pode invocá-lo
 * 
 * Ao criar uma instância da classe derivada o cosntrutor da classe base sem parâmetros será invocado
 * primeiro e depois será invocado o construtor da classe derivada
 * 
 * A palavra-chave base é usada para acessar membros de classe base de dentro de uma classe derivada:
 * - Ela é usada para especificar qual construtor de classe base deve ser chamado ao criar instâncias
 * da classe derivada;
 * 
 */


Aluno aluno1 = new Aluno();
Aluno aluno2 = new Aluno("Davi Moderno");
Aluno aluno3 = new Aluno("Davi Moderno", 12);

Console.ReadKey();


/* Base */
class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("Construtor da classe Pessoa");
    }

    public Pessoa(string nome)
    {
        Console.WriteLine("Construtor da classe Pessoa com parametro = " + nome);
    }

    public Pessoa(string nome, int idade)
    {
        Console.WriteLine($"ClasseBase = Nome: {nome} - Idade: {idade}");
    }
}


/* Derivada */
class Aluno : Pessoa
{
    public Aluno() : base()
    {
        Console.WriteLine("Construtor da classe Aluno");
    }

    public Aluno(string nome) : base(nome)
    {
        Console.WriteLine("Construtor da classe Aluno com parametro = " + nome);
    }

    public Aluno(string nome, int idade) : base(nome, idade)
    {
        Console.WriteLine($"ClasseDerivada = Nome: {nome} - Idade: {idade}");
    }
}