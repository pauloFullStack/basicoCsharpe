/* Delegate Func 
 * 
 * 
 * O Delegate Func encapsula um método que pode possuir de zero até 16 parâmetros e que tem um tipo de retorno
 * Ex: delegate TResult Func<in T1, in T2, ...., out TResult>(T1 arg1, T2 arg2, ...);
 * 
 * T1,T2,... - São os tipos dos argumentos do método encapsulado por este delegate
 * TResult - É o tipo de retorno do método encapsulado por esse delegate
 * 
 * Sua assinatura possui 17 sobrecargas:
 * Func(TResult), Func<T, TResult>, Func<T1,T2,TResult>, ... Func<T1,....,T16,TResult>
 * 
 * 
 */



Console.WriteLine("Digite um número: ");
double numero = Convert.ToDouble(Console.ReadLine());

Func<double, double> raizQuadrada = x => Math.Sqrt(x);
Console.WriteLine(raizQuadrada(numero));

Console.ReadKey();