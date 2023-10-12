using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrata1
{
    public abstract class Forma
    {
        public string? Cor { get; set; }
        public double Area { get; set; }
        public double Perimetro { get; set; }

        /* Métodos abstratos */
        public abstract void CalcularArea();
        public abstract void CalcularPerimetro();

        /* Método comum */
        public string Descricao()
        {
            return "Metdo comum da classe abstrata Forma";
        }

    } 
}
