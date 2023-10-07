/* REF - Passando argumento por referencia (ref)
 * 
 * É a mesma coisa de passar um ponteiro em c++, 
 * você não passa o valor mas sim a referencia da area da memorio 'o endereço da memoria' onde esta o valor da variavel 
 */


Console.WriteLine("## Passando argumentos por referência Ref ##\n");

int x = 20;
Console.WriteLine($"\nValor do argumento x antes de passar a referencia como argumento {x} ");

Calculo calc = new Calculo();
calc.Dobrar(ref x);

Console.WriteLine($"\nValor do argumento x depois de passar no metodo Dobrar {x} ");


Console.WriteLine("\n-------------------------------------\n");


/* OUT - Passagem de argumentos por referência (out)
 * 
 * A palavra-chave out faz com que os argumentos sejam passados por referência.
 * 
 * Devemos usar a palavra-chave out na declaração do método e na invocação do método.
 * 
 * A principal diferença é que out transfere dados para fora do método e não para dentro dele.
 * 
 * Variáveis passadas como argumentos out não precisam ser inicializadas antes de serem passadas
 * passadas em uma chamada de método
 * 
 * No entanto o método chamado deve atribuir um valor ao parâmetro definido com a palavra-chave
 * out antes que o método seja retornado
 * 
 */

Console.WriteLine("## Argumentos por referência - out ##");

Console.WriteLine("Informe o raio do círculo");
double raio = Convert.ToDouble(Console.ReadLine());

Circulo circulo = new Circulo();
double perimetro = circulo.CalculaAreaPerimetro(raio, out double area);

Console.WriteLine($"Perímetro da Circunferencia {perimetro}");
Console.WriteLine($"Área da Circunferencia {area}");

Console.ReadLine();

/* out */
public class Circulo
{
    public double CalculaAreaPerimetro(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio, 2);
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }

}



/* Ref */
public class Calculo
{
    public void Dobrar(ref int y)
    {
        y *= 2;
        Console.WriteLine($"\nValor do parâmetro y no método Dobrar {y}");
    }
}