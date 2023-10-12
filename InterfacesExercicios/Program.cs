
using InterfacesExercicios;

SalvarXml salvarXml = new SalvarXml();
salvarXml.Salvar();
salvarXml.Nome();

SalvaJson salvaJson = new SalvaJson();
salvaJson.Salvar();
salvaJson.Nome();


/* Acessando metodos implementados de uma interface herdada 
 * 
 * Cria uma instancia da classe que herda a interface, com o tipo da interface
 */
ISalvar salvarArquivo = new SalvaJson();
salvarArquivo.Compactar();



Console.ReadKey();