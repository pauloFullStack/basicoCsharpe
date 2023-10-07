/* Métodos Estáticos */

/* Um método estático é definido usando o modificador static na declaração do método 
 * 
 * O modificador 'static' pode ser usado em  classes, interfaces, structs, campos, 
 * métodos, propriedades, operadores, eventos e construtores
 */


/* O que são métodos estáticos
 * 
 * Os métodos estáticos são métodos que não dependem de um objeto ou seja não dependem 
 * de criação de uma instância da classe para serem acessados
 * 
 * Os métodos estáticos pertencem à classe e não ao objeto
 * 
 * Como o método estático não possui ligação com um objeto, ele não pode usar variáveis
 * de instância, que são variáveis do objeto
 * 
 * Exemplos: Classes Math e Console e o método Main
 */

Console.WriteLine("## Métodos estáticos ##\n");

int somar = Calculadora.Somar(10, 10);
int subtrair = Calculadora.Subtrair(10, 10);
int multiplicar = Calculadora.Multiplicar(10, 10);
int dividir = Calculadora.Dividir(10, 10);

Console.WriteLine($"\n{somar}\n{subtrair}\n{multiplicar}\n{dividir}");

Console.ReadLine();

public class Calculadora
{

    public static int Somar(int n1, int n2)
    {
        return n1 + n2;
    }

    public static int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }

    public static int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }

    public static int Dividir(int n1, int n2)
    {
        return n1 / n2;
    }

}