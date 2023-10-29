using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LINQOperadoresDeProjecao
{
    internal class FonteDeDados
    {
        public static List<int> GetNumeros()
        {
            List<int> numeros = new List<int>()
            {
                1,2,4,8,16,32,64,128,256,512
            };
            return numeros;
        }

        public static List<int> GetListaNegra()
        {
            List<int> numeros = new List<int>()
            {
                16,128,512
            };

            return numeros;
        }

        public static List<Aluno> GetAlunos()
        {
            List<Aluno> alunos = new List<Aluno>()
            {
                new Aluno(){Nome = "Maria", Idade = 42, Nota = 7, Cursos = new List<string> {"VB.NET","ASP.NET"} },
                new Aluno(){Nome = "Manoel", Idade = 34, Nota = 6, Cursos = new List<string> {"C#","EF Core"}},
                new Aluno(){Nome = "Amanda", Idade = 21, Nota = 5, Cursos = new List<string> {"Java","Node"}},
                new Aluno(){Nome = "Carlos", Idade = 18, Nota = 9, Cursos = new List < string > { "C++", "MongoDB", "Node" }},
                new Aluno(){Nome = "Alicia", Idade = 15, Nota = 4, Cursos = new List < string > { "TypeScript", "React", "Node" }},
            };

            return alunos;
        }
    }
}
