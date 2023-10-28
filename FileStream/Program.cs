/* FileStream 
 * 
 * Fornece um stream para um arquivo, dando suporte a operações de leitura e gravação síncronas e assíncronas. 
 * Esta classe deriva da classe Stream.
 * 
 * Nota: Um stream é uma sequência de dados(bytes) que pode ser lida ou escrita em partes menores. A classe Stream é a classe base 
 * para todos os streams.
 * 
 * Ela pode ser usada para ler, gravar, abrir e fechar arquivos em um sistema de arquivos e para tratar com outros manipuladores do 
 * sistema operacional relacionados a arquivos, incluindo pipes, a entrada padrão e a saída padrão.
 * 
 * Stream é uma classe abstrata para transferência de bytes de diferentes origens. É a classe base para todas as outras classes
 * que leem/escrevem em fontes diferentes.
 * 
 * A classe FileStream fornce a funcionalidade de leitura e gravação de bytes no arquivo físico
 * 
 * StreamReader - Fornece métodos para ler strings de um FileStream convertendo bytes em strings
 * StreamWriter - Fornece métodos para gravar strings em um FileStream convertendo strings em bytes
 */


/* StreamReader: É um classe auxiliar usada para ler caracteres de um Stream convertendo bytes em caracteres 
 * usando um valor codificado e pode ser usada para ler strings(caracteres) de diferentes Streams como FileStream, MemoryStream, etc.
 */

/* StreamWriter: É uma classe auxiliar usada para gravar uma string em um Stream convertendo caracteres em bytes e pode
 * ser usada para gravar strings em diferentes Stream, como FileStream, MemoryStream, etc.
 */


/* FileStream: liberando recursos 
 * 
 * Fechar os objetos FileStream, StreamReader e StreamWriter ao terminar de usa-los, para liberar os recursos do sistema.
 * 1-Usar o método Close();
 * 2-Usar o bloco using (garante que os objetos sejam fechados automaticamente quando o bloco terminar de ser executado)
 * 
 */