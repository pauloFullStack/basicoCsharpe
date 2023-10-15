/* Expressão lambda - Conceito 
 * 
 * 
 * Uma expressão lambda é uma função anônima que pode ser usada para criar delegates ou expressões de árvores de expressão.
 * 
 * Uma expressão lambda é uma maneira mais curta de representar um método anônimo usando uma sintaxe especial(sugar syntax)
 * 
 * São usadas para escrever métodos in-line simples e rápidos, sem precisar criar um método nomeado separado
 * 
 */


/* Expressões lambdas - Sintaxe 
 * 
 * 
 * São compostas por uma lista de parâmetros separados por vírgulas, seguida pelo operador lambda => (que pode ser lido como 
 * 'ir para') e pelo corpo da expressão .
 * 
 * (parâmetros de entrada) => {expressão ou bloco de instrução};
 * 
 * O lado esquerdo do operador lambda(=>) especifica os parâmetros de entrada (se houver) e o direito contém a expressão ou o 
 * bloco de instruções que serão avaliados ou executados
 * 
 */


/* A expressão lambda possui uma sintaxe mais curta e mais fácil de ler, na expressão lambda o compilador infere o tipo de 
 * parâmetro e o tipo de retorno com base no contexto
 */

List<string> nomes = new List<string>();
nomes.Add("Maria");
nomes.Add("Miriam");
nomes.Add("Paulo");
nomes.Add("Cintia");


string resultado = nomes.Find(nome => nome.Equals("Paulo"));
Console.WriteLine(resultado);

Console.ReadKey();