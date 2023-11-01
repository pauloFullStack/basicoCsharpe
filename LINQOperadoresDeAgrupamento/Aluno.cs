using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQOperadoresDeAgrupamento
{
    internal class Aluno
    {
        public int AlunoId { get; set; }
        public string? Nome { get; set; } = string.Empty;
        public char Sexo { get; set; }
        public string? Curso { get; set; }
        public int Idade { get; set; }
        public int Nota { get; set; }
        public DateTime Nascimento { get; set; }
        public List<string> Cursos { get; set; } = new List<string>(); 
    }
}
