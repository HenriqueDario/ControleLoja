using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Model
{
    public class Funcionario
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
    }
}
