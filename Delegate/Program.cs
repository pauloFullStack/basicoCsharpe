/* Delegate 
 * 
 * 
 * Um delegate é um tipo que representa referências a métodos com uma lista de parâmetros e um tipo de retorno específicos
 * 
 * Ao instanciar um delegate, podemos associar a sua instância a qualquer método com uma assinatura compatível e tipo de 
 * retorno, e, podemos invocar o método por meio da instância delegada
 * 
 * Os delegates são usados para implementar eventos, métodos de retorno de chamadas e para passar métodos como argumentos para 
 * outros métodos.
 * 
 * Usando delegates temos a flexibilidade para implementar qualquer funcionalidade em tempo de execução.
 * 
 * Um delegate é um tipo de dados(tipo de referência) que define a assinatura de um método
 * 
 * Podemos definir variáveis de um tipo delegate que podem se referir a qualquer método que tiverem a mesma assinatura
 * do delegate
 * 
 * Há três etapas envolvidas ao trabalhar com delegates:
 * 
 * 1 - Declarar um delegate
 * 2 - Definir um método de destino
 * 3 - Invocar ou chamar um delegate
 * 
 */


/* Delegate - declaração do delegate 
 * 
 * 
 * Um delegate pode ser declarado usando a palavra-chave delegate seguindo pela assinatura do método
 * Ex: [modificador de acesso] delegate [tipo de retorno] [nome do delegate]([parâmetros])
 * Ex: public delegate void MeuDelegate(string mensagem);
 * 
 */


/* Delegate -  definição do método de destino 
 * 
 * 
 * Depois de declarar um delegado, precisamos definir o método de destino ou uma expressão lambda.
 * 
 * Podemos fazer isso criando um objeto do delegate usando a palavra-chave new e passando um método cuja assinatura
 * corresponda à assinatura do delegate.
 */


/* Delegate - Invocação do delegate 
 * 
 * 
 * Depois de definir um método de destino, um delegate pode ser invocado usando o método Invoke() ou usando o operador () 
 * passando os parâmetros definidos
 */


using Delegate;

internal class Program
{


    /* Declarando delegate */
    public delegate float DelegateCalculadora(float n1, float n2, char operation);
    public delegate float DelegateCalculadoraMetodoSeparados(float n1, float n2);


    private static void Main(string[] args)
    {
        float res = Calculadora.OperacoesAritmeticas(10, 20, '+');
        Console.WriteLine(res);

        /* Atribuindo um metodo ao delegate, Forma 1 */
        DelegateCalculadora calculaora1 = new DelegateCalculadora(Calculadora.OperacoesAritmeticas);
        /* Chamando o metodo atribuido no delegate, com o metod Invoke do delegate */
        var res1 = calculaora1.Invoke(440, 30, '-');
        Console.WriteLine(res1);


        /* Atribuindo um metodo ao delegate, Forma 2 */
        DelegateCalculadora calculaora2 = Calculadora.OperacoesAritmeticas;
        var res2 = calculaora2(50, 30, '*');
        Console.WriteLine(res2);


        /* Atribuindo um metodo ao delegate, Forma 1 */
        DelegateCalculadora calculaora3 = (float x, float y, char op) => Calculadora.OperacoesAritmeticas(x, y, op);
        var res3 = calculaora3(30, 2, '/');
        Console.WriteLine(res3);


        Console.WriteLine("\n------------- Atribuindo mais metodos no mesmo delegate ----------------");


        DelegateCalculadoraMetodoSeparados calculadoraMtSeparados = Calculadora.Somar;
        Console.WriteLine(calculadoraMtSeparados(10, 10));

        calculadoraMtSeparados = Calculadora.Subtrair;
        Console.WriteLine(calculadoraMtSeparados(10, 10));

        calculadoraMtSeparados = Calculadora.Multiplicar;
        Console.WriteLine(calculadoraMtSeparados(10, 10));

        calculadoraMtSeparados = Calculadora.Dividir;
        Console.WriteLine(calculadoraMtSeparados(10, 10));

        Console.ReadKey();
    }
}

