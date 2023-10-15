/* Exception Filters ou Filtros de exceção 
 * 
 * 
 * O recurso Exception Filters foi introduzido na versão 6.0 do C# e permite executar blocos try/catch com base em uma
 * condição especifica quando ocorre uma exceção.
 * 
 * Isso significa que em um bloco try/catch, com vários blocos catch, podemos decidir qual bloco catch deverá ser executado
 * segundo um critério pré-definido, especificando uma condição no bloco catch.
 * 
 * Um bloco catch será executado somente quando a condição for verdadeira. Se a condição for falsa, o bloco catch é ignorado
 * e o compilador procura o próximo manipulador catch.
 * 
 * Podemos implementar este recurso adicioando a condição when junto com os blocos catch.
 * 
 */


try
{
    Console.WriteLine("\nInforme o dividendo");
    int dividendo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\nInforme o divisor");
    int divisor = Convert.ToInt32(Console.ReadLine());
    int resultado = (dividendo / divisor);
    Console.WriteLine($"\n{dividendo} / {divisor} = {resultado}");
}
/* No caso dos filtros abaixos, ele não captura a exceção primeiro mas sim a execeção 'when' primeiro */
catch (DivideByZeroException) when (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
{
    Console.WriteLine("\nErro filtro 1");
}
catch (Exception ex) when (ex.Message.Contains("format"))
{
    Console.WriteLine("~\nErro filtro 2");
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}


Console.WriteLine("\n------------ Exercio ---------------\n");


try
{
    Console.WriteLine("Acessando o arquivo poesia.txt em https://macoratti.net/dados\n");
    Console.WriteLine("Informe o nome do arquivo");
    string? arquivo = Console.ReadLine();
    Console.WriteLine("Informe o url do site");
    string? url = Console.ReadLine();
    Console.WriteLine("\nAguarde...");


    HttpClient client = new HttpClient();
    HttpResponseMessage response = client.GetAsync(url + "/" + arquivo).Result;

    if (response.IsSuccessStatusCode)
    {
        Console.WriteLine("Acesso ao arquivo feito com sucesso");
        Console.WriteLine($"Código de status: {response.StatusCode}");

    }
    else
    {
        throw new HttpRequestException($"Erro : {(int)response.StatusCode}");
    }

}
catch (HttpRequestException ex) when (ex.Message.Contains("404"))
{
    Console.WriteLine("Página não encontrada");
}
catch (HttpRequestException ex) when (ex.Message.Contains("401"))
{
    Console.WriteLine("Acesso não autorizado");
}
catch (HttpRequestException ex) when (ex.Message.Contains("400"))
{
    Console.WriteLine("Requisição invalida");
}
catch (HttpRequestException ex) when (ex.Message.Contains("500"))
{
    Console.WriteLine("Erro interno do servidor");
}
catch (Exception ex)
{
    Console.WriteLine("Erro: " + ex.Message);
}
finally
{
    Console.WriteLine("Processamento concluido");
}


Console.ReadKey();