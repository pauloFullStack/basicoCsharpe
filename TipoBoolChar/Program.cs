/*
 * - São tipos de valor armazenados na stack
 * - O tipo bool pode ser obtido como resultado operações comparação e de igualdade
 * - O valor padrão do tipo bool é false
 * - O valor padrao do tipo char é '\0' (U+0000) -representação unicode para NULL
*/

Console.WriteLine("Atribuindo valores para bool e char");


bool ativoB1 = true;
Console.WriteLine(ativoB1);
System.Boolean ativoB2 = true;
Console.WriteLine(ativoB2);

Console.WriteLine(10 == 15);

 
char letraC1 = 'A';
Console.WriteLine(letraC1);
// Char entede caracter unicode também, para o tipo cha entender o codigo unicode deve-se colocar '\u' no inicio do codigo unicode => '\uCODIGO'
// Represetando char com o formato unicode
System.Char letraC2 = '\u0030';
Console.WriteLine(letraC2);

