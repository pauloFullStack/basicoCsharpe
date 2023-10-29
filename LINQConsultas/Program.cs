/* Consultas LINQ - Filtrar dados 
 * 
 * 
 * Where - Método de extensão que filtra uma coleção de objetos com base em uma condição, é uma extensão da interface
 * IEnumerable<T> , recebe como argumento uma expressão lambda que define a condição de filtro, a expressão lambda deve
 * conter um único parâmetro do tipo T e retornar um booleano que indica se o elemento atende a condição ou não
 * 
 * Operadores de consulta que podem ser usados com conjunto com Where
 * - OrderBy e ThenBy (ordenação)
 * - Sum, Average, Count (cálculos)
 * - Select (projetar e transformar os dados; criar tipos anônimos; cria uma nova coleção)
 * 
 */

using LINQConsultas;

var listaProdutos = Produto.GetProdutos();

Console.WriteLine("\nProdutos eletrônicos\n");
/* Filtrando com condição */
var produtoEletronicos = listaProdutos.Where(produto => produto.Categoria == "Eletrônicos");
Loop(produtoEletronicos);


Console.WriteLine("--------------------------------");


/* Filtrando com duas condições */
Console.WriteLine("\nProdutos mais caros com estoque superior a 5: \n");
var produtoEletronicosMaisCarosEstoqueMiorQue5 = listaProdutos.Where(produto => produto.Preco >= 2000 && produto.Estoque > 5);
Loop(produtoEletronicosMaisCarosEstoqueMiorQue5);


Console.WriteLine("--------------------------------");


/* Filtrando com ordenação */
Console.WriteLine("\nLista de produtos com estoque minimo(<10) ordenados por nome\n");
var produtosEstoqueMenorQue10 = listaProdutos
                                        .Where(produto => produto.Estoque < 10)
                                        .OrderBy(produto => produto.Nome);


Loop(produtosEstoqueMenorQue10);


Console.WriteLine("--------------------------------");

/* Ordenando por mais de um criterio, ordena primeiro pela categoria, depois os itens que forem da mesma categoria,
 * serão ordenados pelo nome, cada categoria tem seu conjunto de produto, e dentro desse conjunto de produto de cada
 * categoria que os nomes vão ser ordenados
 */
Console.WriteLine("\nProdutos ordenados por categoria e nome\n");
var produtosOrdenadosPorCategoriaENome = listaProdutos
                                        .OrderBy(produto => produto.Categoria)
                                        .ThenBy(produto => produto.Nome);
Loop(produtosOrdenadosPorCategoriaENome);


Console.WriteLine("--------------------------------");


/* Cria uma lista de strings com nomes dos produtos */
Console.WriteLine("\nLista dos nomes dos produtos ordenados\n");
var nomesDoProdutos = listaProdutos.Select(produto => produto.Nome).OrderBy(nome => nome);
foreach (var nomeString in nomesDoProdutos) Console.WriteLine($"{nomeString}");


Console.WriteLine("--------------------------------");


/* Filtrando por preço, ordenando por nome e criando um tipo anônimo */
Console.WriteLine("\nFiltrando por preço, ordenando por nome e criando um tipo anônimo\n");
var resultado = listaProdutos
                        .Where(produto => produto.Preco < 500)
                        .OrderBy(protudo => protudo.Nome)
                        .Select(produto => new
                        {
                            NomeProduto = produto.Nome.ToUpper(),
                            PrecoComAumento = produto.Preco * 1.1
                        });

foreach (var dado in resultado) Console.WriteLine($"Nome: {dado.NomeProduto} - Valor Produto: {dado.PrecoComAumento:C}");


Console.WriteLine("--------------------------------");


/* Filtrando por preço, ordenando por preco e criando um tipo anônimo */
Console.WriteLine("\nFiltrando por preço, ordenando por preço e criando um tipo anônimo\n");
var resultado1 = listaProdutos
                        .Where(produto => produto.Preco > 2000)
                        .OrderBy(protudo => protudo.Preco)
                        .Select(produto => new
                        {
                            NomeDoProduto = produto.Nome.ToUpper(),
                            PrecoComDesconto = produto.Preco * 0.8
                        });

foreach (var dado in resultado1) Console.WriteLine($"Nome: {dado.NomeDoProduto} - Valor Produto: {dado.PrecoComDesconto:C}");


Console.WriteLine("--------------------------------");

/* Calculo Média usando Average */
double mediaPrecoEletronicos = listaProdutos
                                    .Where(produto => produto.Categoria == "Eletrônicos")
                                    .Average(produto => produto.Preco);
Console.WriteLine($"{mediaPrecoEletronicos:C}");

Console.WriteLine("--------------------------------");


/* Somando todos os valores de Preco */
double somaTotalDeTodosProdutosEstoque = listaProdutos
                                                .Where(produto => produto.Estoque > 0)
                                                .Sum(produto => produto.Preco * produto.Estoque);
Console.WriteLine($"{somaTotalDeTodosProdutosEstoque:C}");


Console.WriteLine("--------------------------------");


/* Contando a quantidade de produtos com estoque menor que 10 */
var produtosEstoqueMinimo = listaProdutos
                                                .Where(produto => produto.Estoque < 10).Count();
Console.WriteLine($"{produtosEstoqueMinimo}");


Console.WriteLine("## LINQ - Filtrar dados ## \n");

var numeros = FonteDeDados.GetNumeros();

/* Verificando se existe numeros de uma lista em outra */
var resultado10 = numeros.Where(a => !FonteDeDados.GetListaNegra().Contains(a));
Console.WriteLine(string.Join(",", resultado10));

var resultado11 = numeros
                .Where(numero => numero > 1)
                .Where(numero => numero != 4)
                .Where(numero => numero > 20);

Console.WriteLine("\n" + string.Join(",", resultado11));


var alunos = FonteDeDados.GetAlunos();

/* Trabalhar com objetos complexos */
var resultado2 = alunos.Where(aluno => aluno.Nome.StartsWith('A') && aluno.Idade < 18);

foreach (var result in resultado2)
    Console.WriteLine(result.Nome);


Console.ReadKey();

static void Loop(IEnumerable<Produto> dados)
{

    foreach (var dado in dados) Console.WriteLine($"" +
                          $" Id: {dado.Id}" +
                          $" Nome: {dado.Nome}" +
                          $" Preço: {dado.Preco.ToString("c")}" +
                          $" Estoque: {dado.Estoque}" +
                          $" Categoria: {dado.Categoria}");

}
