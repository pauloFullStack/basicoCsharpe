/* Coleções somente leitura 
 * 
 * 
 * São estruturas de dados que permitem que os dados sejam acessados, mas não modificados.
 * Estão presentes no namespace System.Collections.ObjectModel
 * 
 * ReadOnlyCollection<T>
 * - Fornece a classe base para uma coleção somente leitura genérica.
 * - É criada a partir de uma coleção mutável(Array, List)
 * 
 * ReadOnlyDictionary<TKey,TValue>
 * - Representa uma coleção somente leitura genérica de pares chave/valor.
 * - Ela é criada a partir de um dicionário mutável
 * 
 * Construtor, ex:
 * public ReadOnlyCollection(System.Collections.Generic.IList<T> list);
 * 
 * Propriedades:
 * Count   -  Obtém o n de elementos na instância da coleção somente leitura
 * Item[]  -  Obtém um elmento no índice especificado
 * Items   -  Retorna a IList<T> que a coleção envolve(protected)
 * 
 * Métodos:
 * Contains(T item)                   -  Determina se um elemento esta na coleção
 * CopyTo(T[] array, int arrayIndex)  -  Copia os elementos da coleção para um Array unidimensional compatível, começando no
 * índice especificado do array de destino.
 * GetEnumerator()                    -  Retorna um enumerador que itera pela coleção
 * IndexOf(T item)                    -  Pesquisa o objeto especificado e retorna o índice baseado em zero da primeira ocorrência
 * em toda a coleção
 * - Este método executa uma pesquisa linear; portanto, esse método é uma operação O(n)
 * - Determina a igualdade usando o comparador padrão EqualityComparer<T>. Default.
 * 
 */


using ReadOnlyCollectionT;
using System.Collections.ObjectModel;

var planets = new List<string>()
{
    "Mecúrio", "Vênus", "Terra", "Marte"
};

var listPlanetsReadOnly = new ReadOnlyCollection<string>(planets);

/* Outra forma de criar uma lista somente leitura */
//var newListPlanetsReadOnly = planets.AsReadOnly();  

ListPlanets(listPlanetsReadOnly);

/* Pegando a quantidade de items da lista */
Console.WriteLine("\nTamnho da lista : {0}", listPlanetsReadOnly.Count);
/* Verifiando se existe uma valor na lista */
Console.WriteLine("Júpiter esta na coleção? {0} ", listPlanetsReadOnly.Contains("Marte") ? "Sim" : "Não");
/* Pegando um valor pelo indice */
Console.WriteLine($"\nPlaneta de indice 3 : {listPlanetsReadOnly[3]}");
/* Pegando o indice da lista pelo comparação do valor que existe na lista */
Console.WriteLine($"\nIndice do planeta Terra : {listPlanetsReadOnly.IndexOf("Terra")}");
/* Inserir um valor na lista original para refletir na lista somente leitura */
Console.WriteLine("\nInserindo um novo elemento na lista original (índice 4)");
/* Metodo Insert permite setar o valor do indice manualmente */
planets.Insert(4, "Plutão");

Console.WriteLine("\n\nCopiando os elementos da coleção para um Array unidimensional");
string[] planetasArray = new string[listPlanetsReadOnly.Count + 2];
listPlanetsReadOnly.CopyTo(planetasArray, 1);
Console.WriteLine($"\nO array copiado possui {planetasArray.Length} elementos ");

foreach (string planeta in planetasArray)
    Console.WriteLine($"\"{planeta}\"");

Console.WriteLine("--------------------------------------------");


/* Quando os itens somente de leitura forem de um tipo complexo(uma classe, objeto) eu posso alterar o valor */
var exoPlanetas = new ReadOnlyCollection<ExoPlaneta>(ExoPlaneta.GetExoPlanetas());

/* Exemplo alterando valor de colleticon somente leitura */
exoPlanetas[0].Nome = "Kepler-442b";

Console.WriteLine("\nLista de exoplanetas: \n");
foreach (var item in exoPlanetas)
    Console.WriteLine(item.Nome);

Console.ReadKey();

static void ListPlanets(ReadOnlyCollection<string> listPlanetsReadOnly)
{
    foreach (var planet in listPlanetsReadOnly)
    {
        Console.WriteLine($"{planet}");
    }
}