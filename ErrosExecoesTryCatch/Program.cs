/* Principais classes de exceções 
 * 
 * 
 * Exception()                 -  classe base de todas as exceções
 * NotImplementedException()   -  Um método não esta implementado
 * ArgumentException()         -  Um método não esta implementado 
 * NullReferenceException()    -  Indica uma referência nula
 * FormatException()           -  Formatação inválida
 * IndexOutOfRangeException()  -  Indice fora do intervalo
 * OverFlowException()         -  Excedeu a capacidade de processamento
 * FileNotFoundException()     -  Arquivo não localizado
 * InvalidCastException()      -  Não foi possível fazer a conversão
 * StackOverFlowException()    -  A capaciadade da pilha foi excedida
 * 
 */


/* Relançando exceções - throw e throw ex 
 * 
 * 
 * 1 - Relançando uma exceção usando apenas a instrução throw
 * 
 * Quando você lança apenas um throw está repassando a mesma exceção para frente e, dessa forma, outro trecho de codigo 
 * poderá capturar e saber o que vai fazer com a exceção original retendo todas as informações necessárias o stack trace.
 * 
 * 2 - Relançando uma exceção usando a instrução throw ex
 * 
 * Quando você lança um throw ex, você esta parando a exceção ali e após fazer alguma operação, e você lança outra exceção 
 * a partir dali. Dessa forma a informação de onde veio a exceção original é perdida. Tudo se passa como se tivesse ocorrido
 * uma nova exceção
 * 
 * 
 * Usar apenas throw mantém a hierarquia de exceções no rastreamento da pilha e fornece informações completas enquanto que usar
 * throw ex retorna as exceções até o ponto no qual o código throw ex foi executado, ai, os detalhes são removidos da exceção 
 * até este ponto.
 * 
 */


try
{
    A.ProcessarA();
}
catch (Exception ex)
{
    Console.WriteLine("\nTratando o erro em Main");
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}

Console.ReadKey();



class A
{
    public static void ProcessarA()
    {

        try
        {
            B.ProcessarB();
        }
        catch (Exception ex)
        {
            /* A exceção abaixo lança a exeção para o proximo nivel, mas a diferença e que ela lança os dados daqui
             * não da onde começou a exceção
                throw ex;
             */
            /* Exemplo de relançamento de exceção, que no caso vai lançar para quem o metodo que o chamou, sempre usar 
             * o lançamento throw para manter o rastreamento da pilha
             */
            throw;
            Console.WriteLine("\nTratando o erro em A");
        }

    }
}


class B
{
    public static void ProcessarB()
    {
        try
        {
            C.ProcessarC();
        }
        catch (Exception ex)
        {
            /* A exceção abaixo lança a exeção para o proximo nivel, mas a diferença e que ela lança os dados daqui
             * não da onde começou a exceção
                throw ex;
             */
            /* Exemplo de relançamento de exceção, que no caso vai lançar para quem o metodo que o chamou, sempre usar 
             * o lançamento throw para manter o rastreamento da pilha
             */
            throw;
            Console.WriteLine("\nTratando o erro em B");
        }
    }
}

class C
{
    public static void ProcessarC()
    {
        throw new NotImplementedException("Método não implementado");
    }
}