using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lista_Exercicios.Exercicio07;

namespace Lista_Exercicios.Exercicio08
{
    internal class ContaCorrente
    {
        public class ContaCorrente : ContaGenerica
        {
            public ContaCorrente(string? banco, string? agencia, string? conta, decimal saldoInicial, decimal limite) : base(banco, agencia, conta, saldoInicial)
            {
                this.Limite = limite;
            }
            public decimal Limite { get; set; }
        }
    }
}
