/* Herança - Relacionamenteo "é um(a)"
 * 
 * 
 * A herança é usada para expressar um relacionamento "é um(a)" entre uma classe base e
 * uma ou mais classes derivadas, onde as classes derivadas são versões especializadas da
 * classe base
 * 
 * A classe derivada é um tipo da classe base
 */


/* Diagrama de classe - Representação da herança 
 * 
 * 
 * O Visual Studio 2022 oferece o componente Class Diagram que permite representar as classes
 * e o relacionamento de herança entre elas
 * 
 * Abra o visual studio installer e clique em 'Modificar'
 * Clique em 'Componentes Individuais' e localize a seção - Ferramentas e Código
 * Selecione o item - Designer de classe
 * Clique em fechar para instalar o pacote
 * 
 * Para incluir o componente, selecione o projeto e no menu Project clique em Add New Item
 * Procure por: Class Diagram
 * Selecione a opção, informe um nome, e clique no botão Add
 * Para usar basta arrastar e soltar as classes no Designer
 */


/* Herança Simples 
 * 
 * É o tipo de herança em que há uma classe base e uma classe derivada, Ex:
 * 
 * # Class Base
 * public class Conta
 * {
 *      public int Numero { get; set; }
 *      public double Saldo { get; private set; }
 * }
 * 
 * # Class Derivada
 * public class ContaPoupanca : Conta
 * {
 *      public int JurosMensais {  get; set; }
 * 
 * }
 * 
 */


/* Herança Hierárquica 
 * 
 * Este é o tipo de herança em que existem várias classes derivadas de uma classe base.
 * 
 * # Classe Base
 * public class A
 * {
 *     public void Exibir()
 *     {
 *        Console.WriteLine("Método da classe A");
 *     }
 * }
 * 
 * # A Classe B deriva da classe A
 * public class B : A
 * {
 *     public void Mostrar()
 *     {
 *        Console.WriteLine("Método da classe B");
 *     }
 * }
 * 
 * # A Classe C é derivada da classe A
 * public class C : A
 * {
 *     public void Apresentar()
 *     {
 *        Console.WriteLine("Método da classe C");
 *     }
 * }
 */


/* Herança Multinível 
 * 
 * Ocorre quando uma classe é derivada de outra classe derivada .
 * 
 * # Classe Base
 * public class A
 * {
 *     public void Exibir()
 *     {
 *        Console.WriteLine("Método da classe A");
 *     }
 * }
 * 
 * # A Classe B deriva da classe A
 * public class B : A
 * {
 *     public void Mostrar()
 *     {
 *        Console.WriteLine("Método da classe B");
 *     }
 * }
 * 
 * # A Classe C é derivada da classe B
 * public class C : B
 * {
 *     public void Apresentar()
 *     {
 *        Console.WriteLine("Método da classe C");
 *     }
 * }
 */


/* Herança Múltipla(implementação) 
 * 
 * Ocorre quando temos uma classe base e uma classe derivada que implementa uma ou mais interfaces.
 * 
 * # Classe Base
 * public class Forma
 * {
 *     public void SetLado(int s)
 *     {
 *        lado = s;
 *     }
 *     protected int lado;
 * }
 * 
 * 
 * # Interface
 * interface ICusto
 * {
 *     int GetCusto(int area);
 * }
 * 
 * 
 * # Classe Quadrado deriva da classe Forma, e deriva da interface ICusto, isso seria a herança multipla 
 * # So interfaces podem ser herdadas por varias outras interfaces, classes não é herança multipla
 * 
 * public class Quadrado : Forma, ICusto
 * {
 *     public void GetArea()
 *     {
 *        return(lado * lado);
 *     }
 *     public int GetCusto(int area)
 *     {
 *        return area * 10;
 *     }
 * }
 */





