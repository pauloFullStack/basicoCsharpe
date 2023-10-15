/* Multicast Delegate 
 * 
 * 
 * - SingleCast Delegate: Delegate que referencia e invoca um único método 
 * - MultiCast Delegate:  Delegate que referencia e invoca mais de um método
 * 
 * Podemos encapsualar mais de uma referência de método em um delegate usando um multicast delegate
 * 
 * Um Multicast Delegate é um delegate que contém as referências a mais de método
 * 
 * Quando invocamos o multicast delegate, todos os métodos referenciados pelo delegate serão invocados em ordem
 * 
 * Um multicast delegate é util em situações em que várias ações precisam ser executados quando um evento ocorrer
 * 
 */


/* Multicast Delegate - criação 
 * 
 * 
 * Para criar um multicast delegate, primeiro definimos um delegate que representa a assinatura dos métodos que serão
 * registrados
 * 
 * A seguir criamos uma instância do delegate e registramos os métodos desejados usando o operador '+=' para adicionar
 * cada método na lista de métodos a serem chamados.
 * 
 * Podemos também usar o operador '-=' para excluir um método da lista de métodos a serem chamados
 */


/* Multicast Delegate - Usos
 * 
 * 
 * São usados em diversas situações, onde é necessário chamar múltiplos métodos quando um determinado evento ocorre.
 * - Eventos
 * - Callbacks
 * - Encadeamento de métodos
 * - Aplicações assíncronas
 * - Aplicativos de multimídia e streaming, com tv na web, rádio na web e videoconferência/audio em tempo real.
 * - Comunicação para treinamento e operações cooperativas, como ensino a distância e telemedicina
 * - Dat warehouse e aplicativos financeiros(cotações de ações)
 * 
 */

using DelegateMulticast;

internal class Program
{

    public delegate void MeuDelegte(string mensagem);

    private static void Main(string[] args)
    {
        
        MeuDelegte del = new MeuDelegte(Exemplo.Metodo1);
        del += Exemplo.Metodo2;
        del += Exemplo.Metodo3;
        del("Teste delegate");

        del -= Exemplo.Metodo3;
        del("O metodo 3 foi removido");

        Console.ReadKey();
    }
}