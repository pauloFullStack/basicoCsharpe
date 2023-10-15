using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Pedidos
    {
        public Pedidos() { }
        public Pedidos(int numero, double valor)
        {
            Numero = numero;
            Valor = valor;
        }

        public int Numero { get; set; }
        public double Valor { get; set; }

    }
}
