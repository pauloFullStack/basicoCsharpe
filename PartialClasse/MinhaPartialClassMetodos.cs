using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasse
{
    public partial class MinhaPartialClass
    {
        public TimeSpan CalculaIdade(DateTime dataNascimento)
        {
            return (DateTime.Now.Date - dataNascimento);
        }

        public TimeSpan DiferencaEntreDatas(DateTime data1, DateTime data2)
        {
            var diferenca = data1.Subtract(data2);
            return diferenca;
        }

        // Permiti classes aninhadas
        public partial class ClasseAninhada
        {
            // Codigo
        }

    }
}
