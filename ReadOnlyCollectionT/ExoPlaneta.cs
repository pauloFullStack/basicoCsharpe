using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyCollectionT
{
    internal class ExoPlaneta
    {
        public string? Nome { get; set; }

        public static List<ExoPlaneta> GetExoPlanetas()
        {

            /* Forma 1 de adicionar itens em uma lista */
            var itensList = new List<ExoPlaneta>();
            //itensList.Add(new ExoPlaneta { Nome = "Proxima Centauri b" });
            //itensList.Add(new ExoPlaneta { Nome = "Kleper 186-f" });
            //itensList.Add(new ExoPlaneta { Nome = "Gliesi 1061-c" });
            //return itensList;

            /* Forma 2 de adicionar itens em uma lista */
            return new List<ExoPlaneta>()
            {
                new ExoPlaneta() {Nome = "Proxima Centauri b"},
                new ExoPlaneta() {Nome = "Kleper 186-f"},
                new ExoPlaneta() {Nome = "Gliesi 1061-c"},
            };
        }
    }
}
