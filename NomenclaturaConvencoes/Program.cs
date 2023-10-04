/* Identificadores 
 * 
 * Um identificador é o nome que você atribui a um tipo (classe, interface, struct, record, delegate ou enum), membro, propriedade, variável ou namespace
 * 
 * Utilizar nomes significativos que permitam inferir o propósito do identificador.
 * Ex: calculoDoImpostoICMS, valorTotalComDesconto, dataVencimentoFatura
 */


/* Regras gerais para identificadores válidos
 * 
 * - Devem começar com letra ou sublinhado (_)
 * - Não podem iniciar com um número ou caracteres especiais: #$@%&()!=+-*
 * - Não podem conter espaços
 * - Podem usar caracteres Unicode: pre\u00E7o (\u00E7 -> ç) (válido mas não recomendado)
 * - Não pode ser uma palavra-reservada da linguagem : if, int, double, string, class,
 * - Não pode exceder 512 caracteres
 */


/* Válidos
 * 
 * int idade; ou int idade1;
 * string _imposto;
 * float valorTotal;
 * decimal pre\u00E7o (decimal preço) -> não recomendado
 */


/* Inválidos
 * 
 * int 9idade;
 * string $imposto;
 * float valor total;
 * decimal class;
 */


/* Convenções
 * 
 * Camel Case - A primeira letra da primeira palavra é iniciada com minúscula. A letra de cada palavra seguinte deve ser iniciada com maiúscula. (Não deve haver espaços entre as palavras)
 * 
 * Ex: valorDoDesconto, nomeCompleto, valorDoImpostoSobreServico
 * Usado em nome de variáveis, parâmetros e campos internos privados
 * 
 * 
 * Pascal Case - A primeira letra de cada palavra é iniciada com maiúscula. (Não deve haver espaços entre as palavras)
 * 
 * Ex: CalculaImpostoDeRenda, ValorDoDesconto, NomeCompleto
 * Usado em nomes de classes, métodos, interfaces, propriedades
 * 
 * https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions
 * 
 * 
 * Constantes - Usar letras maiúsculas.
 * 
 * Ex: PI, DESCONTO, VALOR, IMPOSTO, PESSOA_FISICA
 * 
 * 
 * Sublinhados (_) - Usado para campos internos privados e somente leitura (camel case)
 * 
 * Ex: _valorTotal, _calculoImposto, _precoComDesconto
 * 
 */


/* Para nomes de variáveis: camel case */
string descontoTotal;

/* Constantes: maiúsculas */
double PI = 3.14d;
string PREFIXO = "34";
string PREFIXO_MG = "34";

/* Para nomes de classe e métodos: pascal case */
class ImprimirTexto
{
    public void ImprimeNome()
    {
        Console.WriteLine("Paulo");
    }
}