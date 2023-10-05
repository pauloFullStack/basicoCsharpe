/* Formatação usando sequencias Escapes */

/* As sequências de escape são combinações de caracteres consistindo 
 * de uma barra invertida (\) seguida por uma letra ou por uma combinação de dígitos.
 */

/* Sequência Escape
 * 
 * \a = Sinal sonoro (alerta)
 * \b = Backspace
 * \f = Alimentação de formulário
 * \n = Nova linha
 * \r = Carriage return
 * \t = Tabulação horizontal
 * \v = Tabulação vertical
 * \' = Aspas simples
 * \" = Aspas duplas
 * \\ = Barra invertida
 * \? = Interrogação
 * \u ooo = Caractere ASCII na notação unicode
 * \x hh = Caractere ASCII na notação hexadecimal
 * 
 * */

Console.WriteLine("Saida de dados : Usando sequencia de escapes\n");

string local = "C:\\dados\\poesias.txt";
Console.WriteLine(local);

string frase = "Ele falou: \"Não fui eu\"";
Console.WriteLine(frase);

string pizza = "\nPizza\nde\nMussarela";
Console.WriteLine(pizza);

string bolo = "\nBolo\tde\tChocolate";
Console.WriteLine(bolo);

string bolo1 = "\aBolo\ade\aChocolate";
Console.WriteLine(bolo1);

string bolo2 = "\bBolo\bde\bChocolate";
Console.WriteLine(bolo2);

string bolo3 = "\fBolo\fde\fChocolate";
Console.WriteLine(bolo3);

string bolo4 = "\rBolo\rde\rChocolate";
Console.WriteLine(bolo4);

string bolo5 = "\tBolo\tde\tChocolate";
Console.WriteLine(bolo5);

string bolo6 = "\vBolo\vde\vChocolate";
Console.WriteLine(bolo6);

string bolo7 = "\'Bolo\'de\'Chocolate";
Console.WriteLine(bolo7);

string bolo8 = "\"Bolo\"de\"Chocolate";
Console.WriteLine(bolo8);

string bolo9 = "\\Bolo\\tde\\tChocolate";
Console.WriteLine(bolo9);


Console.ReadLine();