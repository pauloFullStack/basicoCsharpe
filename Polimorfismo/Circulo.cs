using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Circulo : Figura
    {
        public override void Desenha()
        {
            Console.WriteLine("Desenhando um circulo...");
        }
    }
}
