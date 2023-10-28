/* Path 
 * 
 * Esta presente no namespace System.IO e executa operações em instância de string que contêm informações do caminho de um 
 * arquivo ou diretório.
 * 
 * Fornece métodos e propriedades úteis para manipular caminhos de uma forma que é compatível com o sistema operacinal no qual 
 * o código está sendo executado.
 * 
 * Nota: Um caminho é uma cadeia de caracteres que fornece o local de um arquivo ou diretório: Ex: C:\temp\file1.txt
 */


/* Path Fields(campos) 
 * 
 * DirectorySeparatorChar - Fornece o caractere usado como separador de diretórios no caminho(ex: '\' no windows e '/' no linux)
 * AltDirectorySeparatorChar - Fornece o caractere alternativo usado como separador de diretorios(Ex: '/' no windows)
 * PathSeparator - Fornece o caractere usado como separador de caminhos múltiplos(Ex: ';' no windows).
 * VolumeSeparatorChar - Fornece o caractere usado como separador de volume no caminho(Ex: ':' no windows);
 */

string caminho = "C:\\dados\\txt\\poesia.txt";
char disSeparador = Path.DirectorySeparatorChar;
Console.WriteLine($"O separador de diretorio padrao é: {disSeparador}");

string[] diretorios = caminho.Split(disSeparador);
Console.WriteLine("Os diretorios e arquivos no caminho são:");
foreach (var diretorio in diretorios)
    Console.WriteLine(diretorio);


string path1 = "C:\\dados";
string path2 = "txt\\poesia.txt";

string pathCombinado = Path.Combine(path1, path2);
Console.WriteLine($"\nCaminho Combinado: {pathCombinado}");
Console.WriteLine($"\nNome do diretório: {Path.GetDirectoryName(pathCombinado)}");
Console.WriteLine($"\nExtensão: {Path.GetExtension(pathCombinado)}");
Console.WriteLine($"\nNome do arquivo: {Path.GetFileName(pathCombinado)}");
Console.WriteLine($"\nNome do arquivo sem extensão: {Path.GetFileNameWithoutExtension(pathCombinado)}");
Console.WriteLine($"\nPossui extensão ?: {Path.HasExtension(pathCombinado)}");
Console.WriteLine($"\nContém a raiz ?: {Path.IsPathRooted(pathCombinado)}");
Console.WriteLine($"\nNova extensão do arquivo: {Path.ChangeExtension(pathCombinado, ".docx")}");
Console.WriteLine($"\nRaiz: {Path.GetPathRoot(pathCombinado)}");

Console.WriteLine($"\nNome de arquivo aleatório: {Path.GetRandomFileName()}");
Console.WriteLine($"\nNome de arquivo temporário: {Path.GetTempFileName()}");
Console.WriteLine($"\nCaminho Temporário: {Path.GetTempPath()}");

/* Caracteres invalidos para nome de arquivo */
char[] caracteresInvalidosEmArquivo = Path.GetInvalidFileNameChars();
Console.WriteLine($"\nCaracteres Inválidos em nome de arquivos: {new string(caracteresInvalidosEmArquivo)}");

Console.ReadLine();