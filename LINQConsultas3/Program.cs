/* Consulta LINQ - Agrupamento
 * 
 * 
 * GroupBy - Agrupa os elementos de uma sequência
 * 1 - O agrupamento é dado por um objeto IGrouping<TKey,T>
 * 2 - O TKey representa a chave do agrupamento e T é o elemento que desejamos agrupar;
 * 3 - Para uma chave composta, definimos um tipo anônimo usando a palavra-chave new;
 * 4 - Retorna um IEnumerable<IGrouping<TKey,TSource>>
 */


using LINQConsultas3;

var listaProdutos = Produtos.GetProdutos();

var produtosPorCategoria = listaProdutos
                                .GroupBy(a => a.Categoria)
                                .OrderBy(b => b.Key)
                                .Select(c => new
                                {
                                    Categoria = c.Key,
                                    ContaCategoria = c.Count(),
                                    Produtos = c.OrderBy(d => d.Nome)
                                    .Select(e => new
                                    {
                                        Nome = e.Nome,
                                        Preco = e.Preco,
                                        Estoque = e.Estoque,
                                    })
                                });

foreach (var grupo in produtosPorCategoria)
{
    Console.WriteLine($"{grupo.Categoria} : {grupo.ContaCategoria}");

    foreach (var produto in grupo.Produtos)
        Console.WriteLine($"{produto.Nome} \t{produto.Preco:C} \t{produto.Estoque}");
    Console.WriteLine();
}



Console.ReadKey();