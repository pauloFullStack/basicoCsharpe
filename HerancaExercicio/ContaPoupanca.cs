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
            Saldo -= valorSaque;
            PrintsTela($"Saldo atual = {Saldo}");
            Menu();
        }
        protected override void Depositar() => PrintsTela("Depositar Conta Poupança");
    }
}
