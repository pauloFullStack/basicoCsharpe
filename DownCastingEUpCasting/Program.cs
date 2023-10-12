/* Upcasting 
 * 
 * A operação de Upcasting converte um objeto de um tipo especializado (classe derivada ou filha) para
 * um tipo mais geral (classe base ou pai)
 * 
 * Podemos entender o upcasting como a atribuição de um objeto de uma classe filha para uma referência de
 * uma classe base.
 * 
 * Esta operação é implícita, e, não é preciso ser feita de forma explicita, sendo sempre possível de ser
 * realizada.
 * 
 */


/* Upcasting - Exemplo 
 * 
 * Converter a instância do tipo Circulo para o tipo da classe Forma, Exemplo:
 * 
 * Forma circulo = new Circulo();
 * circulo.Desenhar();
 * 
 * 
 * Embora forma e circulo se refiram ao mesmo objeto, forma tem uma visão mais restrita deste objeto
 * pois pode acessar somente o método Desenhar
 * 
 * A variável forma é do tipo Forma e mesmo se referindo a um objeto do tipo Circulo não acessa o método
 * PintarCirculo()
 * 
 * Circulo circulo = new Circulo();
 * Forma forma = circulo;
 * Console.WriteLine(forma == circulo);
 * forma.Desenhar();
 * 
 */


using DownCastingEUpCasting;


/* EXEMPLO DE UPCASTING */
Console.WriteLine("EXEMPLO DE UPCASTING");
/* Forma circulo = new Circulo(10,20);  upcasting */
Circulo circulo = new Circulo(10, 20);
Forma forma = circulo; /* upcasting */

circulo.Desenhar(); /* Acessando Desenhar() na classe Circulo */
circulo.PintarCirculo();
forma.Desenhar(); /* Acessando Desenhar() na classe Circulo */

Forma formaOriginal = new Forma(10, 20);
formaOriginal.Desenhar(); /* Acessando Desenhar() da classe Forma base */

Console.WriteLine(forma == circulo);



/* Downcasting 
 * 
 * A operação de Downcasting converte um objeto de um tipo geral (classe base) para um tipo mais especializado
 * (classe filha)
 * 
 * Podemos entender o downcasting como a atribuição de um objeto da classe base para um objeto da classe derivada.
 * 
 * A operação de downcasting deve ser feita de forma explícita pois pode falhar e lançar uma exceção, ou seja, é
 * uma operação que nem sempre é possível de ser realizada.
 * 
 */

/* EXEMPLO DE DOWNCASTING */


/* Foi feito o downcasting da variável forma que é do tipo Forma para Circulo
 * 
 * A variável c referencia tanto a  variavel forma como a variavel c ou seja temos a mesma referência.
 * 
 * A instância c pode acessar o método PintarCirculo() e também Desenhar()
 * 
 * Se o downcasting falhar ocorre uma exceção do tipo InvalidCastException
 * 
 */

Console.WriteLine("\nEXEMPLO DE DOWNCASTING");

Circulo circulo1 = new Circulo(20, 20);
Forma forma1 = circulo1; // upcasting

Circulo circuloForma = (Circulo)forma1; // downcasting

circuloForma.Desenhar();
circuloForma.PintarCirculo();

Console.WriteLine(circuloForma == forma1);
Console.WriteLine(circuloForma == circulo1);

Console.ReadKey();
