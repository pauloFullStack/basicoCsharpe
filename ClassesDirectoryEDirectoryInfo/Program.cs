/* Directory e DirectoryInfo 
 * 
 * As classes Directory e DirectoryInfo são usadas para manipular diretórios em C# e ambas permitem a criação, 
 * exclusão, cópia, movimentação e renomeação de diretórios.
 * 
 * A classe Directory é uma classe estática que fornece métodos estáticos para trabalhar com diretórios.
 * 
 * A classe DirectoryInfo é uma classe não estática que representa um diretório em uma instância de objeto
 * 
 * A classe Directory é uma opção mais fácil de usar para operações simples envolvendo diretórios, enquanto a classe
 * DirectoryInfo é mais poderosa e flexível para operações mais complexas.
 */


/* Directory 
 * 
 * CreateDirectory - Cria todos os diretórios especificados pelo caminho
 * Delete - Exclui um diretório especificado e, opcionalmente, quaisquer subdiretórios.
 * Exists - Determina se o caminho fornecido se refere a um diretório existente no disco.
 * GetCurrentDirectory - Retorna o diretório atual da aplicação
 * GetDirectories - Retorna os nomes dos subdiretorios  que atendem aos critérios especificados.
 * GetFiles - Retorna os nomes dos arquivos que atendem aos critérios especificados.
 * GetCreationTime - Obtém a data e hora de criação de um diretório.
 * GetParent - Recupera o diretório pai do caminho especificado, incluindo caminhos absolutos e relativos.
 * Move - Move ou copia um arquivo ou diretório para um novo local(origem, destino)
 * 
 * Exceções Possíveis: UnauthorizeAccessException, ArgumentException, PathTooLongException, DirectoryNotFoundException, NotSupportedException, SecurityException
 */

var caminhoDiretorio = @"C:\dados\";

Console.WriteLine("\nCriando um novo diretório");

try
{

    if (Directory.Exists(caminhoDiretorio))
    {
        /* Obtendo todos os arquivos em um diretorio */
        Console.WriteLine("Arquivos");
        string[] arquivos = Directory.GetFiles(caminhoDiretorio);
        foreach (var arquivo in arquivos)
            Console.WriteLine(arquivo);

        Console.WriteLine("\nPasta");
        /* Obtendo todos as pastas em um diretorio que comece com a letra 'p'*/
        string[] subdiretorios = Directory.GetDirectories(caminhoDiretorio, "p*");
        foreach (var subdir in subdiretorios)
            Console.WriteLine(subdir);

        /* Cria diretorio 
         * Directory.CreateDirectory(caminhoDiretorio);
         */

        /* Deleta diretorio 
         * Directory.Delete(caminhoDiretorio);
         */
    }
    else
    {
        Console.WriteLine($"O Diretorio {caminhoDiretorio} já existe!");
    }

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadKey();