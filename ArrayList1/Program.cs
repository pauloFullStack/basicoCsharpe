/* ArrayList - Definição 
 * 
 * Um 'ArrayList' é uma coleção não genérica cujo tamanho pode ser alterado dinamicamente e
 * que armazena elementos de vários tipos de dados
 * 
 * Esta coleção é uma alternativa a 'Array' e também pode ser indexada individualmente e 
 * permite alocação dinâmica de memória, inclusão, pesquisa e classificação de elementos
 * na coleção
 * 
 * O tamanho de um 'ArrayList' aumenta de forma dinâmica à medida que novos elementos são
 * adicionados, e, os elementos possuem um índice que começa o valor 0 incrementando de 1 em 1
 * 
 */


/* ArrayList - Construtores 
 * 
 * A classe 'ArrayList' esta no 'namespace System.Collections' possui 3 construtores usados para
 * criar uma 'ArrayList':
 * 
 * ArrayList() -> É usado para criar uma instância da classe 'ArrayList' que está vazia e sem 
 * 'capacidade' inicial. (Capacity e Count)
 * 
 * ArrayList(Int32) -> É usado para criar uma instância da classe 'ArrayList' que está vazia e tem 
 * a 'capacidade' inicial especificada.
 * 
 * ArrayList(ICollection) -> É usado para criar uma lista de array inicializada com os elementos da
 * coleção especificada e tendo a mesma capacidade inicial que é copiada da coleção.
 * 
 */


/* ArrayList - Declaração, instanciação e inclusão de elementos
 *
 * Para criar um 'ArrayList' podemos usar a palavra-chave new e a seguir usar o método 'Add'
 * para incluir elementos ou podemos usar os inicializadores de objetos (object initializer) para
 * criar um 'ArrayList' em uma única etapa
 * Ex: ArrayList lista; lista = new ArrayList();
 * Mais formas de declarar ArrayList:
 * 
 * ArrayList lista = new ArrayList();
 * var lista = new ArrayList();
 * ArrayList lista = new();
 * 
 * Informando a capacidade (opcional)
 * 
 * ArrayList lista = new ArrayList(5);
 * var lista = new ArrayList(5);
 * ArrayList lista = new(5);
 * 
 * A 'ArrayList' permite incluir elementos de diferentes tipo de dados
 */

/* Exemplos declarando ArrayList */

using System.Collections;

/* Ex1 */
ArrayList lista;
lista = new ArrayList();

/* Ex1 */
ArrayList lista1 = new ArrayList();
/* Ex2 */
var lista2 = new ArrayList();
/* Ex3 */
ArrayList lista3 = new();

/* Declarando um ArrayList com capacidade OPCIONAL */

/* Ex4 */
ArrayList lista4 = new ArrayList(5);
/* Ex5 */
var lista5 = new ArrayList(5);
/* Ex6 */
ArrayList lista6 = new(5);


/* Declarando e usando ArrayList */

ArrayList lista7 = new ArrayList();

lista7.Add("Paulo");
lista7.Add(4.5);
lista7.Add(5);
lista7.Add(true);
lista7.Add("");
lista7.Add(null);


foreach (var item in lista7)
{
    Console.WriteLine(item);
}



var lista8 = new ArrayList() { "Renato", 10.5, 8 };

foreach (var item in lista8)
{
    Console.WriteLine(item);
}

Console.ReadLine();