/* LINQ - Operadores de projeção 
 * 
 * Projeção: 
 * 
 * É o mecanismo usado para selecionar os dados de uma fonte de dados:
 * 
 * 1-Selecionar todos os dados no estado original
 * 2-Criar um novo formato de dados realizando operações nos dados originais
 * 
 * Temos dois métodos usados para projeção:
 * 
 *  1-Select
 *  2-SelectMany
 *  
 */


/* LINQ - Select 
 * 
 * - Permite especificar quais propriedades queremos recuperar: todas as propriedades ou apenas algumas das propriedades
 * - Permite realizar alguns cálculos
 * 
 * Execução Imediata na LINQ
 * 
 * Força a consulta LINQ a ser executada e a retornar o resultado imediatamente
 * É obtida usando os operadores de conversão:
 * ToList(), ToArray(), AsEnumerable, AsQueryable, ToDictionary(), ToLooKup()
 * 
 */


/* LINQ - SelectMany 
 * 
 * - É usado para projetar cada elemento de uma sequência para um IEnumerable<T> e, em seguida, nivelar as sequências resultantes em 
 * uma sequência.
 * - SelectMany combina os registros de uma sequência de resultados e os converte em um resultado.
 * - Ele transforma um IEnumerable<IEnumerable<T>> em IEnumerable<T>, ou seja, uma lista de lista para uma lista
 */

using LINQOperadoresDeProjecao;

Console.WriteLine("## LINQ - Operadores de Projeção ## \n");

var lista = FonteDeDados.GetAlunos().Select(aluno => new
{
    NomeAluno = aluno.Nome,
    IdadeAluno = aluno.Idade,

}).ToList();

Console.WriteLine("\nAlunos Idade");
foreach (var aluno in lista)
    Console.WriteLine($"{aluno.NomeAluno} : {aluno.IdadeAluno}");

Console.WriteLine("------ SelectMany ------");
/* SelectMany: junta todas as lista e uma só */
List<List<int>> listas = new List<List<int>>
{
    new List<int> { 1, 2, 3 },
    new List<int> { 12 },
    new List<int> { 5,6,5, 7},
    new List<int> { 10,12,12,13},
};

/* Removendo as duplicada */
IEnumerable<int> resultado = listas.SelectMany(lista => lista.Distinct());

foreach (var item in resultado)
    Console.Write($" {item}");


/* Exemplo de Select e SelectMany */
var retornaSelect = FonteDeDados.GetAlunos().Select(curso => curso.Cursos);
/* Usando Select */
Console.WriteLine("\n\nUsando Select\n");
foreach (List<string> listasCursos in retornaSelect)
{
    foreach (string curso in listasCursos)
        Console.Write($"{curso}");

    Console.WriteLine();
}


var retornaSelectMany = FonteDeDados.GetAlunos().SelectMany(curso => curso.Cursos);
/* Usando SelectMany */
Console.WriteLine("\n\nUsando SelectMany\n");
foreach (string curso in retornaSelectMany)
    Console.Write($" {curso}");




Console.ReadKey();
