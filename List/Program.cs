/* É A MESMA COISA DO ARRAYLIST,USA OS MESMO METODOS 
 * 
 * List<T> Apresenta os mesmos métodos e comportamentos da ArrayList
 * 
 * Inclusão de itens: Add(T) e Insert(int index, T value)
 * 
 * Inclusão de coleções: AddRange(ICollection) e InsertRange(int index, ICollection)
 * 
 * Acesso aos elementos usando o índice: lista[indice];
 * 
 * Iterar na lista: laço for(Count) e laço foreach
 * 
 * Verificar se um elemento esta na lista: Contains(T)
 * 
 * Remoção de itens: Remove(T value), RemoveAt(int index) e RemoveRange(int index, int count)
 * 
 * Ordenação da lista e remoção de todos os elementos da lista: Sort() e Clear()
 * 
 */


/* List<T> - Definição 
 * 
 * A coleção 'List<T>' é uma coleção de objetos fortemente tipados que podem ser acessados usando
 * um índice que inicia em zero, e possui métodos para classificar, pesquisar, modificar e 
 * manipular listas.
 * 
 * Esta coleção é a versão genérica da coleção 'ArrayList', sendo equivalente a ela, e esta presente
 * no namespace System.Collections.Generic
 * 
 * A classe List<T> pode ser usada para criar uma coleção de tipos diferentes, onde T representa 
 * o tipo do objeto que pode ser inteiro, string, double, etc., e também pode ser um tipo complexo
 * como uma classe definida pelo usuário.
 * 
 */


/* List<T> - Características
 * 
 * Uma List<T> pode conter elementos do tipo especificado por T, fornece verificação de tipo em tempo
 * de compilação e não executa boxing-unboxing porque é genérica.
 * 
 * Os elementos podem ser adicionados a uma List<T> usando os métodos Add(), AddRange(), Insert(), e
 * InserRange() ou usando a sintaxe de inicializador de coleção.
 * 
 * Uma List<T> é uma estrutura dinâmica que pode ser redimensionado
 * 
 * Uma List<T> inicia vazia e seus elementos são alocados sob demanda
 * 
 * Uma List<T> como Arrays e ArrayList são 'tipos de referência': uma variável refere-se ao objeto real,
 * que deve ser instanciado na memória 'Heap'.
 * 
 */


/* List<T> - Declaração, instanciação e inclusão de elementos
 * 
 * Para criar uma List<T> temos que especificar o 'parâmetro de tipo' T para definir o tipo dos elementos 
 * que desejamos armazenar, usar a palavra-chave 'new' e a seguir podemos usar o método 'Add' para incluir
 * elementos ou podemos os inicializadores de coleção para criar uma List<T> em uma única etapa
 * 
 */

/* Exemplos Inicialização */

List<string> listaString = new List<string>();

listaString.Add("Paulo");
listaString.Add("Maria");

foreach (var str in listaString)
{
    Console.WriteLine(str);
}

List<int> listaInt = new List<int>()
{
    1,2,3
};
List<double> listaDouble = new List<double>();

