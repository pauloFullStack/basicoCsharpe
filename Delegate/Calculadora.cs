using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Calculadora
    {
        public static float OperacoesAritmeticas(float n1, float n2, char typeOperation)
        {
            if (typeOperation == '+') return n1 + n2;
            else if (typeOperation == '-') return n1 - n2;
            else if (typeOperation == '/') return n1 / n2;
            else if (typeOperation == '*') return n1 * n2;
            else return 0;
        }

        public static float Somar(float n1, float n2)
        {
            return n1 + n2;
        }

        public static float Subtrair(float n1, float n2)
        {
            return n1 - n2;
        }

        public static float Multiplicar(float n1, float n2)
        {
            return n1 * n2;
        }

        public static float Dividir(float n1, float n2)
        {
            return n1 / n2;
        }

    }
}
