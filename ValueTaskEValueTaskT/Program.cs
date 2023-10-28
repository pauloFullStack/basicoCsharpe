/* Programação assíncrona: ValueTask e ValueTask<T>
 * 
 * A partir do C# 7.0 foram introduzidos dois novos tipos de retornos:
 * ValueTask - Fornece um resultado esperado de uma operação assíncrona
 * ValueTask<T> - Fornece um tipo de valor que encapsula um Task<T> e um T
 * 
 * Motivo ?
 * 
 * Task e Task<T> são tipos de referência e são alocados na Heap e vai usar o Garbage Collector isso pode 
 * impactar o consumo de memória e o desempenho se for muito usado
 * 
 * ValueTask e ValueTask<T> são tipos de valor(struct) e são alocados na Stack e não usa o GC
 * Usar ValueTask ou ValueTask<T> evita alocação desnecessárias e leva a um ganho no  desempenho
 * 
 */


/* Quando usar ValueTask e ValueTask<T> 
 * 
 * 1-Quando o resultado da operação executada pelo método assíncrono já estiver disponível no momento da espera
 * 2-Quando temos cenários assíncronos no qual o aramazenamento em buffer esta presente
 * 3-Quando o resultado da operação for concluída de forma sincrona
 */

Console.WriteLine("\nIniciando a operação assíncrona...");
await MetodoSemRetornoAsync();

Console.WriteLine("\nIniciando a operação assíncrona...");
var resultado = await MetodoRetornaValorAsync(20);

Console.WriteLine($"Valor do metodo assincrona que retorna {resultado}");

Console.ReadKey();

static async ValueTask MetodoSemRetornoAsync()
{
    Console.WriteLine("Método que não retorna valor");
    await Task.Delay(2000);
}

static async ValueTask<int> MetodoRetornaValorAsync(int valor)
{

    Console.WriteLine("Método que retorna valor");
    await Task.Delay(2000);
    return valor * 2;
}