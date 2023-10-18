/* Consulta LINQ - Localizando um elemento 
 * 
 * First - Retorna o primeiro elemento da sequência ou o elemento que atenda a uma condição e lança uma 
 * exceção se nenhum elemento for encontrado
 * 
 * FirstOrDefault - Retorna o primeiro elemento da sequência ou o elemento que atenda uma condição. Retorna
 * o valor padrão se nenhum elemento for encontrado
 * 
 * Last - Retorna o último elemento da sequência ou o elemento que atenda a uma condição e lança uma exceção
 * se nenhum elemento for encontrado.
 * 
 * LastOrDefault - Retorna o último elemento da sequência ou o elemento que atenda a uma condição.
 * Retorna o valor padrão se nenhum elemento for encontrado
 * 
 * Single - Retorna o único elemento da sequência que atende uma condição e lança uma exceção se nenhum elemento
 * for encontrado. Lança uma exceção se houver mais de um elemento que atenda a condição 
 * 
 * SingleOrDefault - Retorna o único elemento da sequência que atende uma condição ou o valor padrão se o elemento
 * não for encontrado. Lança uma exceção se houver mais de um elemento que atenda a condição.
 * 
 */

using LINQConsultas2;

var listaProdutos = Produtos.GetProdutos();



try
{
    /* - First
     * Para usa First a fonte de dados não pode estar vazia, se não ele lança uma uma exceção, usar try/catch com First */
    /* First - Localiza o primeiro elemento */
    Cw("\nFirst - Localiza o primeiro elemento");
    var primeiroProduto = listaProdutos.First();
    Cw($"{primeiroProduto.Nome} \t{primeiroProduto.Preco:C}");

    /* First - Localiza o primeiro elemento usando um critério de Nome */
    Cw("\nFirst - Localiza o primeiro elemento usando um critério de Nome");
    var primeiraOcorrenciaComCriterio = listaProdutos.First(produto => produto.Nome == "Cadeira");
    Cw($"{primeiraOcorrenciaComCriterio.Nome} {primeiraOcorrenciaComCriterio.Preco:C}");
}
catch (Exception ex)
{
    Cw(ex.Message);
}


/* - FirstOrDefault 
 * Pode ter fonte de dados vazio que não lança exceção , so retorna null
 */
/* - FirstOrDefault - Localiza o primeiro elemento usando um critério de Nome */
Cw("\nFirstOrDefault - Localiza o primeiro elemento usando um critério de Nome");
//var primeiraOcorrenciaComCriterio2 = listaProdutos.FirstOrDefault();
var primeiraOcorrenciaComCriterio2 = listaProdutos.FirstOrDefault(produto => produto.Nome == "Cadeira");
if (primeiraOcorrenciaComCriterio2 != null) Cw($"{primeiraOcorrenciaComCriterio2.Nome} {primeiraOcorrenciaComCriterio2.Preco:C}");
else Cw("Nenhum elemento foi encontrado segundo o critério");




try
{
    /* - Single
     * Para usa First a fonte de dados não pode estar vazia, se não ele lança uma uma exceção, usar try/catch com First */
    /* First - Localiza o primeiro elemento */
    Cw("\nFirst - Localiza o primeiro elemento");
    var primeiroProduto = listaProdutos.First();
    Cw($"{primeiroProduto.Nome} \t{primeiroProduto.Preco:C}");

    /* First - Localiza o primeiro elemento usando um critério de Nome */
    Cw("\nFirst - Localiza o primeiro elemento usando um critério de Nome");
    var primeiraOcorrenciaComCriterio = listaProdutos.First(produto => produto.Nome == "Cadeira");
    Cw($"{primeiraOcorrenciaComCriterio.Nome} {primeiraOcorrenciaComCriterio.Preco:C}");
}
catch (Exception ex)
{
    Cw(ex.Message);
}


/* - SingleOrDefault 
 * Pode ter fonte de dados vazio que não lança exceção , so retorna null
 */
/* - FirstOrDefault - Localiza o primeiro elemento usando um critério de Nome */
Cw("\nFirstOrDefault - Localiza o primeiro elemento usando um critério de Nome");
//var primeiraOcorrenciaComCriterio2 = listaProdutos.FirstOrDefault();
var primeiraOcorrenciaComCriterio3 = listaProdutos.FirstOrDefault(produto => produto.Nome == "Cadeira");
if (primeiraOcorrenciaComCriterio3 != null) Cw($"{primeiraOcorrenciaComCriterio3.Nome} {primeiraOcorrenciaComCriterio3.Preco:C}");
else Cw("Nenhum elemento foi encontrado segundo o critério");


try
{

    /* - Last 
     * Retorna exceção caso esteja vazio a fonte de dados
     */
    /* Last - Localiza o último elemento */
    //var ultimoProduto = listaProdutos.Last();
    var ultimoProduto = listaProdutos.Last(produto => produto.Categoria == "Roupas");
    Cw($"{ultimoProduto.Nome} \t{ultimoProduto.Preco:C}");

}
catch (Exception ex)
{
    Cw(ex.Message);
}


/* - LastOrDefault 
 * Pode ter fonte de dados vazia, retorna null
 */
/* Last - Localiza o último elemento */
//var ultimoProduto2 = listaProdutos.LastOrDefault();
var ultimoProduto2 = listaProdutos.LastOrDefault(produto => produto.Categoria == "Eletrônicos");
if (ultimoProduto2 != null) Cw($"{ultimoProduto2.Nome} \t{ultimoProduto2.Preco:C}");
else Cw("Nenhum elemento foi encontrado segundo o critério");



try
{
    /* - Single
     * Para usa Single a fonte de dados não pode estar vazia, se não ele lança uma uma exceção, usar try/catch com Single */
    /* Single - Localiza o único elemento */
    Cw("\nFirst - Localiza o primeiro elemento");
    var primeiroProduto = listaProdutos.Single();
    Cw($"{primeiroProduto.Nome} \t{primeiroProduto.Preco:C}");

    /* Single - Localiza o único elemento usando um critério de Nome */
    Cw("\nFirst - Localiza o único elemento usando um critério de Nome");
    var primeiraOcorrenciaComCriterio = listaProdutos.Single(produto => produto.Nome == "Meia Soc.");
    Cw($"{primeiraOcorrenciaComCriterio.Nome} {primeiraOcorrenciaComCriterio.Preco:C}");
}
catch (Exception ex)
{
    Cw(ex.Message);
}


/* - SingleOrDefault 
 * Pode ter fonte de dados vazio que não lança exceção , so retorna null
 */
/* - SingleOrDefault - Localiza o único elemento usando um critério de Nome */
Cw("\nSingleOrDefault - Localiza o unico elemento usando um critério de Nome");
//var primeiraOcorrenciaComCriterio2 = listaProdutos.SingleOrDefault();
var primeiraOcorrenciaComCriterio4 = listaProdutos.SingleOrDefault(produto => produto.Nome == "Meia Soc.");
if (primeiraOcorrenciaComCriterio4 != null) Cw($"{primeiraOcorrenciaComCriterio4.Nome} {primeiraOcorrenciaComCriterio4.Preco:C}");
else Cw("Nenhum elemento foi encontrado segundo o critério");


Console.ReadKey();

static void Cw(string text)
{
    Console.WriteLine(text);
}