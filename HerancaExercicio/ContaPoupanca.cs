using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaExercicio
{
    public class ContaPoupanca : Contas
    {
        protected override void ExibirSaldo()
        {
            PrintsTela($"Saldo Conta Poupança = {Saldo}");
            Menu();
        }
        protected override void Sacar()
        {
            PrintsTela("Digite o valor para saque - Conta Poupança");
            double valorSaque = Convert.ToDouble(Console.ReadLine());
            if (Saldo > valorSaque)
            {
                Saldo -= valorSaque;
                PrintsTela($"Saldo atual = {Saldo}");
            }
            else
            {
                PrintsTela($"Saldo insuficiente para saque");
            }
            Menu();
        }
        protected override void Depositar()
        {
            PrintsTela("Digite o valor do Deposito - Conta Poupança");
            double valorDeposito = Convert.ToDouble(Console.ReadLine());
            double calculaJuros = ((0.5 / 100) * valorDeposito) * valorDeposito;
            Saldo += valorDeposito + calculaJuros;
            PrintsTela($"Saldo atual = {Saldo}");
            Menu();
        }
    }
}
