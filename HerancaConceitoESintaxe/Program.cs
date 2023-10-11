/* Herança - Conceito e sintaxe 
 * 
 * A Herança é um mecanismo pelo qual uma classe (conhecida como classe derivada ou subclasse) pode
 * adquirir propriedades e métodos de outra classe(conhecida como classe base ou superclasse).
 * 
 * A classe derivada é capaz de reutilizar o código da classe base, evitando duplicação de código
 * e permitindo a especialização de comportamentos.
 * 
 * A relação entre a classe derivada e classe base é estabelecida através do sinal de dois pontos(:)
 * seguido do nome da classe base após a declaração da classe derivada.
 */


/* Herança - Benefícios 
 * 
 * 1.Reutilização de código: Com a herança, você pode criar uma classe base com atributos e métodos comuns
 * que são compartilhados por vários classes derivadas. Isso evita a necessidade de duplicar código em cada
 * classe, tornando o código mais limpo, conciso e mais fácil de manter.
 * 
 * 2.Especialização: Através da herança, você pode criar classes derivadas que herdam as características da
 * classe base, mas também podem ter atributos e comportamentos específicos. Isso permite criar hierarquias
 * de classes que representam diferentes níveis de especialização, o que torna o código mais flexível e escalável.
 * 
 * 3.Extensibilidade: A herança permite adicionar novos atributos e métodos a uma classe derivada sem modificar
 * a classe base. Assim, você pode estender o comportamento de uma classe sem afetar outras partes do código
 * que dependem dela.
 * 
 * 4.Encapsulamento: A herança pode ser combinada com o conceito de modificadores de acesso(public, private, 
 * protected, etc.) para controlar o acesso aos membros da classe base e seus derivados. Isso ajuda a proteger
 * o código e a garantir que apenas os membros apropriados sejam acessíveis para as classes que precisam deles.
 */


/* Herança - Problemas 
 * 
 * 1.Acoplamento forte: A herança cria um acoplamento forte entre a classe base e suas classes derivadas.
 * Alterações na classe base podem afetar diretamente as classes derivadas, tornando o código mais suscetível a 
 * efeitos colaterais indesejados.
 * 
 * 2.Herança profunda: Hierarquias de herança muito profundas podem se tornar difíceis de enteder e manter.
 * Um grande número de níveis de herança pode levar a complexidade e tornar o código menos legível.
 * 
 * 3.Herança como reutilização excessiva: A herança pode ser usada excessivamente para reutilizar código, mesmo
 * quando a relação "é um" entre as classes não é apropriada. Nesses casos, a composição (outra técnica de programação
 * orientada a objetos) pode ser mais adequada.
 * 
 * 4.Rigidez do design: Uma vez que a herança define uma hierarquia de classes, pode ser difícil fazer alterações
 * significativas na estrutura de classes sem afetar todo o sistema. Mudanças na classe base podem exigir ajustes
 * extensivos em todas as classes derivadas.
 */

Console.WriteLine("## Herança ##\n");


Funcionario funcionario = new Funcionario();
funcionario.Nome = "José";
funcionario.Email = "jose@email.com";
funcionario.Empresa = "Google Inc.";
funcionario.Salario = 9000;

Console.WriteLine("----Funcionario----\n");
Console.WriteLine(funcionario.Empresa);
Console.WriteLine(funcionario.Salario);
funcionario.Identificar();

Aluno aluno = new Aluno();
aluno.Nome = "João";
aluno.Email = "joão@email.com";
aluno.Curso = "Engenharia";
aluno.Nota = 9;

Console.WriteLine("\n----Aluno----\n");
Console.WriteLine(aluno.Curso);
Console.WriteLine(aluno.Nota);
aluno.Identificar();



Console.ReadLine();


public class Pessoa
{
    public string? Nome { get; set; }
    public string? Email { get; set; }

    public void Identificar()
    {
        Console.WriteLine($"{Nome} - {Email}");
    }
}


public class Funcionario : Pessoa
{
    public string? Empresa { get; set; }
    public decimal Salario { get; set; }
}


public class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public int Nota { get; set; }
}