/* Classe Math */

/* Possui constantes e diversos métodos estáticos usados para cálculos matemáticos */

/* Método ou Constante 
 * 
 * Math.PI  ->  representa o número PI                    ->    PI = 3.141516171819...
 * Math.E   ->  representa a base e do logaritmo natural  ->    E = 2.7182818284590457
 * Cos(x)   ->  Obtém o cosseno de x                      ->    Cos(2.0) = -0.4161...
 * Sin(x)   ->  Obtém o seno de x                         ->    Sin(2) = 0.909297... 
 * Tan(x)   ->  Obtém a tangente de x                     ->    Tan(1.5) = 14.1014...
 * Sqrt(x)  ->  Calcula a raiz quadrada de x              ->    Sqrt(169) = 13
 * Pow(x,y) ->  Obtém o valor de x elevado a y            ->    Pow(2,4) = 16
 * Abs(x)   ->  Fornece o valor absoluto de x             ->    Abs(-4.5) = 4.5
 * Max(x,y) ->  Obtém o maior valor entre dois números    ->    Max(2.46,2.56) = 2.56
 * Min(x,y) ->  Obtém o menor valor entre dois números    ->    Min(1.92,1.89) = 1.89
 * Log10(x) ->  Calcula o logaritmo de x na base 10       ->    Log10(3.0) = 0.47712...
 * Log(x)   ->  Calcula o logaritmo de x na base e        ->    Log(3.0) = 1.098612...
 * Exp(x)   ->  Retorna o exponencial (e elevado a x)     ->    Exp(5.0) = 54.59...  
 * 
 */


Console.WriteLine("## Operadores Aritméticos ##\n");

Console.WriteLine("Informe o valor de x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Soma de x+y = {x + y}");
Console.WriteLine($"Soma de x-y = {x - y}");
Console.WriteLine($"Soma de x*y = {x * y}");
double divisao = (double)x / y;
Console.WriteLine($"Soma de x/y = {divisao}");
Console.WriteLine($"Soma de x%y = {x % y}");

Console.WriteLine("\n----------------------\n");

Console.WriteLine($"Raiz quadrada de x = {Math.Sqrt(x)}\n");
Console.WriteLine($"Potência de x elevado a y = {Math.Pow(x, y)}\n");
Console.WriteLine($"Valor mínimo entre x e y = {Math.Min(x, y)}\n");
Console.WriteLine($"Valor máximo entre x e y = {Math.Max(x, y)}\n");
Console.WriteLine($"Coseno de x = {Math.Cos(x)}\n");
Console.WriteLine($"Seno de x = {Math.Sin(x)}\n");
Console.WriteLine($"Exponencial de x = {Math.Exp(x)}\n");


Console.ReadKey();