/* Tratamento de exceção 
 * 
 * Uma exceção é um erro que ocorre em tempo de execução em um programa,
 * que viola uma condição que não foi especificada para acontecer durante
 * a operação normal
 * 
 * Se o programa não fornecer o código para tratar uma exceção, o sitema
 * vai parar a execução do programa com uma mensagem de erro. (lançar uma exceção).
 *
 * Desta forma as exceções que podem ocorrer em um aplicativo devem ser tratadas
 * para evitar travamentos e resultados inesperados e continuar a execução do código
 * quando isso for possível.
 * 
 * Para lidar com exceçõesa a linguagem C# fornece o suporte interno através do uso do bloco:
 * try-catch.
 * 
 * A instrução try-catch consiste em um bloco try seguido por uma ou mais cláusulas catch, que
 * especificam manipuladores para diferentes exceções.
 * 
 * bloco finally - Podemos usar também um bloco finally que sempre será executado e que é usado
 * para liberar recursos usados no programa ou realizar outra tarefa.
 *
 *
 * Propriedade da exceção(Exception)
 * 
 * Uma exceção contém diversas propriedades somente leitura que mostram informações sobre a
 * exceção que causou o erro. Abaixo temos as principais:
 * 
 * Message        - tipo string    - contém uma mensagem de erro explicando a causa da exceção.
 * StackTrace     - tipo string    - contém a informação que descreve aonde a exceção ocorreu.
 * InnerException - tipo exception - se a exceção foi lançada por outra exceção, esta propriedade
 * contém a referência da antiga exceção
 *
 */



Console.WriteLine("## Divisão de números inteiros ##");
Console.WriteLine("x/y");

Console.WriteLine("\nInforme o valor de x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nInforme o valor de y");
int y = Convert.ToInt32(Console.ReadLine());


try
{
    int z = x / y;
    Console.WriteLine($"\n{x} / {y} = {z}");
}
catch (Exception ex)
{
    Console.WriteLine($"\n Erro: <<< {ex.Message} >>>");
    Console.WriteLine($"\n Detalhes: <<< {ex.StackTrace} >>>");
}
finally
{
    Console.WriteLine("\nProcessamento concluído...");
}

Console.ReadLine();