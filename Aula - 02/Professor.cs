using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula___02
{

    // Classe Professor que herda da classe Pessoa
    public class Professor : Pessoa
    {
        public string? Especialidade { get; set; }
        public int Registro { get; set; }
        public double Salario { get; set; }

        // Sobrecarga do método Apresentar para a classe Pessoa (Polimorfismo)

        public override void Apresentar()  // Override faz a sobrecarga em classes filhas
        {
            base.Apresentar(); // Chama o método Apresentar da classe base (Pessoa)
            Console.WriteLine($"Olá, sou o professor {Nome}, sou especialista em {Especialidade}, meu registro é {Registro} e meu salário é {Salario:C}"); // Adiciona informações específicas da classe Professor
        }
    }
}
