
/* Não podemos iterar o tipo Task pois ele não contém uma definição para GetEnumerator 
 * 
 * Podemos usar streams assíncronos para criar IEnumerables que geram dados de forma assíncrona
 * 
 * 1-O método deve ser assíncrono(async/await)
 * 2-O tipo de retorno do método deve ser um IAsyncEnumerable<T>
 * 3-O corpo do método deve conter pelo menos uma chamada a yield return
 * 
 */

internal class Program
{
    static async Task Main(string[] args)
    {
        await foreach (var mes in GeraMeses())
            Console.WriteLine(mes);

        Console.ReadKey();
    }

    private async static IAsyncEnumerable<string> GeraMeses()
    {
        yield return "Janeiro";
        yield return "Fevereiro";
        await Task.Delay(2000);
        yield return "Março";
        yield return "Abril";
    }
}