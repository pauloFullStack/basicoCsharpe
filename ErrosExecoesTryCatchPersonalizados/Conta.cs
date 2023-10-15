using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrosExecoesTryCatchPersonalizados
{
    internal class Conta
    {

        public Conta(int numero, string? titular, decimal saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public int Numero { get; set; }
        public string? Titular { get; set; }
        public decimal Saldo { get; set; }


        public decimal Depositar(decimal valor)
        {
            Console.WriteLine($"Depositou: {valor}");
            return Saldo += valor;
        }


        public decimal Sacar(decimal valor)
        {
            Console.WriteLine($"Sacou: {valor}");
            if (Saldo > 0)
                throw new SaldoInsuficienteException(valor, Saldo);

            Saldo -= valor;
            return Saldo;
        }

        public override string ToString()
        {
            return $"Conta : {Numero} : {Titular} - Saldo =  {Saldo}";
        }

    }
}
