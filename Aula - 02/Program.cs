using Aula___02;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Criando um Objeto");

        //Instanciando um objeto da classe Pessoa
        Pessoa pessoa1 = new Pessoa();  //Objeto vazio
        pessoa1.Nome = "João";
        pessoa1.CPF = 123456789;
        pessoa1.DataNascimento = new DateOnly(1990, 1, 1);

        //Apresentando o objeto pessoa1
        pessoa1.Apresentar();

        //Instanciando um objeto da classe Pessoa usando o construtor com parâmetros

        Pessoa pessoa2 = new Pessoa("Maria", 987654321, new DateOnly(1995, 5, 15));
        pessoa2.Apresentar();

        Console.WriteLine
            ("\n--------------------------");

        Console.WriteLine("Criando um Objeto Aluno Herdado  de Pessoa");
        // Instanciando um objeto da classe Aluno
        Aluno aluno1 = new Aluno();
        // Atibutos herdados da classe Pessoa
        aluno1.Nome = "Carlos";
        aluno1.CPF = 111222333;
        aluno1.DataNascimento = new DateOnly(2000, 3, 20);
        // Atributos da classe Aluno
        aluno1.Curso = "Engenharia";
        aluno1.Matricula = 2023001;

        // Apresentando o objeto aluno1
        aluno1.Apresentar();

        Console.WriteLine("\n--------------------------");
        Console.WriteLine("Criando um Objeto Professor Herdado de Pessoa");

        // Instanciando um objeto da classe Professor
        Professor professor1 = new Professor();
        professor1.Nome = "Dr. Smith";
        professor1.CPF = 444555666;
        professor1.DataNascimento = new DateOnly(1975, 7, 30);
        professor1.Especialidade = "Matemática";
        professor1.Registro = 12345;
        professor1.Salario = 7500.00;

        // Apresentando o objeto professor1
        professor1.Apresentar();

        // Encapsulamento: é o principio de esconder os detalhes internos de uma classe e expor apenas o necessário através de métodos públicos.
    }
}