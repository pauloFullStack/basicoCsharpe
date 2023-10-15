/* SortedDictionary<TKey,TValue> - Definição 
 * 
 * 
 * É uma coleção genérica que armazena dados no formato chave/valor de forma ordenada onde a 
 * ordenação é feita pela chave.
 * 
 * As chaves da coleção SortedDictionary devem ser exclusivas e não nulas e manter a ordem  crescente sendo usadas
 * para realizar pesquisas e remover elementos da coleção
 * 
 * Devido a sua natureza dinâmica o tamanho de uma SorteDictionary aumenta automaticamente à medida que adicionamos
 * pares chave/valor à coleção.
 * 
 * A classe SortedDictionary<TKey,TValue> usa uma árvore binária para manter os itens ordem pela chave
 * 
 * Com isso o tipo usado para a chave deve implementar a interface 'IComparable<TKey> de modo que as chaves possam ser
 * corretamente ordenadas.
 * 
 */


/* SortedDictionary<TKey,TValue> - Sintaxe 
 * 
 * 
 * Podemos criar um objeto SorteDictionary<TKey,TValue> definindo o tipo de objeto para a chave(TKey) e para a valor
 * (TValue) que ele pode armazenar e usando o operador new.
 * 
 * SortedDictionary<int, string> sortdict1 = new SortedDictionary<int,string>();
 * var sortdict1 = new SortedDictionary<int, string>();
 * 
 * 
 */



/* SortedDictionary É IGUAL Dictionary<TKey, TValue> A UNICA DIFERENÇA É QUE ELE TRAZ OS DADOS ORDENADOS */