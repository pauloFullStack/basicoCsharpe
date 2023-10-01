/* - Representam números reais  
 * - São tipos de valor armazenados na stack
 * - O valor padrão dos tipos de dados ponto flutuante é zero (0)
 * - Dão suporte a operadores aritméticos de comparação (>,<,>=,<=,!=) e de igualdade (==)
 * - O tipo double é usado para cálculos científicos e o decimal para cálculos financeiros
 * - São tipos que podemos inicializar  usando literais (f-F, d-D, m-M)
 */

Console.WriteLine("Atribuindo valores a double, float e decimal");

// Representações:

// double com alias => 'double' => 'palavra-chave/tipo C#':
double valorD1 = 1.1234d;
Console.WriteLine(valorD1);
// Double com Tipo .NET => 'System.Double'
System.Double valorD2 = 1.1234d;
Console.WriteLine(valorD2);


// float com alias => 'float' => 'palavra-chave/tipo C#':
float valorF1 = 123.4F;
Console.WriteLine(valorF1);
// float com Tipo .NET => 'System.Single'
System.Single valorF2 = 123.4f;
Console.WriteLine(valorF2);


// decimal com alias => 'decimal' => 'palavra-chave/tipo C#':
decimal valorDC1 = 124.4M;
Console.WriteLine(valorDC1);
// decimal com Tipo .NET => 'System.Single'
System.Decimal valorDC2 = 124.4m;
Console.WriteLine(valorDC2);


Console.ReadLine();


Console.WriteLine("Comparando a precisão de float, double e decimal");

float x = 1f / 3f;
double y = 1d / 3d;
decimal z = 1m / 3m;

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);

Console.ReadLine();
