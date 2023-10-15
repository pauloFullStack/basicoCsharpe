using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ErrosExecoesTryCatchPersonalizados
{
    internal class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException() { }

        public SaldoInsuficienteException(string? message) : base(message) { }

        public SaldoInsuficienteException(string? message, Exception? innerException) : base(message, innerException) { }

        public SaldoInsuficienteException(decimal saque, decimal saldo) : base($"\nValor do saque {saque} é superior ao saldo {saldo}") { }

        //public override string Message
        //{
        //    get
        //    {
        //        return "Não existe saldo suficiente para o valor do saque";
        //    }
        //}

        //public override string HelpLink
        //{
        //    get
        //    {
        //        return "Passar URL";
        //    }
        //}

    }
}
