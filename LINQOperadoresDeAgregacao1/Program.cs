/* LINQ - Operadores de agregação 
 * 
 * São usados para realizar operações matemáticas em uma coleção de valores retornando único valor.
 * 
 * Aggregate - Executa uma operação de agregação personalizada nos valores da coleção.
 * Average - Calcula a média dos itens numéricos em uma coleção
 * Count - Conta os elementos em uma coleção
 * LongCount - Conta os elementos em uma coleção grande
 * Max ou MaxBy - Determine o valor máximo em uma coleção
 * Min ou MinBy - Determine o valor mínimo em uma coleção
 * Sum - Calcula a soma dos valores em uma coleção
 * 
 */

using LINQOperadoresDeAgregacao1;

Console.WriteLine("## Operadores de Agregação ##\n");

/*------------------ Aggregate ------------------*/

/* 1 sobrecarga do Aggregate */
string[] cursos = { "C#", "Java", "Phyton", "PHP", "JavaScript", "Go", "ASP.NET", "Node" };
string resultadoStr = cursos.Aggregate((s1, s2) => s1 + "," + s2);
Console.WriteLine(resultadoStr);
Console.WriteLine("------------------------------");


int[] numeros = { 3, 5, 7, 9, 10, 12, 15, 20, 30, 39 };
int resultadoInt = numeros.Aggregate((n1, n2) => n1 * n2);
Console.WriteLine(resultadoInt);
Console.WriteLine("------------------------------");

/* 2 sobrecarga do Aggregate */
var alunos = FonteDeDados.GetAlunos();
string listaAlunos = alunos.Aggregate<Aluno, string>(
                            "Nomes : ",
                            (inicio, aluno) => inicio += aluno.Nome + ", ");
/* Removendo a ultima virgula */
int indice = listaAlunos.LastIndexOf(",");
listaAlunos = listaAlunos.Remove(indice);
Console.WriteLine(listaAlunos);
Console.WriteLine("------------------------------");

/* 3 sobrecarga do Aggregate */
/* Removendo o utlimo caracter no caso a virgula */
var alunos1 = FonteDeDados.GetAlunos();
string listaAlunos1 = alunos.Aggregate<Aluno, string, string>(
                            "Nomes : ",
                            (inicio, aluno) => inicio += aluno.Nome + ",",
                            resultado => resultado.Substring(0, resultado.Length - 1));

Console.WriteLine(listaAlunos1);
Console.WriteLine("------------------------------");


/*------------------ Average - Calula a media da idade ------------------*/

var alunos2 = FonteDeDados.GetAlunos();
var listaAlunos2 = alunos.Average(aluno => aluno.Idade);
Console.WriteLine(listaAlunos2);
Console.WriteLine("------------------------------");


/*------------------ Count ------------------*/

var cursos2 = cursos.Count();
Console.WriteLine($"Quantidade de cursos {cursos2}");
Console.WriteLine("------------------------------");

/* Count usando a 2 sobrecarga */
var cursos3 = cursos.Count(c => c.Contains('p'));
Console.WriteLine($"Quantidade de cursos que tem a letra 'p' {cursos3}");
Console.WriteLine("------------------------------");


/*------------------ LongCount ------------------*/

var cursos4 = cursos.LongCount();
Console.WriteLine($"Quantidade de cursos {cursos4}");
Console.WriteLine("------------------------------");

/* Count usando a 2 sobrecarga */
var cursos5 = cursos.LongCount(c => c.Contains('p'));
Console.WriteLine($"Quantidade de cursos que tem a letra 'p' {cursos5}");
Console.WriteLine("------------------------------");


/*------------------ Sum ------------------*/

var soma = numeros.Sum();
Console.WriteLine($"Soma da lista {soma} ");
Console.WriteLine("------------------------------");

/* Usando filtro no Sum */
var soma1 = numeros.Sum(n => { if (n > 10) return n; else return 0; });
//var soma1 = numeros.Where(n => n > 10).Sum();
Console.WriteLine($"Soma da lista maior que 10 = {soma1} ");
Console.WriteLine("------------------------------");


/*------------------ Max / MaxBy ------------------*/

var maiorIdade = alunos.Max(a => a.Idade);
Console.WriteLine($"Maior idade {maiorIdade} ");
Console.WriteLine("------------------------------");

/* Sobrecarga Max */
var maiorSobrecargaIdade = alunos.Max(a => { if (a.Nota > 5) return a.Idade; else return 0; });
Console.WriteLine($"Maior idade com (notas > 5) = {maiorSobrecargaIdade} ");
Console.WriteLine("------------------------------");

/*------------------ Min / MinBy ------------------*/

var menorIdade = alunos.Min(a => a.Idade);
Console.WriteLine($"Menor idade {menorIdade} ");
Console.WriteLine("------------------------------");

/* Sobrecarga Min */
var minimoSobrecargaIdade = alunos.Where(a => a.Nota < 5).Min(b => b.Idade);
Console.WriteLine($"Menor idade com (notas <  5) = {minimoSobrecargaIdade} ");
Console.WriteLine("------------------------------");

Console.ReadKey();