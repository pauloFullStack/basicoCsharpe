/* Métodos de extensão : Conceito 
 * 
 * 
 * Permitem estender a funcionalidade de um tipo existente sem criar um novo tipo derivado, 
 * recompilar ou modificar o tipo original
 * 
 * São um tipo especial de método estático chamado como se fosse um método de instância no tipo
 * estendido
 * 
 * Eles são úteis para estender a funcionalidade de tipos existentes, como classes da biblioteca 
 * padrão ou classes por outras bibliotecas de terceiros
 * 
 */


/* Métodos de extensão : roteiro 
 * 
 * 
 * - Crie uma classe estática para conter o método de extensão. Esta classe deve estar visível o 
 * código cliente.
 * 
 * - Implemente o método de extensão como um método estático com pelo menos a mesma visibilidade da
 * classe que o contém;
 * 
 * - O primeiro parâmetro do método especifica o tipo no qual o método opera. Ele deve ser precedido
 * pelo modificador this
 * 
 * - No código de chamada, adicione uma diretiva using para especificar o namespace que contém a classe
 * do método de extensão.
 * 
 * - Chame os métodos como se fossem métodos de instância no tipo.
 * 
 */

using MetodosDeExtensao;

string texto = "Paulo Renato";

string textoInvertido = texto.InverteString();

Console.WriteLine(textoInvertido);

Console.ReadKey();
