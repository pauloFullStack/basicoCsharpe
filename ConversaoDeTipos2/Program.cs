/* Conversão para string usando método ToString() */

/* O método ToString() da classe Object retorna uma string que representa o objeto atual. 
 * Converter um objeto em sua representação de cadeia de caracteres para exibição.
 * Como Object é pai de todos os objetos na linguagem C# todos os objetos herdam o método ToString() da classe Object.
 */

int valorInt = 123;
double valorDouble = 12.45;
decimal valorDecimal = 12.45678m;

string s1 = valorInt.ToString();
string s2 = valorDouble.ToString();
string s3 = valorDecimal.ToString();

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);


/* Conversão de tipos usando a classe Convert() */

/* Fornece diversos métodos para converter um tipo de dados em outro tipo de dados */

/* 
 * Esta classe pertence ao namespace System
 * 
 * Convert.ToBoolean(variavel)  =  converte um tipo para um valor Boolean */
/* Convert.ToChar(variavel)  =     converte um tipo para o tipo char */
/* Convert.ToDouble(variavel)  =   converte um tipo para o tipo double */
/* Convert.ToInt16(variavel)  =    converte um tipo para o tipo 16-bit */
/* Convert.ToInt32(variavel)  =    converte um tipo para o tipo 32-bit */
/* Convert.ToString(variavel)  =   converte um tipo para uma string */

int valorInt1 = 123;
double valorDouble1 = 12.45;
bool valorBool = true;

Console.WriteLine(Convert.ToString(valorInt1));
Console.WriteLine(Convert.ToDouble(valorInt1));
Console.WriteLine(Convert.ToString(valorBool));
Console.WriteLine(Convert.ToInt32(valorDouble1));

/* Erro de conversão 'OverflowException' */
int varInt2 = 100000;
Console.WriteLine(Convert.ToByte(varInt2))
    
    ;
Console.ReadLine();