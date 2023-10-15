
using ExercicioDelegate;
using System.Collections.Generic;

internal class Program
{


    private static void Main(string[] args)
    {


        /* Delegate lista de pessoas */
        var listPessoas = Pessoa.GetPessoas();
        Action<Pessoa> delegateListPessoas = pessoa => Console.WriteLine($"Nome: {pessoa.Nome} - Idade: {pessoa.Idade}");
        listPessoas.ForEach(delegateListPessoas);

        /* Delegate maior de 18 */

        Console.WriteLine("\nMaior de 18");
        Func<List<Pessoa>, List<Pessoa>> delegateListPessoasMaiorDezoito = pessoa => pessoa.FindAll(pessoa => pessoa.Idade > 18);
        delegateListPessoasMaiorDezoito(listPessoas).ForEach(pessoa => Console.WriteLine($"Nome: {pessoa.Nome} - Idade: {pessoa.Idade}"));



        /* Metodo Func */
        Func<List<Pessoa>, int> delegatePessoasMaisVelha = pessoaMaisVelha => pessoaMaisVelha.Max(pessoa => pessoa.Idade);
        Func<List<Pessoa>, Pessoa> delegateListMaisVelho = listPessoaVelha => listPessoaVelha.Find(listPessoaVelha => listPessoaVelha.Idade == delegatePessoasMaisVelha(listPessoas));
        var pessoaMaisVelha = delegateListMaisVelho(listPessoas);;
        Console.WriteLine("\nMais velha Nome: {0} Idade: {1}", pessoaMaisVelha.Nome, pessoaMaisVelha.Idade);


        Console.ReadKey();
    }
}