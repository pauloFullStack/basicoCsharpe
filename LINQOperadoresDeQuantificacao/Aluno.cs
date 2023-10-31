using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQOperadoresDeQuantificacao
{
    internal class Aluno
    {
        public string? Nome { get; set; } = string.Empty;
        public int Idade { get; set; }
        public int Nota { get; set; }
        public DateTime Nascimento { get; set; }
        public List<string> Cursos { get; set; } = new List<string>();
    }

    internal class Cachorro
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public bool Vacinado { get; set; }

    }

    internal class Pessoa
    {
        public string? Nome { get; set; }
        public Cachorro[]? Cachorros { get; set; }
    }

}
