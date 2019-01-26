using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Model
{
    public class Employee
    {
        public int IdFuncionario { get; set; }       

        public string Nome { get; set; }

        public string Rg { get; set; }

        public string Cpf { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Cargo { get; set; }

        public string Endereco { get; set; }

        public string Bairro { get; set; }

        public string Telefone { get; set; }

        public Employee()
        {

        }

        public Employee(string nome, string rg, string cpf, DateTime dataNascimento, string cargo, string endereco, string bairro, string telefone)
        {
            Nome = nome;
            Rg = rg;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Cargo = cargo;
            Endereco = endereco;
            Bairro = bairro;
            Telefone = telefone;
        }
    }
}
