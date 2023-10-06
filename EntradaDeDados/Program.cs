/* Entrada de dados: métodos da classe Console */

/* ReadLine() lê uma única linha de entrada do fluxo de entrada padrão.
 * Retorna a mesma string */

/* Read() lê apenas um único caractere do fluxo de entrada padrão. 
 * Retorna o valor ASCII do caractere. */

/* ReadKey() lê apenas um único caractere do fluxo de entrada padrão.
 * Obtém a próxima tecla pressionada pelo usuário.
 * Retorna um tipo ConsoleKeyInfo.
 * É usado para segurar a tela até que o usuário pressione uma tecla. */

Console.WriteLine("\n ## Entrada de dados ## ");

Console.WriteLine("\n informe o seu nome");

string nome = Console.ReadLine();

Console.WriteLine("\n informe o sua idade");

int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nO seu nome é {nome} e vc tem {idade} anos");

Console.ReadLine();