/* List<T> - Find(), FinLast(), FindIndex(), FindLastIndex(), FindAll() 
 * 
 * O método Find retorna o primeiro elemento que corresponde ao 'predicado' fornecido.
 * 
 * O método FindLast retorna o último elemento que corresponde ao predicado fornecido.
 * 
 * O método FindIndex retorna o índice do primeiro elemento que corresponde ao predicado
 * fornecido. Ele retorna -1 se não houver correspondência encontrada.
 * 
 * O método FindLastIndex retorna o índice do último elemento que corresponde ao predicado
 * fornecido. Ele retorna -1 se não houver correspondência encontrada.
 * 
 * O método FindAll recupera todos os elementos que correspondem às condições definidas
 * pelo predicado especificado.
 * 
 * Um predicado é uma função/método de argumento único que retorna um valor booleano.
 */


/* List<T> - Find() 
 * 
 * Sintaxe: public T? Find(Predicate<T> match)
 * 
 * Predicado é uma função que a partir de uma expressão retorna verdadeiro ou falso conforme
 * a lógica da expressão definida na função
 * 
 * Uma expressão lambda é uma função anônima
 * 
 * Para criar uma expressão lambda,devemos especificar:
 * - os parâmetros de entrada no lado esquerdo do 'operador lambda' (=>)
 * - e definir a expressão ou o bloco de instruções do lado direito do operador lambda.
 * Ex: x => x * x;
 */

List<string> frutas = new List<string>()
{
    "Uva", "Banana", "Pera", "Maça", "Abacate", "Laranja", "Morango"
};

/* usando o predicado comom uma função */
var fruta1 = frutas.Find(Procura);

Console.WriteLine($"\nPredicado => {fruta1}");

/* Usando a expressão lambda */
var fruta2 = frutas.Find(itemFruta => itemFruta.Contains('n'));

Console.WriteLine($"\nExpressão lambda => {fruta2}");



Console.ReadLine();

static bool Procura(string item)
{
    return item.Contains('n');
}