using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HerancaExercicio
{
    public class Contas : Cliente
    {

        private double _saldo;
        protected double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }
        private int TipoConta { get; set; }
        public Contas() { }

        public Contas(string nome, int numeroConta)
        {
            Nome = nome;
            NumeroConta = numeroConta;
            TipoDeConta();
        }

        private void TipoContaCorrente()
        {
            TipoConta = 1;
            Menu();
        }

        private void TipoContaDePoupanca()
        {
            TipoConta = 2;
            Menu();
        }

        private void TipoContaInvestimento()
        {
            TipoConta = 3;
            Menu();
        }

        protected void Menu()
        {
            PrintsTela($"\nOla {Nome}, \nEscolha a operação\n1 - Exibir Saldo\n2 - Sacar\n3 - Deposito\n0 - Sair");
            int operacao = Convert.ToInt32(Console.ReadLine());
            if (operacao == 1)
            {
                ExibirSaldo();
            }
            else if (operacao == 2)
            {
                Sacar();
            }
            else if (operacao == 3)
            {
                Depositar();
            }
            else if (operacao == 0)
            {
                PrintsTela("\nClique duas veze em qualquer tecla para sair...");
            }
            else
            {
                PrintsTela("\nEssa operação não existe!");
            }
        }

        protected static void PrintsTela(string texto)
        {
            Console.WriteLine(texto);
        }

        protected virtual void ExibirSaldo()
        {

            if (TipoConta == 1)
            {
                ContaCorrente obj = new ContaCorrente();
                obj.Saldo = 10.0;
                obj.ExibirSaldo();
            }
            else if (TipoConta == 2)
            {
                ContaPoupanca obj = new ContaPoupanca();
                obj.Saldo = 20.0;
                obj.ExibirSaldo();
            }
            else if (TipoConta == 3)
            {
                ContaInvestimento obj = new ContaInvestimento();
                obj.Saldo = 30.0;
                obj.ExibirSaldo();
            }


        }

        protected virtual void Sacar()
        {
            if (TipoConta == 1)
            {
                ContaCorrente obj = new ContaCorrente();
                obj.Sacar();
            }
            else if (TipoConta == 2)
            {
                ContaPoupanca obj = new ContaPoupanca();
                obj.Sacar();
            }
            else if (TipoConta == 3)
            {
                ContaInvestimento obj = new ContaInvestimento();
                obj.Sacar();
            }
        }

        protected virtual void Depositar()
        {

            if (TipoConta == 1)
            {
                ContaCorrente obj = new ContaCorrente();
                obj.Depositar();
            }
            else if (TipoConta == 2)
            {
                ContaPoupanca obj = new ContaPoupanca();
                obj.Depositar();
            }
            else if (TipoConta == 3)
            {
                ContaInvestimento obj = new ContaInvestimento();
                obj.Depositar();
            }
        }

        private void TipoDeConta()
        {
            if (NumeroConta == 1)
            {
                TipoContaCorrente();
            }
            else if (NumeroConta == 2)
            {
                TipoContaDePoupanca();
            }
            else if (NumeroConta == 3)
            {
                TipoContaInvestimento();
            }
            else
            {
                PrintsTela("\nEsse tipo de conta não existe!");
            }
        }


    }
}
