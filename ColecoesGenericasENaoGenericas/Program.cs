/* Coleções não Genéricas 
 * 
 * 
 * As coleções não genéricas estão presentes no namespace System.Collections e armazenam os elementos
 * em arrays de objetos permitindo que eles contenham qualquer tipo de dados, são eles os principais:
 * - ArrayList, HashTable, SortedList, Stack, Queue
 * 
 * Principais características
 * 
 * As classes das coleções não genéricas armazenam dados do tipo 'Object'.
 * 
 * Fazem a conversão implícita dos tipos de dados para 'Object'.
 * 
 * Realizam as operações de 'boxing' ao incluir e 'unboxing' ao retirar um elemento da coleção 
 * 
 * São mais suscetíveis a exceções em tempo de execução devido a incompatibilidade entre tipos
 * 
 */


/* Coleções Genéricas
 * 
 * 
 * As coleções genéricas foram introduzidas na versão 2.0 da linguagem C# e estão presentes no namespace
 * System.Collections.Generic sendo coleções fortemente tipadas, são elas as principais:
 * - Dictionary<TKey, TVale>, SortedDictionary<TKey, TValue>, SortedList<TKey, TValue>, LinkedList<T>,
 * HashSet<T>, SortedSet<T>, Stack<T>, Queue<T>, List<T>
 * 
 * Principais Vantagens
 * 
 * São fortemente tipadas(armazenam apenas um tipo de objeto) evitando erros de incompatibilidade de tipo
 * 
 * Não realizam as operações de boxing e unboxing oferecendo um melhor desempenho
 * 
 * Facilitam a reutilização de código
 */


/* Coleções Genéricas X Não Genéricas 
 * 
 * 
 * As classes das coleções não genéricas são consideradas 'absoletas' pelos desenvolvedores e pela própria Microsoft.
 * 
 * A recomendação é sempre favorecer o uso das coleções genéricas, e apenas usar as coleções não genéricas 
 * quando você está lidando com o legado .NET.
 * 
 * 
 * Coleções não genéricas e sua correspondente genérica:
 * 
 * ArrayList - Coleção dinâmica e contígua de objetos. - Preferir a coleção List<T>
 * 
 * HashTable - Coleção de pares chave-valor não ordenada. - Prefira a coleção Dictionary<TKey, TValue>
 * 
 * Queue - Coleção de objetos First-in-first-out(FIFO). - Prefiar a coleção Queue<T>
 * 
 * SortedList - Coleção de pares chave-valor ordenados. - Prefira a coleção SortedList<T>
 * 
 * Stack - Coleção de objetos Last-in-first-out(LIFO) - Prefira a coleção Stack<T>
 * 
 */