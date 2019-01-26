using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Model
{
    public class Product
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public string Lote { get; set; }
        public DateTime Fabricacao { get; set; }
        public DateTime Validade { get; set; }


        public Product()
        {

        }

        public Product(string nome, int quantidade, decimal preco, DateTime fabricacao, DateTime validade, string lote)
        {
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;
            Fabricacao = fabricacao;
            Validade = validade;
            Lote = lote;
        }
    }
}
