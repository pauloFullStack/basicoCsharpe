/* Inferência de tipos: var
 * 
 * A partir da versão 3.0 da linguagem C# as variáveis que forem declaradas no espoco do método podem possuir um tipo implicito var 
 * 
 * Usar a palavra-chave var para instruir o compilador para deduzir o tipo da variável da expressão a partir do lado direito da instrução de inicialização
 * 
 *O tipo inferido pode ser um tipo interno, um tipo anônimo, um tipo definido pelo usuário ou um tipo definido na biblioteca de classes da plataforma .NET
 *
 */



/* Inferência de tipos - palavra-chave var: limitações
 * 
 * A palavra-chave var só pode ser usada quando uma variável local é declarada e inicializada na mesma instrução;
 * 
 * Não é possível inicializar a variável como null
 * 
 * Múltiplas variáveis de tipo implícito não podem ser incializadas na mesma instrução;
 * 
 * Não podemos alterar o tipo da variável 'var' depois de inicializada.
 * 
 */


var idade = 25;
var nome = "Maria";
var salario = 2500.00m;

Console.WriteLine($"{nome} tem {idade} anos e ganha {salario.ToString("c")}");

/* 'var' limitações - não pode ser usado com var
 * 
 * var salario = null;
 * var titulo;
 * var salario, imposto, total;
 * 
 * Não pode mudar o tipo
 * 
 * var num = 10;
 * num = "Teste";
 */

Console.WriteLine("Digit qualquer numero\n");
int n = Convert.ToInt32(Console.ReadLine());

var t = new Teste();
new Teste(n);
t.MetodTeste();

Console.ReadKey();

class Teste
{
    public Teste()
    {
        Console.WriteLine("Instanciando a class Teste - Metodo construtor");
    }

    public Teste(int n)
    {
        Console.WriteLine($"{n} x 2 = {n * 2}");
    }

    public void MetodTeste()
    {
        Console.WriteLine("Metodo teste");
    }

}