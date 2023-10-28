await ExecutaOperacaoAsync();

Console.ReadKey();

static async ValueTask ExecutaOperacaoAsync()
{
    /* Criar um CancellationTokenSource */
    int tempo = 10;
    var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(tempo));

    Console.WriteLine("\nIniciando o download...");
    Console.WriteLine($"\nCancelando a operação após {tempo} segundos...");

    try
    {
        using (var httpClient = new HttpClient())
        {
            string destino = "C:\\dados\\arquivo.txt";
            string linkDownload = "https://www.macoratti.net/dados/Poesia.txt";
            var response = await httpClient.GetAsync(linkDownload, HttpCompletionOption.ResponseHeadersRead, cancellationTokenSource.Token);

            var totalBytes = response.Content.Headers.ContentLength;
            var readBytes = 0L;

            await using var fileStream = new FileStream(destino, FileMode.Create, FileAccess.Write);

            await using var contentStream = await response.Content.ReadAsStreamAsync(cancellationTokenSource.Token);

            // Buffer aqui no caso é quantidade de dados que ele vai processar em cada loop abaixo, isso é definido no 3 argumento passado 'buffer.Length', ele ira processar de 150 e 150 bytes, se o arquivo tem 328bytes ele vai dar 3 votas no loop
            var buffer = new byte[150];
            int bytesRead;

            while ((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length, cancellationTokenSource.Token)) > 0)
            {
                await fileStream.WriteAsync(buffer, 0, bytesRead, cancellationTokenSource.Token);
                readBytes += bytesRead;
                Console.WriteLine($"Progresso: {readBytes}/{totalBytes}");
            }

        }
    }
    catch (OperationCanceledException ex)
    {
        if (cancellationTokenSource.IsCancellationRequested)
            Console.WriteLine($"\nDownload cancelado por tempo limiete {ex.Message}");
        else
            Console.WriteLine($"\nO tempo limite para o download foi atingido.");

    }
    catch (HttpRequestException ex)
    {
        Console.WriteLine($"\nOcorreu um erro de rede: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nErro: {ex.Message}");
    }
    finally
    {
        Console.WriteLine("Download Finalizado...");
    }
}