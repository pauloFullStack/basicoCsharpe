/* Construtor estático : exemplo 
 * 
 * OBS: Construtor estático não pode ser parametrizado, só quando é criado um objeto
 * 
 * Os construtores estáticos só são executados uma unica vez
 */

Console.WriteLine("## Construtor estático ##\n");

/* O construtor estático é executado também quando é invocado qualquer menbro estático, 
 * também executado somente uma vez */ 
//Console.WriteLine($"{Pessoa.IdadeMinima}");
//Console.WriteLine($"{Pessoa.IdadeMinima}");

/* Invoca o construtor parametrizado e o estático */
Pessoa pessoa1 = new Pessoa("Maria", 30);
Console.WriteLine($"{pessoa1.Nome} - {pessoa1.Idade} ");
Console.WriteLine($"IdadeMinima - {Pessoa.IdadeMinima}");

/* Invoca so o construtor parametrizado, o estático só é executado uma vez, que já foi executado acima na primeira invocação */
Pessoa pessoa2 = new Pessoa("João", 25);
Console.WriteLine($"{pessoa2.Nome} - {pessoa2.Idade} ");
Console.WriteLine($"IdadeMinima - {Pessoa.IdadeMinima}");


Console.ReadLine();
