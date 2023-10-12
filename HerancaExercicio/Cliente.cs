using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaExercicio
{
    public class Cliente : Pessoa
    {
        private int _numeroConta;
        protected int NumeroConta
        {
            get { return _numeroConta; }
            set { _numeroConta = value; }
        }

    }
}
