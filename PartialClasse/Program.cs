/* Partial Class - Definição 
 * 
 * Quando definimos uma classe usando a sintaxe padrão da linguagem C#,temos que definir em um 
 * ´único arquivo físico' com extensão .cs, todos os membros da classe
 * 
 * Nesta abordagem não podemos declarar uma classe em dois arquivos separados em um mesmo projeto
 * 
 * A partir da versão 2.0 a plataforma .NET introduziu o recurso chamado 'partial class' que
 * permite que uma classe venha a ser implementada em múltiplos arquivos físicos com extensão .cs
 * 
 * Desta forma é possível dividir a definição de uma 'classe, struct, interface ou método' em dois
 * ou mais arquivos de origem
 * 
 * Cada arquivo de origem contém as definições de membros, tipos ou métodos e todas as partes são
 * combinadas quando o aplicativo for compilado.
 * 
 */


/* Partial Class - Usando o modificador partial 
 * 
 * Podemos criar 'classes, interfaces, structs e métodos' parciais usando o modificador 'partial'
 */


/* Partial Class -  Regras 
 * 
 * Todas as definições das classes parciais devem estar no mesmo assembly e no mesmo namespace
 * 
 * Todas as partes devem possuir a mesma acessibilidade como 'public ou private, etc'
 * 
 * Se qualquer parte for declarada 'abstract' então toda a classe será declarada do mesmo
 * tipo
 * 
 * O modificador 'partial' somente pode ser usado antes da palavra-chave 'class, struct ou interface'.
 * 
 * 'Tipos' parciais 'aninhados' são permitidos
 * 
 * Os 'atributos' se aplicam a todas as partes da classe
 * 
 * As características definidas em qualquer parte estão disponíveis para todas as partes das classes
 * 
 */


/* Partial Class - Quando usar 
 * 
 * Ao trabalhar em projetos grandes, dividir uma classe em arquivos separados permite que vários
 * programadores trabalhem ao mesmo tempo
 * 
 * Ao trabalhar com codigo-fonte gerado automaticamente, o código pode ser adicionado à classe
 * sem precisar recriar o arquivo de origem
 * 
 * Ao usar geradores de códigos fonte(sources generators) para gerar funcionalidade adicional
 * em uma classe
 * 
 */




using PartialClasse;

Console.WriteLine("## Partial Class ##\n");

MinhaPartialClass minhaPartialClass = new MinhaPartialClass();

Console.WriteLine($"Idade para nascidos em: 07/08/2003");

var idade = minhaPartialClass.CalculaIdade(new DateTime(2003, 08, 7));
Console.WriteLine($"{Math.Round(idade.TotalDays / 365)} anos");

Console.WriteLine("\nIdade para os nascidos em: 02/06/2005 ");

idade = minhaPartialClass.CalculaIdade(new DateTime(2005, 06, 2));
Console.WriteLine($"{Math.Round(idade.TotalDays / 365)} anos");


var data1 = DateTime.Now;
var data2 = new DateTime(2005, 06, 02);
var diferenca = minhaPartialClass.DiferencaEntreDatas(data1, data2);
Console.WriteLine($"{Math.Round(diferenca.TotalDays / 365)} anos");

Console.ReadLine();