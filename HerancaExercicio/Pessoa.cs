using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaExercicio
{
    public class Pessoa
    {

        private string? _nome;
        protected string? Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }        

    }
}
