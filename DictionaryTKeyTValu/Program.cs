/* Dictionary<TKey,TValue> - Definição 
 * 
 * 
 * A classe 'Dictionary' representa uma coleção do tipo chave/valor e implementar a interface IDictionary(e outras interfaces)
 * que possui duas coleções no seu interior uma para guardar a chave e outra para guardar o valor.
 * 
 * Esta classe esta definida no namespace 'System.Collections.Generic' sendo uma classe genérica e pode armazenar qualquer 
 * tipo de dados no formato chave e valor, onde cada chave deve ser exclusiva na coleção.
 * 
 * A classe Dictionary é fortemente tipada e assim não precisa converter de objetos genéricos em tipos específicos e também
 * garante que seu código trate os tipos corretos de objetos.
 * 
 * Um Dictionary<TKey, TValue> requer uma implementação de igualdade para determinar se as chaves são iguais
 * 
 * Podemos especificar uma implementação da interface genérica IEqualityComparer<T> usando um construtor que aceita um 
 * parâmetro de comparação.
 * 
 * Se você não especificar uma implementação, o comparador de igualdade genérico padrão EqualityComparer<T>.Defautl será usado
 * 
 */


/* Dictionary<TKey, TValue> - Sintaxe 
 * 
 * 
 * Podemos criar um objeto Dictionary<TKey, TValue> definindo o tipo de objeto para a chave(TKey) e para o valor(TValue) que ele
 * pode armazenar e usando o operador new
 * 
 * Dictionary<string, int> dict1 = new Dictionary<string, int>();
 * Dictionary<string, int> dict2 = new Dictionary<string, int>(5);
 * 
 * O objeto Dictionary pode ser atribuído a uma variável do tipo IDictionary<TKey, TValue> ou à classe Dictionary<TKey, TValue>
 * 
 * IDictionary<int,string> dict1 = new Dictionary<int,string>();
 * Dictionary<int, string> dict2 = new Dictionary<int, string>(5);
 * 
 * Cada chave em um Dictionary<TKey,TValue> deve ser exclusiva de acordo com o comparador de igualdade do dicionário.
 * 
 * Uma chave não pode ser null, mas um valor pode ser, se seu tipo TValue for um tipo de referência.
 */


/* Dictionary<TKey, TValue> Principais Propriedades 
 * 
 * 
 * Count      =  Obtém o número total de elementos no Dictionary<TKey, TValue>
 * IsReadOnly =  Retorna um booleano indicando se o Dictionary<TKey, TValue> é somente leitura.
 * Item       =  Obtém ou define o elemento com a chave especificada do Dictionary<TKey,TValue>
 * Keys       =  Retorna a coleção de chaves do Dictionary<TKey,TValue>
 * Values     =  Retorna a coleção de valores no Dictionary<TKey, TValue>
 * Comparer   =  Obtém o IEqualityComparer<T> que é usado para determinar a igualdade de chaves para o dicionário
 */


/* Dictionary<TKey, TValue> Principais Métodos 
 * 
 * 
 * Add(TKey, TValue)          =  Adiciona a chave e o valor ao Dictionary<TKey, TValue>. Lança uma exceção ArgumentException se a chave
 * já existir
 * 
 * TryAdd(TKey, TValue)       =  Tenta adicionar um elemento com chave e valor definidos e retorna true ou false.
 * 
 * Clear()                    =  Remove todas as chaves e valores do Dictionary<TKey,TValue>
 * 
 * ContainsKey(Tkey)          =  Determina se o Dictionary<TKey, TValue> atual contém a chave especificada
 * 
 * ContainsValue(TValue)      =  Determina se o Dictionary<TKey, TValue> atual contém o valor especificado
 * 
 * Remove(Tkey)               =  Remove o valor com a chave especificada do Dictionary<TKey, TValue>
 * 
 * TryGetValue(Tkey, TValue)  =  Obtém o valor associado à chave especificada. Se a chave não existir retorna o valor padrão para o tipo 
 * do parâmetro TValue
 * 
 */

/* Forma 1 de declarar um Dictionary */
Dictionary<int, int> dic1 = new Dictionary<int, int>();
/* Forma 2 de declarar um Dictionary 
 * 
 * Forma 1 de atribuir valores ao Dictionary
 */
var dic2 = new Dictionary<int, int>();
dic2.Add(2, 100);
dic2.Add(3, 300);
dic2.Add(4, 400);

/* Forma 3 de declarar um Dictionary */
var dic3 = new Dictionary<int, int>()
{
    {1, 100},
    {2, 200},
    {3, 300},
};


Console.WriteLine("\n-Incluir elemento com chave (3) duplicada");

try
{
    dic3.Add(3, 300);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.ToString());
}


Console.WriteLine("\n-Usando o método TryAdd para a chave 3");
var resultado = dic3.TryAdd(3, 332);
Console.WriteLine($"Elemento foi incluido ? {resultado} ");



Console.WriteLine("\n-Incluindo o elemento com chave 7 e valor 7000");
if (!dic3.ContainsKey(7))
{
    dic3.Add(7, 7000);
    Console.WriteLine(dic3[7]);
}


Console.WriteLine("\n-Usando ContainsValue");
if (dic3.ContainsValue(7000))
{
    Console.WriteLine("\nO valor existe no Dicionário");

}


Console.WriteLine("\n-Alterando o valor do elemento com chave 7");
if (dic3.ContainsKey(7))
{
    dic3[7] = 7777;
    Console.WriteLine($"Valor alterado do item {dic3[7]}");
}



try
{
    Console.WriteLine(dic3[5]);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.ToString());
}



Console.WriteLine("\n-Usando TryGetValue() para a chave 5");
if (dic3.TryGetValue(7, out int valor))
{
    Console.WriteLine($"Valor para a chave 7 = {valor}");
}
else
{
    Console.WriteLine("Chave não encontrada");
}

dic3.Add(6, 6666);
dic3.Add(4, 4444);


Console.WriteLine("\n-Percorrendo o dicionário e exibindo os itens (foreach)");
foreach (var item in dic3)
    Console.WriteLine($"{item.Key} {item.Value}");



Console.WriteLine("\n-Ordenando os elementos do dicionário(LINQ)");
var dic3OrdenadoLinq = dic3.OrderBy(x => x.Key);
foreach (var item in dic3OrdenadoLinq)
    Console.WriteLine($"{item.Key} {item.Value}");



Console.WriteLine("\n-Ordenando os elementos do dicionário(SortedDictionary)");
var dic3Ordenado = new SortedDictionary<int, int>(dic3);
foreach (var item in dic3Ordenado)
    Console.WriteLine($"{item.Key} {item.Value}");



Console.ReadKey();


//public static Dictionary<string, List<string>> GetErrors(ModelStateDictionary modelState)
//{
//    Dictionary<string, List<string>> errors = new Dictionary<string, List<string>>();

//    if (!modelState.IsValid)
//    {
//        errors = modelState
//            .Where(x => x.Value.Errors.Any())
//            .ToDictionary(
//                kvp => kvp.Key,
//                kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToList()
//            );
//    }

//    return errors;
//}