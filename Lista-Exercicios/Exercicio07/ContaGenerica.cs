using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Exercicios.Exercicio07
{
    public class ContaGenerica
    {
        public string? Banco { get; private set; }
        public string? Agencia { get; private set; }
        public string? Conta { get; private set; }
        public int Saldo { get; private set; }

        public ContaGenerica(string? banco, string? agencia, string? conta, decimal SaldoInicial = 0)
        {
            Banco = banco;
            Agencia = agencia;
            Conta = conta;
            Saldo = (int)SaldoInicial;
        }

        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Saldo += (int)valor;
                Console.WriteLine($"Depósito de R${valor} realizado com sucesso.");
            }
        }

        public void Sacar(decimal valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= (int)valor;
                Console.WriteLine($"Saque de R${valor} realizado com sucesso.");
            }
        }

        internal void Exibir()
        {
            Console.WriteLine($"Banco: {Banco}\nAgência: {Agencia}\nConta: {Conta}\nSaldo: {Saldo:C}");
        }
    }
}