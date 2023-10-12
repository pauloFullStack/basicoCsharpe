using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Triangulo : Figura
    {
        public override void Desenha()
        {
            Console.WriteLine("Desenhando um triangulo...");
            base.Desenha();
        }
    }
}
