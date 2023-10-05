string nome = "Maria";
int idade = 25;

Console.WriteLine("----------- Concatenação -----------");

/* Usar a concatenação : usando o operador + */
Console.WriteLine(nome + " tem " + idade + " anos ");

Console.WriteLine("----------- Interpolação -----------");
/* Usa a interpolação de strings: $ -> a interpolação {} */
Console.WriteLine($"{nome} tem {idade} anos");

Console.WriteLine("----------- Place holders -----------");
/* Usar place holders : usa {} com numeração com inicio zero */
Console.WriteLine("{0} tem {1} anos", nome, idade);

Console.ReadLine();