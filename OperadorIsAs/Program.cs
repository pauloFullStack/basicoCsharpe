
/* O operador 'as' é usado para realizar a conversão entre tipos de referência ou tipos
 * anuláveis compatíveis
 * 
 * Este operador retorna o objeto quando ele é compatível com o tipo dado e retorna null
 * se a conversão não for possível ao invés de gerar uma exceção.
 * 
 * Ao realizar uma operação de downcasting (base -> derivada) ele avalia o resultado para null
 * ao invés de lançar uma exceção (InvalidCastException) caso a operação não seja possível
 * 
 * O operador 'as' é um operador de conversão de tipos (referência e anuláveis)
 */

Object carroObj = new Carro();

try
{
    /* var x = (string)carroObj; */
    var x = carroObj as string;

    if (x != null)
    {
        Console.WriteLine("Converteu obj para string");
    }
    else
    {
        Console.WriteLine("y é null");
    }
}
catch (Exception ex)
{
    Console.WriteLine("\nA conversão falhou...\n");
    Console.WriteLine(ex.Message);
}


/* Operador 'is'
 * 
 * O operador 'is' é usado para verificar se o tipo de um objeto é compatível com o tipo
 * especificado ou não 
 * 
 * Retorna true se o objeto especificado for do mesmo tipo, caso contrário, retorna false.
 * Retorna false também para objetos nulos.
 * 
 * Podemos usar o operador 'is' para verificar se uma conversão entre tipos será bem sucedida ou não
 * 
 * O operador 'is' é um operador do tipo booleano de comparação de tipos
 * 
 */


try
{
    
    if (carroObj is string)
    {
        var x = carroObj as string;
        Console.WriteLine("Converteu obj para string");
    }
    else
    {
        Console.WriteLine("Elemento não apto para conversão");
    }    

}
catch (Exception ex)
{
    Console.WriteLine("\nA conversão falhou...\n");
    Console.WriteLine(ex.Message);
}


Chevrolet chevrolet = new Chevrolet();


if (chevrolet is Carro)
{
    var x = chevrolet as Carro;
    Console.WriteLine("Converteu obj");
}
else
{
    Console.WriteLine("Elemento não apto para conversão");
}

Console.ReadKey();


class Carro
{
    public int Numero { get; set; }
    public string? Nome { get; set; }
}


class Chevrolet : Carro
{
    public int LitroPorKm { get; set; }
}



/* A diferença entre os operadores 'is' e 'as' 
 * 
 * O operador 'is' é usado para 'verificar' se o tipo de um objeto é compatível com o tipo
 * fornecido ou não, enquanto o operador 'as' é usado para realizar a conversão entre tipos
 * de referência compatíveis ou tipos anuláveis.
 * 
 * O operador 'is' é do tipo booleano, enquanto o operador 'as' não é do tipo booleano.
 * 
 * O operador 'is' retorna true ou false ao fazer a comparação entre os tipos fornecidos,
 * enquanto o operador 'as' retorna null se a conversão não for possível.
 * 
 * O operador 'is' é usado apenas para conversões de referência, boxing e unboxing, enquanto
 * o operador 'as' é usado apenas para conversões anuláveis, de referência e boxing
 * 
 */