/* Herança - Modificadores de acesso 
 * 
 * Um membro com o modificador protected é acessível dentro da sua classe e por instâncias das classes
 * derivadas
 * 
 * Uma classe derivada tem acesso aos membros definidos com o modificador public, internal, protected, 
 * e protected internal de uma classe base.
 * 
 * Membros com o modificador private embora sejam herdados não podem ser acessados pela classe derivada
 * (subclasse)
 * 
 * Os membros privados estão presentes na classe derivada de forma a atuar e fazer o mesmo trabalho que
 * fariam na própria classe base.
 */

ClasseDerivada obj = new ClasseDerivada();

Console.ReadLine();

public class ClasseDerivada : ClasseBase
{
    public ClasseDerivada()
    {
        /* Consegue acessar todos os membros */
        Public_Membro();
        Protected_Membro();
        Internal_Membro();
        Protected_Internal_Membro();
        /* So não acessa membros privados 
         * Private_Membro();
         */

        VisualizarVarPrivada();
        PrivateVar = 35;
        VisualizarVarPrivada();

    }
}

public class ClasseBase
{

    public int publicVar = 1;
    protected int protectedVar = 2;
    internal int internalVar = 3;
    private int _privateVar = 4;

    protected int PrivateVar
    {
        get { return _privateVar; }
        set { _privateVar = value; }
    }

    public void VisualizarVarPrivada()
    {
        Console.WriteLine(PrivateVar);
    }

    public void Public_Membro()
    {
        Console.WriteLine("ClasseBase - Método Public");
    }

    protected void Protected_Membro()
    {
        Console.WriteLine("ClasseBase - Método Protected");
    }

    internal void Internal_Membro()
    {
        Console.WriteLine("ClasseBase - Método Internal");
    }


    protected internal void Protected_Internal_Membro()
    {
        Console.WriteLine("ClasseBase - Método Protected Internal");
    }

    private void Private_Membro()
    {
        Console.WriteLine("ClasseBase - Método Private");
    }

}