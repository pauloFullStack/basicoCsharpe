using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateMulticast
{
    internal class Exemplo
    {
        public static void Metodo1(string mensagem)
        {
            Console.WriteLine($"Método 1: {mensagem}");
        }

        public static void Metodo2(string mensagem)
        {
            Console.WriteLine($"Método 2: {mensagem}");
        }

        public static void Metodo3(string mensagem)
        {
            Console.WriteLine($"Método 3: {mensagem}");
        }
    }
}
