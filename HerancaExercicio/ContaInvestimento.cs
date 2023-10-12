using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaExercicio
{
    public class ContaInvestimento : Contas
    {
        protected override void ExibirSaldo()
        {
            PrintsTela($"Saldo Conta Investimento = {Saldo}");
            Menu();
        }
        protected override void Sacar()
        {
            PrintsTela("Digite o valor para saque - Conta Investimento");
            double valorSaque = Convert.ToDouble(Console.ReadLine());
            if (Saldo > valorSaque)
            {
                double calculaJuros = ((0.1 / 100) * valorSaque) * valorSaque;
                Saldo -= valorSaque - calculaJuros;
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
            PrintsTela("Digite o valor do Deposito - Conta Investimento");
            double valorDeposito = Convert.ToDouble(Console.ReadLine());
            double calculaJuros = ((0.9 / 100) * valorDeposito) * valorDeposito;
            Saldo += valorDeposito + calculaJuros;
            PrintsTela($"Saldo atual = {Saldo}");
            Menu();
        }
    }
}
