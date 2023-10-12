/* Interfaces - cenário atual 
 * 
 * Antes do C# 8.0, uma interface era como uma classe base abstrata que continha apenas membros
 * abstratos e qualquer classe ou struct que implementasse uma interface deveria implementar todos
 * os seus membros.
 * 
 * A partir do C# 8.0, uma interface pode definir implementações padrão para alguns ou todos os seus
 * membros, e uma classe ou struct que implementa uma interface não precisa implementar membros que
 * tenham uma implementação padrão.
 * 
 * A partir do C# 11, os membros da interface que não são campos podem ser static abstract
 * 
 * 
 * Cenário atual
 * 
 * Uma interface é um tipo de classe pode conter as assinaturas de métodos, eventos propriedade e indexadores, e,
 * também pode conter métodos públicos e estáticos que contém uma implementação
 * 
 * Os membros da interface são públicos por padrão, e você pode especificar explicitamente modificadores
 * de acessibilidade, como public, protected, interval, private, protected internal ou private protected
 * 
 * Um membro private deve ter uma implementação padrão.
 * 
 * Uma interface não pode conter campos de instância, construtores de instância ou finalizadores.
 * 
 * Para implementar um membro de interface, o membro correspondente da classe de implementação deve ser público, 
 * não estático e ter o mesmo nome e assinatura do membro de interface.
 * 
 * 
 * Interfaces - Regra geral
 * 
 * Uma interface não pode ser instanciada diretamente e seus membros abstrato são implementados por qualquer classe ou 
 * struct que implemente a interface.
 * 
 * Uma interface funciona como um contrato entre si e qualquer classe que a implementa
 * 
 * Uma classe ou struct pode implementar(herdar) várias interfaces.
 * 
 * Uma classe que implementa uma interface é obrigada a implementar todos os seus membros abstratos
 * 
 * Uma classe pode herdar uma classe base e também implementar uma ou mais interfaces.
 * 
 * Se uma classe base implementa uma interface, qualquer classe que é derivada da classe base herda essa implementação 
 * 
 * Uma interface pode herdar de uma ou mais interfaces. A interface derivada herda os membros de suas interfaces base.
 */

IControle Iteste = new Demo();
Iteste.Name = "Test";
Iteste.Desenhar();
Iteste.Exibir();


Console.ReadKey();

interface IControle
{

    /* Uma interface não pode ter um construtor 
     * public IControle() {}
     */

    /* Não pode ter um campo de instancia 
     * int status;
     */

    string Name { get; set; }

    void Desenhar();
    
    public void Exibir()
    {
        Console.WriteLine("teste...");
    }

}

interface IGrafico
{
    void Pintar();
}


public class Demo : IControle, IGrafico
{
    public string Name { get; set; } = string.Empty;

    public void Desenhar()
    {
        Console.WriteLine("Desenhando...");
    }

    public void Pintar()
    {
        Console.WriteLine("Pintando...");
    }

}