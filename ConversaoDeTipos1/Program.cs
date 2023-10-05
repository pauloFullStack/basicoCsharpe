/* Conversão entre os tipos */

/* A linguagem C# é estaticamente tipada em termo de compilação 
 * Após uma variável ser declarada ela não pode ser declarada novamente
 * Nem pode ser usada para armazenar valores de outro tipo de dados 
 * A menos que este tipo de dados seja convertível para o tipo de dados da variável */


Console.WriteLine("## Conversão de tipos ##\n");

/* Nesse exemplo abaixo, esta acontecendo uma conversão implícita,
 * double converte para int, isso so é possivel porque int tem 4 bytes e double 8 bytes
 * assim double consegue converte para int, o contrario não teria como
 */

/* 
 * byte -> 1 byte
 * short -> 2 bytes 
 * int -> 4 bytes
 * long -> 8 bytes
 * float -> 4 bytes
 * double -> 8 bytes
 * decimal -> 16 bytes
 */


/* Tipos de conversão entre tipos de dados */

/* Conversão Implícita 
 * 
 * O compilador C# converte automaticamente um tipo de dados em outro tipo, 
 * (Quando a conversão entre os tipos for compatível)
 */

/* Conversão implicita para int, abaixo: */
int varInt = 2145678;
long varLong = varInt;
float varFloat = varInt;
double varDouble = varInt;
decimal varDecimal = varInt;

Console.WriteLine(varLong);
Console.WriteLine(varFloat);
Console.WriteLine(varDouble);
Console.WriteLine(varDecimal);



/* Conversão Explícita 
 * 
 * A conversão tem que ser feita manualmente de forma explícita
 */


double varDoubleExplicita = 12.456;         /* 8 bytes */
/* usando um cast para forçar a conversãso */
int varIntExplicita = (int)varDoubleExplicita;   /* 4 bytes */
Console.WriteLine(varIntExplicita);

int num1 = 10;
int num2 = 4;
/* usando cast para converter int para float */
float resultado = (float)num1 / num2;
Console.WriteLine(resultado);

Console.ReadLine();