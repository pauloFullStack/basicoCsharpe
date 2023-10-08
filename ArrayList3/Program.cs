/* ArrayList - Remover elementos 
 * 
 * Podemos remover elementos de um 'ArrayList' usando os métodos
 * 
 * Remove(Object value) - Remove a primeira ocorrência de um objeto específico
 * 
 * RemoveAt(int index) - Remove o elemento no índice especificado
 * 
 * RemoveRange(int index, int count) - Remove um número definido de elementos a apartir de um índice
 * especificado
 * 
 */



using System.Collections;

var lista = new ArrayList() { "Ana", 5, true, "Teste", 1.1, "Zé", 3, 9, 0 };

foreach (var item in lista)
{
    Console.WriteLine(item);
}

lista.Remove("Teste");
lista.RemoveAt(4);
lista.RemoveRange(0, 2);

Console.WriteLine("-----------------");

foreach (var item in lista)
{
    Console.WriteLine(item);
}


/* ArrayList - Verificar se um elemento esta na coleção
 * 
 * Podemos usar o método Contains() para determinar se um elemento especificado existe na 'ArrayList' ou não.
 * O método retorna 'True' se existir caso contrário retorna 'False'
 */

Console.WriteLine("------------------");

var res1 = lista.Contains(3);
bool res2 = lista.Contains("Ana");

Console.WriteLine(res1);
Console.WriteLine(res2);
Console.WriteLine(lista.Contains(null));

Console.WriteLine("------------------");

/* Usando Sort() so deve ser usado com elementos do mesmo tipo */

var list = new ArrayList() { "Maria", "Ana", "Zilda", "Carlos", "Diná" };

foreach (var item in list)
{
    Console.WriteLine(item);
}

list.Sort();

Console.WriteLine();

foreach (var item in list)
{
    Console.WriteLine(item);
}

/* Limpando o arrayList */
list.Clear();

foreach (var item in list)
{
    Console.WriteLine(item);
}

Console.ReadKey();

/* ArrayList 
 * 
 * A classe 'ArrayList' foi projetada para conter coleções heterogêneas de objetos. No entanto,
 * nem sempre oferece o melhor desempenho
 */