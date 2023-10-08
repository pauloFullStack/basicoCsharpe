/* Struct 
 * 
 * Uma struct é um tipo de dado definido pelo usuário que é composta por outros tipos de
 * dados e funcionalidades relacionadas (semelhante a uma classe)
 * 
 * Uma struct pode conter campos, métodos, constantes, construtores, propriedades, indexadores
 * operadores e mesmo outro tipos de estruturas.
 * 
 * A principal diferença entre classe e structs e que structs são tipos de valor e não de referência.
 * (membros e instâncias de uma struct são criadas na memória Stack e contém seus dados)
 * 
 */


/* Structs x Classes 
 * 
 * CONSIDERE definir um struct em vez de uma classe se as instâncias do tipo forem pequenas e normalmente
 * de curta duração ou se forem comumente incorporadas em outros objetos.
 * 
 * EVITE definir um struct, a menos que o tipo tenha todas as características a seguir:
 * 
 * 1.Representa logicamente um único valor, semelhante aos tipos primitivos(int, double etc).
 * 2.Tem um tamanho de instância inferior a 16 bytes.
 * 3.É imutável.
 * 4.Não precisará sofrer conversão para tipo de referência(boxing) com  frequência.
 */


Console.WriteLine("## Structs ##\n");

Cliente cliente = new Cliente();
cliente.Nome = "Maria";
cliente.Idade = 12;

Console.WriteLine($"{cliente.Nome} {cliente.Idade}");

Console.ReadLine();

public struct Cliente
{
    public string? Nome { get; set; }
    public int Idade { get; set; }

    public Cliente(string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }


}