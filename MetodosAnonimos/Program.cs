/* Metodos Anônimas  
 * 
 * 
 * Uma função anônima é uma função que não possui nome e que pode ser definida usando a palavra-chave delegate
 * e pode ser atribuída a uma variável do tipo delegate
 * 
 * Uma função anônima é uma declaração 'in-line' ou expressão que pode ser usada sempre que um tipo de delegate for
 * esperado
 * 
 * Podemos usá-las para inicializar um delegate nomeado ou passar um método anônimo em vez de um tipo de delegate nomeado
 * como um parâmetro de método.
 * 
 * Existem dois tipos de Funções Anônimas:
 * 1 - Métodos Anônimos (Anonymous Method)
 * 2 - Expressões Lambdas (Lambdas Expressions)
 * 
 */


internal class Program
{
    /* Exemplo basico delegate metodos anonimos 
     * public delegate void Imprimir(int valor); 
     */


    private static void Main(string[] args)
    {


        List<string> nomes = new List<string>();
        nomes.Add("Maria");
        nomes.Add("Miriam");
        nomes.Add("Paulo");
        nomes.Add("Cintia");
        nomes.Add("Maria");


        //string resultado = nomes.Find(Verifica);
        string resultado = nomes.Find(delegate (string nome)
        {
            return nome.Equals("Cintia");
        });


        Console.WriteLine(resultado);






        /* Exemplo basico delegate metodos anonimos */
        //Imprimir imprimir = delegate (int valor)
        //{
        //    Console.WriteLine($"Método Anônimo: {valor}");
        //};

        //imprimir(100);
        //imprimir(200);
        //imprimir(300);        

        Console.ReadKey();
    }


}