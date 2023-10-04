Console.WriteLine("## Nullable Types ##\n");

/* 
 * Nullable Types ou Tipos Anuláveis
 * 
 * Um Nullable Type é um tipo de valor que pode receber um valor null
 * 
 * Os Nullable Types ou Tipos Anuláveis permitem atribuir um valor null a um tipo de valor
 * 
 * Nullable<T> <nome> = null; (T = int, double, float, bool, etc.)
 * Os Nullables Types suportam os valores do tipo mais o valor null
 * 
 * Ex: Nullable<bool> ativo = null; // Suporta true, false e null 
 * 
 */



/* Usando o tipo normal int eu não posso atribuir null em uma variavel do tipo 'int' */
int valor = 100;
Console.WriteLine(valor);

/* Usando Nullable eu consigo atribuir null a variavel do tipo 'int' e outras também */
Nullable<int> valor1 = null;
Nullable<double> valor2 = null;
Nullable<bool> valor3 = null;

Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);

/* Para simplificar a declaração podemos usar o operador '?' */
int? valor4 = null;
double? valor5 = null;
float? valor6 = null;
bool? valor7 = null;


/* Nullable Types são diferentes dos tipos por valor */

/* O Nullable Type int? é diferente do tipo int
 * int é um tipo não anulável ou Non-Nullable Type
 * int? é um Nullable Type
 * */


/*
 * Atribuir um Nullable Type a um tipo por valor usando operador '??'
 * 
 * Use o operador '??' para atribuir um tipo anulável a um tipo não anulável, ex:
 */

int? valor8 = null;
int valor9 = valor8 ?? 0;
Console.WriteLine(valor9);

/* O operador de coalescência nula ?? retorna o valor do operando esquerdo se ele não for null;
 * caso contrário, ele avalia o operando direito e retornará seu resultado. */

/* O operador ?? não avalia o operando do lado direito se o operando esquerdo for avaliado como não nulo */

int? x = 4;
int y = 3;
int z = (x ?? 0) * y;
/* ou */
int? w = x * y;

Console.WriteLine(z); ;
Console.WriteLine(w); ;


/* Propriedades somente leitura: HasValue e Value
 * São usadas para examinar e obter um valor de uma variável de Nullable Type 
 * 
 * HasValue: true se tiver um valor, false se não tiver um valor (null);
 * Value: Exibe o valor atribuído;
 */

int? b = 100;

if (b.HasValue)
{
    Console.WriteLine($"b = {b.Value}");
}
else
{
    Console.WriteLine("b não possui um valor");
}


Console.ReadKey();