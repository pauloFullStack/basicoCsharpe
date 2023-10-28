/* LINQ - Sintaxe de método 
 * 
 * 
 * Vantagens:
 * - A sintaxe de consulta é convertida automaticamente para a sintaxe de método no momento da compilação
 * - Nem todos os métodos LINQ podem ser utilizados com sintaxe de consulta
 * - A sintaxe de método é estilisticamente mais semelhante ao código C#
 * 
 */


/* LINQ - Expressão lambda 
 * 
 * 
 * Uma expressão lambda é um método anônimo que você pode usar para criar delegates ou tipos de árvore de expressão
 * 
 * Usando expressões lambda, você pode gravar métodos locais que podem ser passados como argumentos ou serem retornados
 * como o valor de chamadas de método
 * 
 */


/* LINQ - Consultas 
 * 
 * 
 * Os métodos LINQ que retornam IEnumerable<T> têm um conceito de execução lenta(também chamada de adiada ou lazy execution)
 * 
 * Todos os métodos genéricos LINQ, podem inferir implicitamente argumentos de tipo, portanto, não precisamos especificá-los
 * na maioria dos casos
 * 
 * A maioria dos métodos LINQ aceita delegates Func<> e Predicate<>, e, a opção mais comum para fornecer um delegate é escrever
 * uma expressão lambda
 * 
 * Ao trabalhar com a interface IQueryable<T>, a consulta é compilada(por exemplo, em SQL) e executada remotamente. 
 */


/* LINQ - Filtrar dados 
 * 
 * 
 * São usados para filtrar dados de uma lista/coleção com base nas condições do filtro.
 * Where - é usado para selecionar valores da lista com base em funções de predicado
 * Ex: fonte_dados.Where(<expressão_lambda>) -- fonte_dados.Where(Func<T,bool> predicate)
 */