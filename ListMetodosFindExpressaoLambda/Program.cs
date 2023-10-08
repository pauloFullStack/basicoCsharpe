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

/* Find() - Usando a expressão lambda  */
var fruta2 = frutas.Find(itemFruta => itemFruta.Contains('n'));
Console.WriteLine($"\nExpressão lambda Find() => {fruta2}");

/* FindIndex() - Usando a expressão lambda  */
var fruta4 = frutas.FindIndex(itemFruta => itemFruta.Contains('n'));
Console.WriteLine($"\nExpressão lambda FindIndex() => {fruta4}");

/* FindLast() - Usando a expressão lambda  */
var fruta3 = frutas.FindLast(itemFruta => itemFruta.Contains('n'));
Console.WriteLine($"\nExpressão lambda FindLast() => {fruta3}");

/* FindLastIndex() - Usando a expressão lambda  */
var fruta5 = frutas.FindLastIndex(itemFruta => itemFruta.Contains('n'));
Console.WriteLine($"\nExpressão lambda FindLastIndex() => {fruta5}");

/* FindAll() - Usando a expressão lambda  */
var fruta6 = frutas.FindAll(itemFruta => itemFruta.Contains('n'));


if (fruta6.Count > 0)
{
    int count = 0;
    foreach (var fruta in fruta6)
    {
        if (count == 0)
            Console.WriteLine();

        Console.WriteLine(fruta);

        count++;
    }
}
else
{
    Console.WriteLine("\n" + fruta6[0]);
}

Console.ReadLine();

static bool Procura(string item)
{
    return item.Contains('n');
}