using Lista01Exercicio06.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lista01Exercicio06.Repositories
{
  public   class FuncionarioRepository
    {
        public void ExportarDados(FUncionario funcionario)
        {
            var arquivo = $"C:\\Temp\\funcionario_{ funcionario.IdFuncionario}.txt";
            
            
            var streamWriter = new StreamWriter(arquivo);

            streamWriter.WriteLine("Id........................: " + funcionario.IdFuncionario);
            streamWriter.WriteLine("Nome......................: " + funcionario.Nome);
            streamWriter.WriteLine("Cpf.......................: " + funcionario.Cpf);
            streamWriter.WriteLine("Matricula.................: " + funcionario.Matricula);
            streamWriter.WriteLine("Data de Admissão..........: " + funcionario.DataAdmissao);
            streamWriter.WriteLine("Cargo.....................: " + funcionario.Cargo);
            streamWriter.WriteLine("Salário...................: " + funcionario.Salario);

            streamWriter.Close();

        }   
    }   
}
