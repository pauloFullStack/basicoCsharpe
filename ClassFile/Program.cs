/* Tratamento de Arquivos e Diretórios 
 * 
 * 
 * A linguagem C# fornece as diversas classe para trabalhar com  sistema de arquivos:
 * File, FileInfo, Directory, DirectoryInfo, Path, FileStream, StreamReader, StreamWriter
 * 
 * Elas podem ser usadas para acessar arquivos, diretórios, abrir arquivos para leitura ou gravação, criar um novo
 * arquivo ou mover arquivos existentes de um local para outro dentre outros recursos
 * 
 * 
 * File  
 * 
 * Esta no namespace System.IO e é usada para realizar operações de leitura e gravação de arquivos
 * Fornece métodos estáticos para criar, copiar, excluir, mover e abrir arquivos e também fornece métodos
 * para trabalhar com diretórios, como criar, excluir e mover diretórios.
 * 
 * 
 * File - Métodos
 * 
 * Métodos  para criação e manipulação de arquivos:
 * - Create: Cria umm novo arquivo vazio ou sobrescreve um arquivo existente.
 * - Delete: Exclui um arquivo
 * - Exists: Verifica se um arquivo existe
 * - Copy: Copia um arquivo existente para um novo arquivo. Não sobrescreve arquivo de mesmo nome.
 * - Move: Move um arquivo para um novo local permitindo fornecer um novo nome
 * 
 * Métodos para leitura e escrita de arquivos:
 * - ReadAllText: Abre o arquivo, lê todo o contéudo de um arquivo de texto e retorna uma string e fecha.
 * - ReadAllBytes: Lê todo o conteúdo de um arquivo binário e retorna um array de bytes.
 * - WriteAllText:; Cria um novo arquivo e grava uma string em um arquivo de texto e fecha o arquivo
 * - WriteAllBytes: Grava um array de bytes em um arquivo binário.
 * - AppendAllText: Abre o arquivo, anexa uma string e fecha o arquivo(se não existir cria o arquivo)
 * 
 * Outros métodos úteis:
 * - ReadAllLines: Lê as linhas do arquivo
 * - GetLastWriteTime: Retorna a data e hora da última vez que o arquivo foi modificado
 * - GetLastAccessTime: Retorna a data e hora do último acesso ao arquivo
 * 
 */


/* Arquivos: caminho e nome 
 * 
 * 
 * Para criar um arquivo é preciso especificar o caminho e o nome do arquivo que será criado.
 * 
 * string caminho = @"C:\MeusArquivos\arquivo.txt";
 * Usa uma string verbatim, que é indicada pelo símbolo @ no início da string.
 * 
 * var caminho = "C\\MeusArquivos\\arquivo.txt";
 * Duplica a barra invertida para que ela não seja considerada um caractere de scape
 * 
 */


/* Arquivos - Exceções do tipo  IOException (I/O) 
 * 
 * 
 * A exceção IOException é uma classe base para exceções que ocorrem durante operações de entrada e saída(I/O) em arquivos
 * ou stream(fluxo de bytes/sequencia de dados)
 * 
 * Principais variações da exceção IOException:
 * - DirectoryNotFoundException: O caminho para um diretório não pode ser encontrado ou não existe
 * - EndOfStreamException: O final do fluxo é alcançado prematuramente
 * - FileNotFoundException: Um arquivo não pode ser encontrado
 * - PathTooLongException: Um caminho ou nome de arquivo excede o comprimento máximo permitido pelo sistema operacional
 * - UnauthorizedException: Acesso não autorizado ao arquivo
 * 
 */
string caminhoOrigem = @"C:\dados\arquivo1.txt";
string caminhoDestino = @"C:\dados\txt\arquivo1.txt";
if (!File.Exists(caminhoDestino))
{


    try
    {


        // Criar arquivo, Create cria o arquivo e deixa aberto
        // File.Create(caminhoOrigem);
        File.WriteAllText(caminhoOrigem, "Paulo Renato \r\nAlves da Silva\r\n");

        string novoTexto = $"O poeta é um fingidor {Environment.NewLine}Finge tão completamente \r\nQue chega a fingir que é dor \r\nA dor que deveras sente.\r\n";

        File.AppendAllText(caminhoOrigem, novoTexto);

        /* Ler o conteúdo do arquivo */
        Console.WriteLine("\nContéudo e informações do arquivo : ");
        string conteudo = File.ReadAllText(caminhoOrigem);
        Console.WriteLine(conteudo);

        /* Obtendo o ultima modificação do arquivo */
        Console.WriteLine($"Última modificação feita em : {File.GetLastWriteTime(caminhoOrigem)}");

        /* Obtendo o ultimmo acesso do arquivo */
        Console.WriteLine($"Última acesso feito em : {File.GetLastAccessTime(caminhoOrigem)}");

        /* Colocando as linhas do arquivo em um array */
        string[] linhas = File.ReadAllLines(caminhoOrigem);
        foreach (var linha in linhas)
            Console.WriteLine($"{linha} -- ");

        /* Copiar arquivo */
        var caminhoCopia = @"C:\dados\arquivo1_copia.txt";
        Console.WriteLine($"\nCopiando de {caminhoOrigem} para {caminhoCopia}");
        File.Copy(caminhoOrigem, caminhoCopia);

        /* Mover arquivo */
        Console.WriteLine($"\nMovendo {caminhoOrigem} para {caminhoDestino}");
        File.Move(caminhoOrigem, caminhoDestino);

        /* Excluir */
        Console.WriteLine($"\nExcluindo {caminhoOrigem} , {caminhoDestino} e {caminhoCopia} ");
        File.Delete(caminhoOrigem);
        //File.Delete(caminhoDestino);
        File.Delete(caminhoCopia);



    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
Console.WriteLine("Concluido!");

Console.ReadKey();