using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercicios
{
    public abstract class ArquivoBase
    {
        public virtual void Nome()
        {
            Console.WriteLine("Definir o nome do arquivo");
        }
    }
}
