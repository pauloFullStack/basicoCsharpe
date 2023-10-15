/* HashSet<T> e SortedSet<T>
 * 
 * 
 * Uma coleção que contém apenas itens distintos é conhecida pelo conjunto de termos ou Set.
 * 
 * 1 - HashSet<T> contém um lista não ordenada de itens distintos;
 * 2 - SortedSet<T> contém uma lista ordenada de itens distintos;
 * 
 * São dois conjuntos ou sets definidos como coleções genéricas usadas para armazenar e manipular conjuntos de dados
 * não duplicados e estão presentes no namespace System.Collection.Generics
 * 
 * Em termos de desempenho, HashSet<T> geralmente é mais rápido que SortedSet<T> para operações como adicionar e remover
 * elementos, mas SortedSet<T> é mais rápido para operações que dependem da ordem dos elementos, como localizar o primeiro
 * ou o último elemento.
 * 
 */


/* HashSet<T> - Definição
 * 
 * HashSet<T> é uma coleção genérica não ordenada que implementa a interface ISet<T> e representa um conjuto de itens exclusivos
 * (não permite a inclusão de elementos duplicados)
 * 
 * Usa uma função hash para determinar a posição de um item na coleção, o que permite acesso rápido aos elementos.
 * 
 * Não garante nenhuma ordem dos elementos, e a ordem dos elementos na coleção pode mudar quando os elementos são adicionados ou
 * removidos.
 * 
 * A interface ISet<T> oferece métodos para criar uma união de múltiplos conjuntos, para criar uma interseção de conjuntos, ou para
 * fornecer informações se um conjunto for um superconjunto ou subconjunto de outro
 * 
 * HashSet<T> é uma coleção que fornece acesso rápido a elementos sem garantia de ordem e adequado para cenários onde a ordem dos
 * elementos não é importante
 * 
 */