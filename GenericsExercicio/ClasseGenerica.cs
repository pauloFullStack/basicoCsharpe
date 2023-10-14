using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercicio
{
    /* Pode usar qualquer nome para o nome do tipo, a convenção é T mais no exemplo abaixo usei Paulo :) */
    internal class ClasseGenerica<Paulo>
    {
        Paulo[] obj = new Paulo[5];
        int contador = 0;

        /* Adicionar Elementos */ 
        public void Adicionar(Paulo item)
        {
            if (contador < 5)
            {
                obj[contador] = item;
            }
            contador++;
        }

        /* Indexador */
        public Paulo this[int index]
        {
            get { return obj[index]; }
            set { obj[index] = value; }
        }
    }
}
