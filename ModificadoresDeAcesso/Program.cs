/* Modificadores de acesso 
 * 
 * Os modificadores de acesso são palavras-chave usadas para especificar o acesso
 * de um membro (campo, propriedade, método, etc.) ou de um tipo (classe, struct, etc).
 * 
 * public, private, internal, protected, file
 * 
 * public - O tipo ou membro pode ser acessado por qualquer outro código no mesmo
 * assembly ou me outro assembly que faz referência a ele
 * 
 * private - O tipo ou membro pode ser acessado somente pelo código na mesma classe
 * ou struct.
 * 
 * internal - O tipo ou membro pode ser acessado por qualquer código no mesmo assembly,
 * mas não de outro assembly
 * 
 * protected - O tipo ou membro pode ser acessado por qualquer código no assembly no qual
 * ele é declarado ou de uma classe derivada em outro assembly
 * 
 * file - Restringe o escopo e a visibilidade de um tipo de nível superior ao arquivo no 
 * qual ele for declarado
 * 
 */


using ModificadoresDeAcesso;

internal class Program
{
    private static void Main(string[] args)
    {
        MinhaClasse minhaClasse = new MinhaClasse();

        MinhaStruct minhaStruct = new MinhaStruct();

        Console.WriteLine(MinhaEnum.opcao1);

        Console.ReadLine();
    }
}