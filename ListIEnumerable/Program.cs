/* List<T> e principais métodos de consultas LINQ 
 * 
 * Any() - Determina se qualquer elemento de uma sequência existe ou atende a uma condição.
 * (Determina se a coleção contém elementos)
 * 
 * FirstOrDefault() - Retorna o primeiro elemento da coleção que satisfaz uma condição opcional.
 * Retorna o valor padrão do tipo caso não encontre nenhum elemento.
 * 
 * OrderBy() - Classifica os elementos na coleção em ordem crescente com base em uma determinada
 * condição e retorna a coleção classificada.
 * 
 * ToList() - Recebe um tipo IEnumerable e o converte em um tipo List.
 * 
 * Where() - Retorna todos os elementos da coleção que satisfazem uma determinada condição.
 * (execução adiada)
 * 
 */


/* List<T> x IEnumerable<T> 
 * 
 * IEnumerable descreve um comportamento e List implementa esse comportamento
 * 
 * - IEnumerable é "read-only", ou seja, eu não consigo alterar a coleção, somente ler.
 * - List implementa uma variedade de métodos capazes de acessar e alterar a coleção
 * 
 * - IEnumerable possui um método para retornar o próximo item na coleção
 * Não precisa ter toda a coleção na memória
 * Não sabe quantos elementos a coleção possui
 * Ao ser iterada em um laço foreach ela vai retornando o próximo item até o fim da coleção
 * 
 * - List possui toda a coleção em memória e sabe quantos itens possui a coleção
 * 
 * IEnumerable dá ao compilador a chance de adiar a execução 
 * Somente é executa ao ser iterada em um laço foreach/for ou ter um valor extraído
 */


var aluno = new List<Aluno>()
{
    new Aluno() { Nome = "Maria", Nota = 8.75 },
    new Aluno() { Nome = "Manoel", Nota = 6.95 },
    new Aluno() { Nome = "Amanda", Nota = 7.25 },
    new Aluno() { Nome = "Carlos", Nota = 6.55 },
    new Aluno() { Nome = "Jaime", Nota = 8.50 },
    new Aluno() { Nome = "Debora", Nota = 5.95 },
    new Aluno() { Nome = "Alicia", Nota = 9.25 },
    new Aluno() { Nome = "Sandra", Nota = 5.55 },
    new Aluno() { Nome = "Marta", Nota = 7.85 },
    new Aluno() { Nome = "Sueli", Nota = 9.15 },
};

//aluno.Sort((a, b) => string.Compare(a.Nome, b.Nome));
Aluno.StatusSala(aluno);

aluno.Add(new Aluno() { Nome = "Bia", Nota = 7.75 });
aluno.Add(new Aluno() { Nome = "Mario", Nota = 8.95 });

Console.WriteLine("\n---------------------------------\n");

Aluno.StatusSala(aluno);


var searchAlunoIndex = aluno.FindIndex(x => x.Nome == "Amanda");
aluno.RemoveAt(searchAlunoIndex);


Console.WriteLine("\n---------------------------------\n");

Aluno.StatusSala(aluno.OrderBy(a => a.Nome).ToList());

var comparandoNotas = aluno.FindAll(x => x.Nota >= 8);

Console.WriteLine("\nAlunos com notas maior que 8 \n");
foreach (var notas in comparandoNotas)
{
    Console.WriteLine($"Nome: {notas.Nome} - Nota = {notas.Nota}");
}


Console.ReadKey();

class Aluno
{
    public string? Nome { get; set; }
    public double Nota { get; set; }

    public static void StatusSala(List<Aluno> alunos)
    {

        int quantidadeAluno = alunos.Count();
        double mediaNotasSala = 0;
        Console.WriteLine("Dados sala de aluno\n");

        foreach (var aluno in alunos)
        {
            Console.WriteLine($"Nome: {aluno.Nome} - Nota = {aluno.Nota} ");
            mediaNotasSala += aluno.Nota;
        }

        mediaNotasSala = mediaNotasSala / quantidadeAluno;
        Console.WriteLine();
        Console.WriteLine($"Quantidade total alunos: {quantidadeAluno}");
        Console.WriteLine($"Media Nota Alunos =  {mediaNotasSala}");
    }

}