/* Queue é o mesmo conceito de Stack, so que queue é igual uma fila, o primeiro a entrar e o primeiro a sair 
 * unica coisa que muda são seus metodos, algusn...
 */


/* Queue<T> - Propriedade e Métodos 
 * 
 * 
 * Count          =    Retorna o total de itens na fila
 * Enqueue(T)     =    Inclui um item no final da fila
 * Dequeue        =    Retorna um item do início da fila e o remove da fila
 * Peek()         =    Retorna o item do início da fila sem removê-lo
 * Contains()     =    Verifica se um item existe na fila. (true/false)
 * Clear()        =    Remove todos os elementos da fila
 */


using Queue;

string[] cursos = { "C#", "Phyton", "Java", "SQL", "ASP.NET" };
Queue<string> fila1 = new Queue<string>(cursos);

Console.WriteLine($"No. de Elementos na fila1: {fila1.Count()}");
ExibirFila(fila1);

fila1.Enqueue(".NET MAUI");
ExibirFila(fila1);


Console.WriteLine("\n-Obtendo o primeiro item da fila com Peek");
var elemento = fila1.Peek();
Console.WriteLine(elemento);

Console.WriteLine("\n-Método Dequeue - remove item do início da fila");
fila1.Dequeue();
ExibirFila(fila1);

if (fila1.Contains("C#")) Console.WriteLine("C# esta na fila");
else Console.WriteLine("C# não esta na fila");


Console.WriteLine("\n-Limpa a fila com Clear()");
fila1.Clear();
Console.WriteLine("No. de Elementos na fila1: {0} ", fila1.Count());

Console.WriteLine("\n--------------------- Pedidos ----------------------\n");

/* Criando a fila de pedidos */
Queue<Pedidos> filaPedidos = new Queue<Pedidos>();

/* Adicionar pedidos na fial */
filaPedidos.Enqueue(new Pedidos(101, 10.0));
filaPedidos.Enqueue(new Pedidos(201, 20.0));
filaPedidos.Enqueue(new Pedidos(301, 30.0));


/* Exibir o numero de pedidos na fila */
Console.WriteLine($"\nNúmero de pedidos na fila: {filaPedidos.Count}");

/* Processar os pedidos da fila */
while (filaPedidos.Count > 0)
{
    /* Retirar o proximo pedido da fila */
    Pedidos proximoPedido = filaPedidos.Dequeue();

    Console.WriteLine($"Processando pedido {proximoPedido.Numero} " +
                      $"Valor {proximoPedido.Valor}");
}

/* Adicionar mais alguns pedidos a fila */
filaPedidos.Enqueue(new Pedidos(401, 40.0));
filaPedidos.Enqueue(new Pedidos(501, 5.0));
filaPedidos.Enqueue(new Pedidos(601, 60.0));


/* Localizar um pedido na fila */
Pedidos? pedidoLocalizado = filaPedidos.FirstOrDefault(p => p.Numero == 501);

if (pedidoLocalizado != null) Console.WriteLine($"Pedido 501 localizado na fila " +
                      $"Valor {pedidoLocalizado.Valor}");
else Console.WriteLine("Pedido 501 não encontrado na fila");




Console.ReadKey();

static void ExibirFila<T>(IEnumerable<T> fila1)
{
    Console.WriteLine();
    foreach (var item in fila1)
    {
        Console.WriteLine(item);
    }
}