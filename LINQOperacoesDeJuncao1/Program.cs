/* LINQ - Operações de Junção 
 * 
 * As operações de junção são usadas para buscar dados de duas ou mais fontes de dados com base em algumas propriedades comuns presentes
 * nestas fontes
 * 
 * Operadores usados nas operações de junção:
 * 
 * Join - É usado para unir duas fontes de dados ou coleções com base na propriedade comum e retornar os dados como um único conjunto de
 * resultados
 * 
 * GroupJoin - É usado para unir duas fontes de dados ou coleções com base em uma chave ou propriedade comum, mas retorna o resultado 
 * como um grupo de sequências.
 * 
 * Podemos realizar diferentes tipos de junções como: Inner Join, Right Join, Left Join, Full Join e Cross Join na Linq
 * 
 */


/* LINQ - Operador JOIN 
 * 
 * Uma cláusula join recebe duas sequências de origem como entrada. Os elementos em cada sequência devem ser ou conter uma propriedade
 * que possa ser comparada com uma propriedade correspondente na outra sequência.
 * 
 * A cláusula join compara a igualdade das chaves especificadas, usando a palavra-chave equals.
 * 
 * Todas as junções realizadas pela cláusula join são junções por igualdade.
 * 
 * A forma da saída de uma cláusula join depende do tipo de junção que estamos realizando. (inner, left, right, etc)
 * 
 */


/* LINQ - Inner Join 
 * 
 * Uma inner join ou junção interna produz um conjunto de resultados no qual cada elemento da primeira coleção aparece uma vez cada 
 * elemento corresponde na segunda coleção. Se um elemento na primeira coleção não tiver nenhum elemento corresponde na segunda coleção,
 * ele não aparecerá no conjunto de resultados
 * 
 * A junção interna retorna apenas os registros ou linhas que correspondem ou existem em ambas as coleções/sequências.
 * 
 */


