using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTKeyTValuExercicio
{
    internal class Aluno
    {
        public Aluno(string? nome, int nota)
        {
            Nome = nome;
            Nota = nota;
        }

        public Aluno() { }

        public string? Nome { get; set; }
        public int Nota { get; set; }


        public static void ExibirAlunos(Dictionary<int, Aluno> alunos)
        {
            foreach (var item in alunos.OrderBy(x => x.Value.Nome))
            {
                Console.WriteLine($"ID: {item.Key} - Nome aluno: {item.Value.Nome} -- Nota aluno: {item.Value.Nota}");
            }
        }

        public static T? TextoPrint<T>(T mensagem)
        {
            Console.WriteLine(mensagem);
            return (T?)Convert.ChangeType(Console.ReadLine(), typeof(T));
        }

    }
}
