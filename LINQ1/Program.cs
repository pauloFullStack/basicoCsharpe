/* LINQ - Language Integrated Query 
 * 
 * 
 * Language-Integrated Query(LINQ) é um conjunto de tecnologias baseadas na integração de recursos de consulta
 * diretamente na linguagem C#
 * 
 * Permite escrever consultas em coleções fortemente tipadas usando palavras-chave da linguagem C#, operadores
 * familiares e com o suporte ao IntelliSense
 * 
 * Fornece uma sintaxe de consulta baseada na linguagem de consulta padrão do SQL e uma experiência de consulta consistente
 * para objetos, bancos de dados relacionais, XML e diversas fontes de dados
 * 
 * Para começar a usar a LINQU, basta importar o namespace System.Linq no seu código.
 * 
 */


/* LINQ - Recursos do C# que dão suporte a LINQ 
 * 
 * 
 * Expressões de consulta - A LINQ usa uma sintaxe declarativa semelhante ao SQL para consultar em coleções IEnumerable.
 * 
 * Métodos de Extensão - Os operadores de consulta padrão da LINQ são um conjunto de métodos de extensão que fornecem a
 * funcionalidade de consulta para qualquer tipo que implementa IEnumerable<T>
 * 
 * Expressões Lambda - Na LINQ, usamos expressões lambda ao fazer chamadas de métodos diretas aos operadores de consulta
 * padrão
 * 
 * Tipos Anônimos - Permitem criar objetos que contêm um conjunto de propriedades, sem a necessidade de definir uma classe
 * explicitamente. Isso ajuda a simplificar o código
 * 
 * Variáveis tipadas implicitamente - Usa o modificador 'var' para instruir o compilador a inferir e atribuir o tipo 
 * 
 * Inicializadores de objeto e coleção - Permite inicializar objetos sem chamar explicitamente um construtor para o objeto
 * São usados em expressões de consulta quando projetam os dados de origem em um novo tipo de dados.
 * 
 */


/* LINQ - Principais recursos oferecidos 
 * 
 * 
 * Consultas integradas à linguagem: permite escrever consultas de dados diretamente no código usando uma sintaxe declarativa, que
 * é semelhante ao SQL. Isso torna a consulta de dados muito mais fácil e intuitiva.
 * 
 * Intellisense - fornece sugestões de código enquanto o desenvolvedor está digitando, o que torna o processo de escrita de código
 * muito mais eficiente.
 * 
 * Tipagem forte - a linguagem C# é tipada fortemente, o que significa que os tipos de dados são verificados em tempo de compilação.
 * Isso ajuda a evitar erros e melhora a confiabilidade do código.
 * 
 * Suporte a vários tipos de dados - a LINQ oferece suporte a vários tipos de dados, incluindo listas, arrays, dicionários e conjuntos.
 * 
 * Operadores de consultas padrão - a LINQ inclui um conjunto de operadores de consulta padrão, como Where, Select, GroupBy, OrderBy e Join
 * que são usados para filtrar, projetar, agrupar e ordenar dados.
 * 
 * Consultas em tempo de execução - as consultas LINQ são executadas em tempo de execução, o que significa que os resultados podem ser
 * processados e modificados conforme necessário.
 * 
 * Suporte a bancos de dados - a LINQ pode ser usada para consultar bancos de dados, incluindo o SQL Server, o Oracle, o MySQL, etc...,
 * permitindo escrever consultas de banco de dados na linguagem C#
 * 
 * 
 * LINQ - Retorna objetos
 * 
 * 
 * As consultas LINQ retornam resultados como objetos
 * 
 * Permite usar uma abordagem orientada a objetos no conjunto de resultados sem se preocupar em transformar diferentes formatos de resultados
 * em objetos.
 * 
 */


/* LINQ - Esquema das consultas 
 * 
 * 
 * 1 - Definir a fonte de dados
 * 2 - Definir a consulta LINQ
 * 3 - Executar a consulta
 * 
 * 
 * LINQ - Vantagens
 * - Fornece uma sintaxe de consulta comum para consultar diferentes fontes de dados.
 * - Utiliza menos código em comparação com a abordagem tradicional de consulta
 * - Fornece verificação de erros em tempo de compilação, bem como suporte de inteligência no Visual Studio evitando erros em tempo de execução
 * - Fornece muitos métodos embutidos que podemos usar para realizar diferentes operações, como filtragem, ordenação, agrupamento, etc
 * - Permite a reutilização de consultas
 */


/* LINQ - API 
 * 
 * 
 * As consultas LINQ usam métodos de extensão para classes que implementam a interface IEnumerable ou IQueryable
 * 
 */


/* LINQ - Sintaxe das consultas 
 * 
 * 
 * 1 - Query Syntax ou Query Expression Syntax(Sintaxe de Consulta)
 * 
 * A sintaxe de consulta é escrita usando uma sintaxe semelhante ao SQL, com palavras-chave como select, from, where,
 * group by, order by, etc
 * 
 * 2 - Method Syntax ou Fluent Syntax(Sintaxe de método)
 * 
 * A sintaxe de método é escrita usando métodos de extensão definidos nas interfaces IEnumerable e IQueryable.
 * 
 */


/* Execução adiada(deferred execution) significa que a avaliação de uma expressão é postergada até que seu valor 
 * realizado seja realmente necessário(foreach, Count, Sum, ToList(), etc..)
 */


/* Operadores de consulta padrão : System.Linq.Enumerable e Queryable 
 * 
 * Filtro           =  Where, OfType
 * Ordenãção        =  OrderBy, OrderByDescending, ThenBy, ThenByDescending, Reverse
 * Agrupamento      =  GroupBy, ToLookup
 * Junção           =  GroupJoin, Join
 * Projeção         =  Select, SelectMany
 * Agregação        =  Aggregate, Average, Count, LongCount, Max, Min, Sum
 * Quantifiers      =  All, Any, Contains
 * Elementos        =  ElementAt, ElementAtOrDefault, First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault
 * Set              =  Distinct, Except, Intersect, Union
 * Particionamento  =  Skip, SkipWhile, Take, TakeWhile
 * Concatenação     =  Concat
 * Equality         =  SequeneEqual
 * Geração          =  DefaultEmpty, Empty, Range, Repeat
 * Conversão        =  AsEnumerable, AsQueryable, Cast, ToArray, ToDictionary, ToList
 * 
 */


/* IEnumerable<T> e List<T>
 * 
 * 
 * IEnumerable<T> é uma interface que define um contrato para uma coleção de objetos que pode ser enumerada sequencialmente mas
 * não pode ser alterada
 * 
 * List<T> é uma implementação concreta de uma coleção de objetos que é armazenada em memória e pode ser acessada e modificada de
 * forma eficiente podendo ser alterada e ordenada
 * 
 * Se você precisa de uma coleção que pode ser percorrida sequencialmente e que pode ser implementada por varios tipos de coleções
 * use IEnumerable<T>.
 * 
 * Se você precisa de uma coleção que pode ser acessada e modificada eficientemente, use List<T>
 */


/* IEnumerable<T> - Convertendo para List e Array 
 * 
 * A LINQ fornece dois métodos para converter um IEnumerable<T>
 * 1 - ToList() converte um IEnumerable<T> para um List<T>
 * 2 - ToArray() converte um IEnumerable<T> para um Array<T>
 * 
 */

List<string> nomes = new List<string>()
{
    "Ana", "Maria", "Pedro", "Lair", "Hugo"
};


/* Query Syntax ou Sintaxe de Consulta */
/* Sintaxe de consulta */
var resultado = from m in nomes where m.Contains('o') select m;
LoopTestes(resultado);

/* Method Syntax ou Sintaxe de Método */
/* Sintaxe de método */
var resultado1 = nomes.Where(m => m.Contains('M'));

/* Convertendo para array */
//var resultado1 = nomes.Where(m => m.Contains('M')).ToArray();
/* Convertendo para lista */
//var resultado1 = nomes.Where(m => m.Contains('M')).ToList();

LoopTestes(resultado1);


Console.ReadKey();

static void LoopTestes<T>(IEnumerable<T> items)
{
    Console.WriteLine();
    foreach (var item in items) Console.WriteLine(item);

}