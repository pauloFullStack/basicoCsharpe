/* Acessando os elementos de um Array usando um laço for 
 * 
 * Podemos usar um 'laço for' para percorrer elementos de um array.
 * 
 * Usamos a propriedade 'Length' da classe 'Array' para definir o 'tamanho do Array' 
 * no laço 'for'
 * 
 * A classe 'Array' esta no namespace 'System' e fornece diversas propriedades e
 * métodos para trabalhar com um 'array'. (Length, Rank, Copy, Clear, Sort, etc.)
 */

int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Elemento de indice {i} : {numeros[i]}");
}

string[] nomes = { "Paulo", "Renato", "Alves", "Silva" };

for (int i = 0; i < nomes.Length; i++)
{
    if (i == 0)
        Console.WriteLine($"\n\nElemento de indice {i} : {nomes[i]}");
    else
        Console.WriteLine($"Elemento de indice {i} : {nomes[i]}");

}

Console.ReadLine();