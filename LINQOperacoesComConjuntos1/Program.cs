﻿/* LINQ - Operações de conjunto 
 * 
 * As operações de conjunto na LINQ referem-se a operações de consulta que geram um conjunto de resultados
 * baseado na presença ou ausência de elementos equivalentes dentro da mesma ou de coleções(ou conjuntos) separados.
 * 
 * Isso significa que essas operações são executadas em uma única fonte de dados ou em várias fontes de dados, e, na 
 * saída, alguns dos dados estão presentes e alguns estão ausentes.
 * 
 * 
 * Temos 4 operadores usados nas consultas de LINQ para operações de conjunto:
 * 
 * 1-Distinct ou DistinctyBy - Remove os valores duplicados de uma coleção, Usado quando queremos remover os dados ou registros duplicados
 * de uma fonte de dados. Esse método opera em uma unica fonte de dados.
 * 
 * 2-Except ou ExceptyBy - Retorna a diferença de conjunto, ou seja, os elementos de uma coleção que não aparecem em uma segunda
 * coleção, Usado quando queremos retornar todos os elementos da primeira fonte de dados que não existem na segunda fonte de dados.
 * Esse método opera em duas fontes de dados.
 * 
 * 3-Intersect ou IntersectBy - Retorna a interseção de conjunto, ou seja, os elementos que aparecem em cada uma das duas coleções, é usado
 * para retornar os elementos comuns de ambas as fontes de dados, ou seja, os elementos que existem em ambos os conjuntos de dados
 * retornarão como a saída.
 * 
 * 4-Union ou UnionBy - Retorna a união de conjunto, ou seja, os elementos únicos que aparecem em qualquer uma das duas coleções, é usado
 * para retornar todos os elementos que estão presentes em qualquer uma das fontes de dados. Isso significa que ele combina os dados de ambas
 * as fontes de dados e produz um único conjunto de resultados.
 * 
 */


using LINQOperacoesComConjuntos1;
using System.Linq;

Console.WriteLine("## LINQ - Operações com conjuntos ##\n");

/* Distinct() - Remove duplicadas */
var idadesDistintas = FonteDeDados.GetIdades().Distinct();
foreach (var idade in idadesDistintas)
    Console.WriteLine(idade);


Console.WriteLine("-------------------------------------");


/* Distinct(StringComparer.OrdinalIgnoreCase) - Ignora maisculo e minusculo */
var nomesDistintos = FonteDeDados.GetNomes().Distinct(StringComparer.OrdinalIgnoreCase);
foreach (var nome in nomesDistintos)
    Console.WriteLine(nome);


Console.WriteLine("-------------------------------------");


/* DistinctBy: O método DistinctBy permite que você especifique uma função que determine a igualdade entre elementos com base em critérios específicos. */
var alunosIdadesDistintas = FonteDeDados.GetAlunos()
                                            .ToList()
                                            .DistinctBy(aluno => aluno.Idade);
foreach (var aluno in alunosIdadesDistintas)
    Console.WriteLine($"{aluno.Nome} tem {aluno.Idade} anos");



Console.WriteLine("-------------------------------------");


/* Except ou ExceptyBy */

/* Except: pega todos os valores da primeira lista que nao existem na segunda */
List<int> fonte1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
List<int> fonte2 = new List<int>() { 1, 3, 5, 8, 9, 10 };

var resultado = fonte1.Except(fonte2).ToList();
foreach (var item in resultado)
    Console.WriteLine(item);


Console.WriteLine("-------------------------------------");


string[] fonteStr1 = { "Brasil", "USA", "UK", "Argentina", "China" };
string[] fonteStr2 = { "brasil", "uk", "argentina", "França", "Japão" };

var resutadoStr = fonteStr1.Except(fonteStr2, StringComparer.OrdinalIgnoreCase);
foreach (var pais in resutadoStr)
    Console.WriteLine(pais);


Console.WriteLine("-------------------------------------");


/* ExceptyBy: O método ExceptyBy permite que você especifique uma função que determine o resultado com base em critérios específicos. Mas o a logica é igual do Excepty
 */
var alunos = FonteDeDados.GetAlunos();
var alunosReprovados = new List<string>() { "Amanda", "Alicia", "Jaime" };
var alunosAprovados = alunos.ExceptBy(alunosReprovados, aluno => aluno.Nome);
foreach (var aluno in alunosAprovados)
    Console.WriteLine(aluno.Nome);


Console.WriteLine("-------------------------------------");


/* Intersect ou IntersectBy 
 * 
 * É usado para retornar os elementos comuns de ambas as fontes de dados, ou seja, os elementos que existem em ambos os conjuntos de dados
 * retornarão como a saida.
 */
List<int> fonte1Intersect = new List<int>() { 1, 2, 3, 4, 5, 6 };
List<int> fonte2Intersect = new List<int>() { 1, 3, 5, 8, 9, 10 };

var resultIntersect = fonte1Intersect.Intersect(fonte2Intersect).ToList();
foreach (var intersect in resultIntersect)
    Console.WriteLine(intersect);


Console.WriteLine("-------------------------------------");


var resultIntersectStr = fonteStr1.Intersect(fonteStr2, StringComparer.OrdinalIgnoreCase).ToList();
foreach (var intersect in resultIntersectStr)
    Console.WriteLine(intersect);


Console.WriteLine("-------------------------------------");


var turmaA = FonteDeDados.GetTurmaA();
var turmaB = FonteDeDados.GetTurmaB();

var consultaIntersect = turmaA.Select(a => a.Nascimento.Year)
                      .Intersect(turmaB.Select(b => b.Nascimento.Year));
foreach (var intersect in consultaIntersect)
    Console.WriteLine(intersect);


Console.WriteLine("-------------------------------------");

/* IntersectBy */
var consultaIntersectBy = turmaA.IntersectBy(turmaB.Select(n => n.Nascimento.Year), n => n.Nascimento.Year);
foreach (var intersect in consultaIntersectBy)
    Console.WriteLine($"{intersect.Nome}");

Console.WriteLine($"\nTotal de Alunos: {consultaIntersectBy.Count()}");


Console.WriteLine("-------------------------------------");


/* Union ou UnionBy 
 * 
 * É usado para retornar todos os elementos que estão presentes em qualquer uma das fontes de dados. Isso significa que ele combina os dados
 * de ambas as fontes de dados e produz um único conjunto de resultados.
 */

/* Union Retorna array */
List<int> fonte1Union = new List<int>() { 1, 2, 3, 4, 5, 6 };
List<int> fonte2Union = new List<int>() { 1, 3, 5, 8, 9, 10 };

var resultUnion = fonte1Union.Union(fonte2Union).ToList();
foreach (var union in resultUnion)
    Console.WriteLine(union);


Console.WriteLine("-------------------------------------");


var resultUnionStr = fonteStr1.Union(fonteStr2, StringComparer.OrdinalIgnoreCase).ToList();
foreach (var union in resultUnionStr)
    Console.WriteLine(union);


Console.WriteLine("-------------------------------------");


/* UnionBy: Retorna objetos, predomina o primeiro conjunot, por exemplo, se tiver duas marias na turmaA e turmaB, a maria da turmaA que sera adicionado e maria da turmaB não */
var turmaUnionBy = turmaA.UnionBy(turmaB, turmA => turmA.Nome).OrderBy(o => o.Nome);
foreach (var union in turmaUnionBy)
    Console.WriteLine($"{union.Nome} {union.Nascimento.Year} {union.Idade}");

Console.ReadKey();