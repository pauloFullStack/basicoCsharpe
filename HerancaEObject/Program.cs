/* Herança - A classe Object 
 * 
 * Toda a classe é derivada da classe Object, e, a classe Object não deriva de nenhuma classe;
 * Ela é a classe Base(Pai) de todas as classes;
 * 
 * A classe Object dá suporte a todas as classes na hierarquia de classes do .NET e fornece
 * serviços de baixo nível para as classes derivadas
 * 
 * Os métodos definidos na classe Object estão disponíveis em todos os objetos do sistema e
 * as classes derivadas podem substituir alguns desses métodos:
 * - Equals - Suporta comparações entre objetos;
 * - GetHashCode - Gera um número hash para o objeto;
 * - ToString - Retorna a representação do objeto como uma string;
 * - GetType - Retorna informação sobre o tipo;
 * 
 * Uma classe somente pode herdar de outra classe e apenas de uma classe, em c# não existe herança multipla
 */


Nada nada = new Nada();

nada.Equals(nada);  

Console.ReadKey();


public class Nada
{

}