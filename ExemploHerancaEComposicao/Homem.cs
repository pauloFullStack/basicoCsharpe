using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHerancaEComposicao
{
    internal class Homem : Animal
    {
        private readonly ComportamentoAndar _comportamentoAndar;

        public Homem(ComportamentoAndar comportamentoAndar)
        {
            _comportamentoAndar = comportamentoAndar;
        }

        public void Locomocao()
        {
            Console.WriteLine(nameof(Homem));
            _comportamentoAndar.Andar();
        }
    }
}
