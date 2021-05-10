using Lista01Exercicio06.Entities;
using Lista01Exercicio06.Repositories;
using System;

namespace Lista01Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n CADASTRO DE FUNCIONÁRIOS");

            var funcionario = new FUncionario();

            funcionario.IdFuncionario = Guid.NewGuid();


            Console.WriteLine("\nPor favor, informe o nome do funcionário....:");
            funcionario.Nome = Console.ReadLine();

            Console.WriteLine("\nPor favor, informe o Cpf do funcionário....:");
            funcionario.Cpf = Console.ReadLine();

            Console.WriteLine("\nPor favor, informe a matricula do funcionário....:");
            funcionario.Matricula= Console.ReadLine();

            Console.WriteLine("\nPor favor, informe a data de admissão do funcionário....:");
            funcionario.DataAdmissao =DateTime.Parse( Console.ReadLine());

            Console.WriteLine("\nPor favor, informe o cargo do funcionário....:");
            funcionario.Cargo = Console.ReadLine();

            Console.WriteLine("\nPor favor, informe o salário do funcionário....:");
            funcionario.Salario = decimal.Parse(Console.ReadLine());


            Console.WriteLine("\nVERIFIQUE SE OS DADOS DO FUNCIONÁRIO ESTÃO CORRETOS");

            Console.WriteLine("Id........................: " + funcionario.IdFuncionario);
            Console.WriteLine("Nome......................: " + funcionario.Nome);
            Console.WriteLine("Cpf.......................: " + funcionario.Cpf);
            Console.WriteLine("Matricula.................: " + funcionario.Matricula);
            Console.WriteLine("Data de Admissão..........: " + funcionario.DataAdmissao);
            Console.WriteLine("Cargo.....................: " + funcionario.Cargo);
            Console.WriteLine("Salário...................: " + funcionario.Salario);



            var funcionarioRepository = new FuncionarioRepository();

            try
            {
                funcionarioRepository.ExportarDados(funcionario);
                Console.WriteLine("\n Dados gravados com SUCESSO!");
            }
            catch (Exception e)
            {
                Console.WriteLine("\nERRO: "+ e.Message);
                
            }
            Console.ReadKey();
        }
    }
}
