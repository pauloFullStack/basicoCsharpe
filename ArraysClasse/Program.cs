/* Apresentando a Classe Array 
 * 
 * Fornece métodos para criar, manipular, pesquisar e classificar arrays, servindo assim como
 * a classe base para os arrays
 * 
 * 1- Reverse - Inverte a seqüência de um array unidimensional
 * Ex: Array.Reverse(nome_array);
 * 
 * 2- Sort - Ordena os itens de um array
 * Ex: Array.Sort(nome_array);
 * 
 * 3- BinarySearch - Faz a busca em um array ordenado de um valor usando o algoritmo de 
 * busca binário. Se for encontrado será retornado o valor do índice do elemento, caso
 * contrário será retornado um número negativo.
 * Ex: Array.BinarySearch(nome_array, objeto);
 * 
 */


using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] nomes = { "Ana", "Maria", "Dinair", "Paulo", "Carlos", "Beatriz" };

        Console.WriteLine("\n\nExibindo o array original...");
        ExibirArray(nomes);

        Console.WriteLine("\n\nExibindo o array inverso...");
        Array.Reverse(nomes);
        ExibirArray(nomes);

        Console.WriteLine("\n\nOrdenando o array...");
        Array.Sort(nomes);
        ExibirArray(nomes);

        Console.WriteLine("\n\nLocalizando um item no array...");
        Console.WriteLine("Informe o nome");
        string nome = Console.ReadLine();

        var indice = Array.BinarySearch(nomes, nome);

        if (indice >= 0)
            Console.WriteLine($"\n{nome} foi encontrado com indice = {indice}");
        else
            Console.WriteLine($"\n{nome} não foi encontrado");

        /* Usando o modificador 'params' no parametro do metodo Somar, eu posso passar os valores do array
         * Direto, so colocando virgula entre os números, e devem ser do tipo declarado no parametro 
         * do metodo Somar()
         * */
        Soma("tste", 3, 3, 3, 1);

        Console.ReadKey();

    }

    private static void ExibirArray(string[] nomes)
    {
        int count = 0;
        foreach (var nome in nomes)
        {
            if (count == 0)
                Console.WriteLine($"\n{nome}");
            else
                Console.WriteLine($"{nome}");

            count++;
        }
    }

    /* Usando modificador params, quando usado o 'params' não se pode mais declarar nenhum parametro,
     * caso deseja usar mais parametros deve-se deixar o parametro que usa 'params' por ultimo... */
    private static void Soma(string teste, params int[] numeros)
    {
        int total = 0;
        foreach (var numero in numeros) total += numero;

        Console.WriteLine($"Total da soma = {total}");
    }

}