using System;
using System.Collections.Generic;
using System.Text;

namespace Lista01Exercicio06.Entities
{
 public class FUncionario
    {
        public Guid IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }

    }
}
