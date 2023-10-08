/* ArrayList - Adicionar elementos 
 * 
 * O método 'Add' permite incluir um único elemento ao final de uma 'ArrayList'
 * 
 * O método 'Insert(int index, Object value) permite incluir um elemento em uma posição
 * qualquer usando um índice específico
 */

using System.Collections;

var lista = new ArrayList() { "Maria", 5, true };

Console.WriteLine("Array original");
foreach (var item in lista)
{
    Console.WriteLine(item);
}

/* Adiciona um elemento no final do array */
lista.Add(3.5);
/* Atualiza a posição 2 do array para o nome 'Paulo' */
lista.Insert(2, "Paulo");

Console.WriteLine("\nArray depois das alterações");
foreach (var item in lista)
{
    Console.WriteLine(item);
}

/* ArrayList - Adicionar coleção de elementos 
 * 
 * Podemos adicionar uma coleção de elementos a um ArrayList usando os métodos
 * 
 * AddRange(ICollection) - Adiciona a coleção de elementos ao final da ArrayList
 * 
 * InsertRange(int index, ICollection) - Adiciona a coleção de elementos na ArrayList na posição
 * do índice especificado
 */

var list = new ArrayList() { "Maria", 5, true };

Console.WriteLine();

foreach (var item in list)
{
    Console.WriteLine(item);
}

int[] array1 = { 1, 2, 3 };
/* Adiciona o array1 no final do da lista de array */
list.AddRange(array1);
/* Adiciona o array1 no indice especificado */
list.InsertRange(2, array1);

Console.WriteLine();


foreach (var item in list)
{
    Console.WriteLine(item);
}



Console.ReadLine();