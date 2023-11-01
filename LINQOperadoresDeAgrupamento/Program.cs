/* LINQ - Operadores de agrupamento 
 * 
 * Criam um grupo de elementos com base na chave fornecida.
 * 
 * Esse grupo está contido em um tipo especial de coleção que implementa a interface IGrouping<TKey, TSource> em que TKey
 * é uma chave, no qual o grupo foi formado e TSource é a coleção de elementos que corresponde ao valor de chave de agrupamento.
 * 
 * GroupBy - Retorna grupos de elementos com base no valor de uma chave onde cada grupo é representado pelo objeto IGrouping<TKey, TElement>
 * 
 * ToLookp - Atua da mesma forma que GroupBy, a única diferença é que a execução de GroupBy é adiada(deferida), enquanto a execução de ToLookup
 * é imediata
 * 
 * O agrupamento é um dos recursos mais poderosos da LINQ, e, podemos agrupar dados das seguintes formas:
 * - Usando uma única propriedade;
 * - Pela primeira letra de uma propriedade;
 * - Usando um intervalo numérico calculado;
 * - Usando um predicado booleano ou outra expressão;
 * - Usando uma chave composta;
 * 
 * No grupamento podemos obter os elementos individuais, pois é criada uma sequência de grupos e esses grupos implementam IGrouping<TKey, T>
 * onde TKey é o atributo usado para fazer o agrupamento e T representa a entidade original.
 * 
 */


using LINQOperadoresDeAgrupamento;

List<Aluno> alunos = FonteDeDados.GetAlunos();

/*------------------ GroupBy ------------------*/

/* Sintaxe de metodo */
var grupo1 = alunos.GroupBy(a => a.Idade).OrderBy(b => b.Key);

/* Sintaxe de consulta */
var grupo2 = from a in alunos
             group a by a.Idade
             into grupo
             orderby grupo.Key
             select grupo;


foreach (var grupo in grupo1)
{
    Console.WriteLine($"\nExistem {grupo.Count()} alunos com a idade de {grupo.Key} anos");

    foreach (var aluno in grupo)
        Console.WriteLine($"\n      {aluno.Nome} {aluno.Idade}");
}

Console.WriteLine("------------------------");

List<Aluno> alunosA = FonteDeDados.GetAlunosA();
/* Agrupando e ordenando por curso e depois ordenando o alunos e ordem crescente */
var grupo3 = alunosA.GroupBy(a => a.Curso)
                   .OrderBy(b => b.Key)
                   .Select(c => new
                   {
                       Key = c.Key,
                       Alunos = c.OrderBy(x => x.Nome)
                   });
foreach (var grupo in grupo3)
{
    Console.WriteLine($"{grupo.Key} (alunos:{grupo.Alunos.Count()})");

    foreach (var aluno in grupo.Alunos)
    {
        Console.WriteLine($"\t{aluno.Nome} {aluno.Idade}");
    }
}

Console.WriteLine("------------------------");

var grupo4 = alunosA.GroupBy(a => new { a.Curso, a.Idade })
                   .OrderBy(b => b.Key.Curso)
                   .ThenBy(c => c.Key.Idade)
                   .Select(d => new
                   {
                       Curso = d.Key.Curso,
                       Idade = d.Key.Idade,
                       Alunos = d.OrderBy(e => e.Nome)
                   });

foreach (var grupo in grupo4)
{
    Console.WriteLine($"{grupo.Curso} (alunos:{grupo.Alunos.Count()})");

    foreach (var aluno in grupo.Alunos)
    {
        Console.WriteLine($"\t{aluno.Nome} {aluno.Idade}");
    }
}

Console.WriteLine("-------------------------");


/*------------------ ToLookup ------------------*/

var grupo6 = alunosA.ToLookup(a => a.Curso);

foreach (var grupo in grupo6)
{
    Console.WriteLine($"\n {grupo.Key} ({grupo.Count()})");
    foreach (var aluno in grupo)
    {
        Console.WriteLine($"\t{aluno.Nome} {aluno.Idade} {aluno.Sexo}");
    }
}


Console.ReadKey();