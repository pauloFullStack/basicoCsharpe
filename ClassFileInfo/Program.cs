/* FileInfo
 * 
 * 
 * Existe no namespace System.IO sendo usada para obter informações detalhadas sobre um arquivo específico, como tamanho, nome
 * data de criação, data de modificação, etc
 * 
 * Permite também realizar operações em um arquivo específico, como abrir, copiar, mover e excluir um arquivo.
 * 
 * Requer uma instancia da classe para realizar as operações.
 * 
 * Quando as propriedades são recuperadas pela primeira vez, FileInfo chama o método Refresh e armazena em cache informações sobre
 * o arquivo. Em chamadas subsequentes, você deve chamar Refresh para obter a cópia mais recente  das informações.
 */


/* FileInfo - Propriedades 
 * 
 * 
 * Directory - Obtém uma instância do diretório pai
 * DirectoryName - Obtém uma string que representa o caminho completo do diretório
 * Exists - Obtém um valor que indica se um arquivo existe
 * IsReadOnly - Obtém ou define um valor que determina se o arquivo atual é somente leitura.
 * Length - Obtém o tamanho, em bytes, do arquivo atual.
 * Name - Obtém o nome do arquivo
 * 
 */


/* FileInfo - Métodos 
 * 
 * 
 * CopyTo - Copia um arquivo existente para um novo arquivo, não permitindo a substituição de um arquivo existente.
 * Decrypt - Descriptografa um arquivo que foi criptografado pela conta atual usando o método Encrypt.
 * Delete - Exclui o arquivo especificado.
 * Crypt - Criptografa um arquivo para que apenas a conta usada para criptografar o arquivo possa descriptografá-lo.
 * GetAccessControl - Obtém um objeto FileSecurity que encapsula as entradas da lista de controle de acesso (ACL) para
 * um arquivo
 * MoveTo - Move um arquivo para um novo local, fornecendo a opção de especificar um novo nome de arquivo.
 * Replace - Substitui o conteúdo de um arquivo definido pelo arquivo do bjeto FileInfo atual, excluindo o arquivo original
 * e criando um backup do arquivo substituído
 * ToString - Retorna um caminho como string
 * Open - Abre um arquivo no FileMode especificado 
 * OpenRead - Cria um FileStream somente leitura
 * OpenText - Cria um StreamReader com codificação UTF8 que lê de um arquivo de texto existente
 * OpenWrite - Cria um FileStream somente para gravação
 * 
 */



/* FileInfo e FileSystemInfo 
 * 
 * 
 * FileInfo - É usada para representar um arquivo
 * 
 * Oferece propriedades e métodos para acessar informações sobre um arquivo específico, como seu tamanho, data de criação, data de
 * modificação, caminho completo, extensão do arquivo, entre outros.
 * 
 * 
 * FileSystemInfo - É a classe base para FileInfo e DirectoryInfo
 * 
 * Fornece propriedades e métodos comuns a arquivos e diretórios, como o caminho completo, nome, data de criação, data de modificação,
 * extensão, etc.
 * 
 */


string caminhoOrigem = @"C:\dados\poesia.txt";
string caminhoDestino = @"C:\dados\txt\poesia.txt";
string caminhoCopia = @"C:\dados\poesia_copia.txt";

FileInfo arquivoOrigem = new FileInfo(caminhoOrigem);

Console.WriteLine($"\nNome do arquivo: {arquivoOrigem.Name}");
Console.WriteLine($"\nCaminho completo do arquivo: {arquivoOrigem.FullName}");
Console.WriteLine($"\nVerificar se o arquivo é somente leitura: {arquivoOrigem.IsReadOnly}");

/* Pegando o diretorio pai */
var diretorioPai = arquivoOrigem.Directory;
Console.WriteLine($"\nNome do diretório: {diretorioPai?.Name}");

Console.WriteLine($"Tamanho do arquivo: {arquivoOrigem.Length} bytes");
Console.WriteLine($"Última gravação: {arquivoOrigem.LastWriteTime}");

if (arquivoOrigem.Exists)
{
    Console.WriteLine($"\nO {caminhoOrigem} arquivo existe. Copiando para {caminhoCopia}");
    arquivoOrigem.CopyTo(caminhoCopia);
}
else
{
    Console.WriteLine($"\nO {caminhoOrigem} arquivo não existe");
}

Console.WriteLine($"\nMovendo {caminhoOrigem} para a {caminhoDestino}");
arquivoOrigem.MoveTo(caminhoDestino);

Console.ReadKey();