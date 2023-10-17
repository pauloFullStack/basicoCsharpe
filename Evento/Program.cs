/* Eventos - Definição 
 * 
 * 
 * São mecanismo que permitem que uma classe ou objeto notifique outras classes ou objetos quando alguma ação ocorre.
 * 
 * A classe que envia(ou aciona) o evento é chamada de publisher ou publicador e as classes que recebem(ou manipulam)
 * os eventos são chamadas de Subscribers ou Assinates.
 * 
 * - Pode haver vários assinantes de um único evento
 * - Um publicador, quase sempre, gera um evento quando alguma ação ocorre
 * - Os assinantes, que estão interessados em receber uma notificação quando uma ação ocorrr, devem se registrar em 
 * um evento e tratá-lo.
 * - E os métodos das classes que manipulam o evento(Subscribers) geralmente são chamados de manipuladores de eventos
 * 
 */


/* Eventos - Características
 * 
 * 
 * Um evento é basicamente uma declaração de um delegate que é um tipo de referência que permite que um método seja 
 * passado como argumento para outro método.
 * 
 * O delegate é definido pela assinatura do método que será chamado quando o evento for disparado.
 * 
 * No C#, um evento é um delegate encapsulado e depende do delegate.
 * 
 * O delegate define a assinatura para o método manipulado de eventos da classe assinante
 * 
 */


/* Eventos - Propriedades 
 * 
 * 
 * O Publisher(Publicador) determina quando um evento é acionado. Os Subscribers(Assinantes) determinam
 * a ação que é executada em resposta ao evento.
 * 
 * Um evento pode ter vários assinantes. Um assinante pode manipular vários eventos de vários publicadores.
 * 
 */


/* Criando um evento 
 * 
 * 
 * 1 - Definir um delegate com a assinatura do método que será chamado quando o evento for disparado.
 * 2 - Declarar um evento na classe que irá disparar o evento, usando o delegate definido anteriormente.
 * 3 - Disparar o evento quando a ação desejada ocorrer na classe
 * 4 - Inscrever os assinantes interessados nos eventos desejados
 */


/* Delegate pré-definidos: EventHandler e EventHandler<TEventArgs>
 * 
 * 
 * 1 - EventHandler
 * 
 * Representa um método que vai manipular um evento que não possui dados.
 * Ex: public delegate void EventHandler(object? sender, EventArgs e);
 * - object? sender : contém uma referência ao objeto que gerou o evento(fonte do evento)
 * - e EventArgs : um objeto que não contém nenhum dado de um evento
 *
 * 2 - EventHandler<TEventArgs>
 * 
 * Representa um método que vai manipular um evento que possui dados
 * Ex: public delegate void EventHandler<TEventArgs>(object? sender, TEventArgs e);
 * - TEventArgs : O tipo dos dados do evento gerado pelo evento
 * - object? sender : contém uma referência ao objeto que gerou o evento(fonte do evento)
 * - e TEventArgs: um objeto que contém os dados de um evento
 * 
 * Para passar dados no segundo parâmetro do manipulador de eventos do Publicador para os Assinantes, temos que 
 * definir uma classe que herda da classe EventArgs e armazenar os dados que desejamos passar na classe
 * 
 * Realizar os ajustes relativos a assinatura do delegate e dos métodos para enviar os dados
 * 
 */

internal class Program
{
    private static void Main(string[] args)
    {
        var pedido = new Pedido();

        /* Inscrever os assinantes no evento */

        pedido.OnCriarPedido += Email.Send;
        pedido.OnCriarPedido += SMS.Send;

        pedido.CriarPedido("paulofullstack@hotmail.com","34992245739");

        Console.ReadKey();
    }
}

/* Cria o delegate para o evento */
//delegate void PedidoEventHandler();

class PedidoEventArgs : EventArgs
{
    public string? Email { get; set; }
    public string? Telefone { get; set; }
}

class Pedido
{
    public event EventHandler<PedidoEventArgs> OnCriarPedido;

    public void CriarPedido(string email, string fone)
    {
        Console.WriteLine("\nPedido criado!!!");
        if (OnCriarPedido != null)
        {
            OnCriarPedido(this, new PedidoEventArgs { Email = email, Telefone = fone });
        }
    }
}

class Email
{
    public static void Send(object? sender, PedidoEventArgs e)
    {
        Console.WriteLine($"\nEnviando um email para : {e.Email}");
    }
}

class SMS
{
    public static void Send(object? sender, PedidoEventArgs e)
    {
        Console.WriteLine($"\nEnviando um SMS para : {e.Telefone}");
    }
}
