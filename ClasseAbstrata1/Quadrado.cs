using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrata1
{
    public class Quadrado : Forma
    {

        public double Lado { get; set; }

        public override void CalcularArea()
        {
            Area = Lado * Lado;
        }

        public override void CalcularPerimetro()
        {
            Perimetro = 4 * Lado;
        }
    }
}
