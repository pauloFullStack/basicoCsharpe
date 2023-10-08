using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresDeAcesso
{
    internal class MinhaClasse
    {
        /* Os membros abaixo não estão definidos então são private como padrão */

        int _meuCampo;

        string? MinhaPropriedade { get; set; }

        void MeuMetodo()
        {
            Console.WriteLine("Meu Metodo");
        }
    }
}
