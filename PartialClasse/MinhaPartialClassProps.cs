using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasse
{
    public partial class MinhaPartialClass
    {
        public DateTime DataNascimento { get; set; }
        public string? Nome { get; set; }
    }

    // Permiti classes aninhadas
    public partial class ClasseAninhada1
    {
        // Codigo
    }
}
