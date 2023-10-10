using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores
{
    class Time
    {
        string[] valor = new string[10];

        public string this[int i]
        {
            get
            {
                if (i >= 0 && i < valor.Length)
                {
                    return valor[i];
                }

                return valor[0] != null ? valor[0] : "Erro" ;
            }

            set
            {
                if (i >= 0 && i < valor.Length)
                {
                    valor[i] = value;
                }

            }
        }

    }
}
