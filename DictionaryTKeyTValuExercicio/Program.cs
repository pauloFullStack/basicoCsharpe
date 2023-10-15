using DictionaryTKeyTValuExercicio;

Console.WriteLine("### Alunos e Notas ###\n");

var alunos = new Dictionary<int, Aluno>()
{
    {1,new Aluno("Maria", 7) },
    {2,new Aluno("Erica", 8) },
    {3,new Aluno("Ana", 9) },
    {4,new Aluno("Alex", 6) },
    {5,new Aluno("Diná", 7) }
};


Aluno.ExibirAlunos(alunos);

int codigo;

do
{
    codigo = Convert.ToInt32(Aluno.TextoPrint("\nInforme o código do Aluno a localizar (99 sai)"));

    if (codigo == 99)
        break;

    bool resultado = alunos.ContainsKey(codigo);
    if (resultado)
    {
        Console.WriteLine($"Informe a nota do(a) {alunos[codigo].Nome} (1 a 10)");
        int nota = Convert.ToInt32(Console.ReadLine());
        alunos[codigo].Nota = nota;
    }
    else
    {
        Console.WriteLine("Aluno não localizado");
    }
}
while (true);

Aluno.ExibirAlunos(alunos);


codigo = Convert.ToInt32(Aluno.TextoPrint("\nInforme o código do Aluno a remover"));

if (alunos.ContainsKey(codigo))
{
    alunos.Remove(codigo);
    Console.WriteLine("\nAluno removido com sucesso");
}


Aluno.ExibirAlunos(alunos);


var novoNome = Aluno.TextoPrint("\n### Incluindo um novo Aluon ###\nInforme o nome do aluno");
int novaNota = Convert.ToInt32(Aluno.TextoPrint("\nInforme a nota do aluno"));
int novoCodigo = Convert.ToInt32(Aluno.TextoPrint("\nInforme o codigo do aluno"));

if (!alunos.ContainsKey(novoCodigo))
{
    alunos.Add(novoCodigo, new Aluno(novoNome, novaNota));
    Console.WriteLine("Aluno incluido com sucesso");
}
else
{
    Console.WriteLine("Esse codigo já existe");
}


Aluno.ExibirAlunos(alunos);
alunos.Clear();
Aluno.ExibirAlunos(alunos);


Console.ReadKey();


//public static Dictionary<string, List<string>> GetErrors(ModelStateDictionary modelState)
//{
//    Dictionary<string, List<string>> errors = new Dictionary<string, List<string>>();

//    if (!modelState.IsValid)
//    {
//        errors = modelState
//            .Where(x => x.Value.Errors.Any())
//            .ToDictionary(
//                kvp => kvp.Key,
//                kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToList()
//            );
//    }

//    return errors;
//}