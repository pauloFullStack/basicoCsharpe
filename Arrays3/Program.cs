/* Acessando os elementos de um array usando um laço foreach 
 * 
 * Podemos usar um laço 'foreach' para ler e recuperar elementos de um 'Array'
 * sem precisar usar índice nem definir o tamanho do array
 * 
 * A instrução 'foreach' permite executar uma instrução ou um bloco de instruções
 * para cada elemento presente em uma coleção (Array, List, ArrayList, Stack, Queue, etc)
 * 
 * Na declaração do 'foreach', entre parênteses criamos um elemento do tipo utilizado na
 * coleção e, com o operador 'in', informamos a coleção a ser percorrida
 * 
 */



int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

foreach (var numero in numeros)
{
    Console.WriteLine($"{numero}");
}

string[] nomes = { "Paulo", "Renato", "Alves", "Silva" };

int count = 0;
foreach (var nome in nomes)
{
    if (count == 0)
        Console.WriteLine($"\n\n{nome}");
    else
        Console.WriteLine($"{nome}");
    count++;
}

Console.ReadLine();