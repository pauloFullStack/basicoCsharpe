/* LINQ - Operadores de ordenação 
 * 
 * Os operadores de ordenação realizam o processo de gerenciar os dados em uma determinada ordem sem alterar os dados
 * ou a saída, apenas organizando os dados em uma ordem específica, ou seja, ordem crescente ou decrescente.
 * 
 * Alguns métodos fornecidos pela LINQ para ordenar os dados:
 * 
 * - OrderBy
 * - OrderByDescending
 * - ThenBy
 * - ThenByDescending
 * - Reverse
 */


/* LINQ - OrderBy e OrderByDescending 
 * 
 * OrderBy e OrderByDescending: O método OrderBy é usado para realizar a primeira ordenação em uma sequência de elementos. 
 * Ele classifica os elementos com base na chave de classificação especificada. Você pode usar OrderBy uma vez para classificar 
 * a sequência com base em uma chave primária.
 * 
 * ThenBy e ThenByDescendig: O método ThenBy é usado para realizar ordenações subsequentes em uma sequência que já foi classificada 
 * usando OrderBy. Ele permite que você adicione critérios de ordenação adicionais para os casos em que há valores iguais na chave 
 * de classificação principal (aquela definida com OrderBy).
 * ThenBy é útil quando você deseja realizar uma ordenação composta, onde os elementos são primeiro ordenados com base em uma chave 
 * principal e, em seguida, ordenados novamente com base em uma chave secundária quando os valores da chave principal são iguais.
 * 
 * Reverse: O método Reverse() retorna uma nova sequência que contém todos os elementos da sequência de origem na ordem oposta
 * 
 */

using LINQOperadoresDeOrdenacao;

/* OrderBy e OrderByDescending | ThenBy e ThenByDescending */
List<string> nomes = new List<string>()
{
    "Paulo", "Tarcisio", "Amaral", "Pedro", "Debora", "Helena", "Percival", "Manoel", "Rute", "Jose"
};

var nomeAsc = nomes.OrderBy(a => a).ToList();
foreach (var nome in nomeAsc)
    Console.WriteLine(nome);


Console.WriteLine("----------------------------");


var nomeDesc = nomes.OrderByDescending(a => a).ToList();
foreach (var nome in nomeDesc)
    Console.WriteLine(nome);


Console.WriteLine("----------------------------");


/* Ordenando Objetos */
var alunos = FonteDeDados.GetAlunos();

var listaAlunos1 = alunos.OrderBy(a => a.Nome);
foreach (var aluno in listaAlunos1)
    Console.WriteLine(aluno.Nome);


Console.WriteLine("----------------------------");


var listaAlunos2 = alunos.Where(a => a.Nome.Contains("r")).OrderBy(a => a.Nome);
foreach (var aluno in listaAlunos2)
    Console.WriteLine($"{aluno.Nome} {aluno.Idade}");


Console.WriteLine("----------------------------");


var listaAlunos3 = alunos
                        .Where(a => a.Nome.Contains("r"))
                        .OrderBy(a => a.Nome)
                        .ThenBy(a => a.Idade);
foreach (var aluno in listaAlunos3)
    Console.WriteLine($"{aluno.Nome} {aluno.Idade}");


Console.WriteLine("----------------------------");


var listaAlunos4 = alunos
                        .Where(a => a.Nome.Contains("r"))
                        .OrderByDescending(a => a.Nome)
                        .ThenByDescending(a => a.Idade);
foreach (var aluno in listaAlunos4)
    Console.WriteLine($"{aluno.Nome} {aluno.Idade}");


Console.WriteLine("----------------------------");


/* Reverse: existem dois tipos de Reverse o da LINQ = System.Linq e o System.Collections.Generic que tem duas sobrecargas,  
 * public void Reverse(), public void Reverse(int inde, int count)
 */

List<string> nomesReverse = new List<string>() 
{
    "Pedro", "Tania", "Amaral", "Penita", "Debora"
};
/* Usando System.Collections.Generic */
IEnumerable<string> listaReverse1 = nomesReverse.AsEnumerable().Reverse();
IQueryable<string> listaReverse2 = nomesReverse.AsQueryable().Reverse();

foreach (var nome in listaReverse1)
    Console.WriteLine($"{nome}");


Console.WriteLine("----------------------------");


Console.ReadKey();
