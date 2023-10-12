using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Figura
    {
        public virtual void Desenha()
        {
            Console.WriteLine("Executando Desenha na classe base");
        }
    }
}
