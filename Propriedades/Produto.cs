/* Usando 'get', 'set' você permite atribuir e ler a propriedade, usando somente 'get' você permite somente leitura
 * e não é permitido atribuir valor, usando somente 'set' você permite somente atribuir valor e não pode ler a propriedade 
 */

public class Produto
{


    /* Campo */
    private string? _nome;
    /* Propriedade */
    public string? Nome
    {
        get { return _nome.ToUpper(); }
        set { _nome = value; }
    }



    /* Campo */
    private double _preco;
    /* Propriedade */
    public double Preco
    {
        get { return _preco; }
        set
        {
            if (value < 5.00)
                _preco = 5.00;
            else
                _preco = value;
        }
    }



    /* Campo */
    private double _desconto = 0.05;
    /* Propriedade somente leitura */
    public double Desconto { get { return _desconto; } }



    /* Propriedade */
    public double PrecoFinal
    {
        get { return Preco - (Preco * Desconto); }
    }



    private int _estoqueMinimo;
    public int EstoqueMinimo
    {
        set { _estoqueMinimo = value; }
    }


    public void Exibir()
    {
        Console.WriteLine($"Produto: {Nome} \nPreço: {Preco.ToString("c")} \nDesconto: {Desconto} \nPreço Final: {PrecoFinal.ToString("c")} \nQuantidade Estoque: {_estoqueMinimo}");
    }


}