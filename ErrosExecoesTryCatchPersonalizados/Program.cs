/* Exceções personalizadas - Conceito 
 * 
 * 
 * Podemos criar uma classe de exceção personalizada derivando da classe System.Exception
 * 
 * - A recomendação é finalizar o nome da exceção criada com a palavra 'Exception'
 * - Implementar os três construtores comuns
 */


using ErrosExecoesTryCatchPersonalizados;

try
{

    Conta conta1 = new Conta(1320, "Maria", 100m);
    Console.WriteLine(conta1.ToString());
    conta1.Depositar(100);
    Console.WriteLine($"Saldo : {conta1.Saldo}");
    conta1.Sacar(300);
    Console.WriteLine($"Saldo : {conta1.Saldo}");

}
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}


/* Exceções personalizadas  - Recomendações 
 * 
 * 
 * Crie uma classe de exceção separada para cada condição de erro que deseja manipular. Isso torna mais fácil identificar e
 * lidar com exceções específicas em seu código.
 * 
 * Substitua a propriedade Message para fornecer uma mensagem de erro significativa que descreva a condição de erro. Esta
 * mensagem será exibida quando a exceção for lançada.
 * 
 * Substitua o método ToString() para retornar uma representação de string da exceção, que pode ser útil para fins de log
 * e depuração.
 * 
 * Adicione propriedades ou métodos adicionais necessários à sua classe de exceção personalizada para fornecer mais informações
 * sobre a condição de erro.
 * 
 */

Console.ReadKey();