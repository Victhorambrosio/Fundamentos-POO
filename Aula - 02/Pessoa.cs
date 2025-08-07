using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula___02
{
    // Exemplo da Classe Pessoa
    public class Pessoa
    {

        //Atributos da classe Pessoa
        public string Nome { get; set; }

        public int CPF { get; set; }

        public DateOnly? DataNascimento { get; set; }

        //Metodo da classe Pessoa
        public virtual void Apresentar()  // Método virtual para permitir sobrecarga em classes filhas
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, meu CPF é {CPF} e eu nasci em {DataNascimento}");
        }

        //Construtor da classe Pessoa

        public Pessoa() { }

        // Sobrecarga do construtor da classe Pessoa
        public Pessoa(string nome, int cpf, DateOnly dataNascimento)
        {
            Nome = nome;
            CPF = cpf;
            DataNascimento = dataNascimento;
        }
    }
}
