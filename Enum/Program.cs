/* Enum
 * 
 * Enum ou Enumeration é um tipo de dados especial definido pelo usuário.
 * 
 * Um 'enum' é uma 'classe' especial que é definida por um conjuto de constantes nomeadas
 * do tipo numérico.
 * 
 * O uso do tipo 'enum' ajuda a tornar o programa mais fácil de entender e manter
 * 
 */


/* Enum  - sintaxe
 * 
 * Uma enumeração é definida usando a palavra-chave 'enum', diretamente dentro de um namespace, 
 * classe ou struct, e todos os nomes das constantes podem ser declarados e separados por uma
 * vírgula.
 * 
 */


/* Enum - valores 
 * 
 * Por padrão, os valores associados ao membros de uma enum são do tipo int;
 * 
 * O primeiro membro 'de um enum' tem o valor 0 e o valor de cada membro seguinte
 * é incrementado de 1. (quando nenhum valor for atribuído)
 * 
 * Um 'enum' é um 'tipo de valor' sendo alocado na memória Stack
 * 
 * Podemos atribuir valores diferentes aos membros de uma enum.
 * 
 * Uma alteração no valor padrão de um membro 'enum' atribuirá automaticamente valores
 * incrementais aos outros membros sequencialmente.
 * 
 * Podemos também atribuir valores diferentes a cada membros de uma enum.
 */


/* Enum - Acesso
 * 
 * Um enum pode ser acessado usando a sintaxe de ponto: nome_enum.membro
 * 
 * O enum pode ser de qualquer tipo de dados numérico como: byte, sbyte, short,
 * ushort, int, uint, long ou ulong.
 * 
 * Para definir o tipo basta informar o nome do tipo após o nome do enum
 * 
 */
using Enums;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("## Enum ##\n");

        /* Exibindo o nome do enum */
        Console.WriteLine($"{DiasDaSemana.Segunda}");
        Console.WriteLine($"{DiasDaSemana.Terça}");
        Console.WriteLine($"{DiasDaSemana.Quarta}");
        Console.WriteLine($"{DiasDaSemana.Quinta}");
        Console.WriteLine($"{DiasDaSemana.Sexta}");
        Console.WriteLine($"{DiasDaSemana.Sábado}");
        Console.WriteLine($"{DiasDaSemana.Domingo}\n");


        /* Exibir o valor do enum */
        Console.WriteLine($"{(int)DiasDaSemana.Segunda}");
        Console.WriteLine($"{(int)DiasDaSemana.Terça}");
        Console.WriteLine($"{(int)DiasDaSemana.Quarta}");
        Console.WriteLine($"{(int)DiasDaSemana.Quinta}");
        Console.WriteLine($"{(int)DiasDaSemana.Sexta}");
        Console.WriteLine($"{(int)DiasDaSemana.Sábado}");
        Console.WriteLine($"{(int)DiasDaSemana.Domingo}\n");


        Console.WriteLine($"{Categoria.Moda} - {(int)Categoria.Moda}");
        Console.WriteLine($"{Categoria.Automotivo} - {(int)Categoria.Automotivo}");
        Console.WriteLine($"{Categoria.Artes} - {(int)Categoria.Artes}");
        Console.WriteLine($"{Categoria.Bebidas} - {(int)Categoria.Bebidas}");
        Console.WriteLine($"{Categoria.Livros} - {(int)Categoria.Livros}");
        Console.WriteLine($"{Categoria.Brinquedos} - {(int)Categoria.Brinquedos}");

        Console.WriteLine("\nSelecione a Categoria teclando o seu valor");
        int valor = Convert.ToInt32(Console.ReadLine());

        Categoria nomeMembroEnum = (Categoria)valor;

        Console.WriteLine(nomeMembroEnum);

        Console.ReadKey();
    }
}



// Valor padrão
//enum DiasDaSemana
//{
//    Segunda  0,
//    Terça    1,
//    Quarta   2,
//    Quinta   3,
//    Sexta    4,
//    Sábado   5,
//    Domingo  6
//}