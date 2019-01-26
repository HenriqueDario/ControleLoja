using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using Loja.Model;

namespace Loja.Controller
{
    public class ProductController
    {

        //método para cadastrar produto, passando o produto como parametro
        public void CadastroProduto(Product prod)
        {
            //limpando conexão
            SqlConnection conexao = null;

            try
            {
                //abrindo conexão
                conexao = ConectarBanco.GetConexao();

                //criação da string com o comando SQL
                string sql = "INSERT INTO tbProduto (Nome, Quantidade, Preco, Fabricacao, Validade, Lote) " +
                    "VALUES (@Nome, @Quantidade, @Preco, @Fabricacao, @Validade, @Lote)";

                //criação do comando SQL
                SqlCommand cmd = new SqlCommand(sql, conexao);


                //Adicionando os parametros para o comando
                cmd.Parameters.AddWithValue("@Nome", prod.Nome);
                cmd.Parameters.AddWithValue("@Quantidade", prod.Quantidade);
                cmd.Parameters.AddWithValue("@Preco", prod.Preco);
                cmd.Parameters.AddWithValue("@Lote", prod.Lote);
                cmd.Parameters.AddWithValue("@Fabricacao", prod.Fabricacao);
                cmd.Parameters.AddWithValue("@Validade", prod.Validade);

                //execução do comando
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                }
            }
        }

        public List<Product> ListarProdutos()
        {
            //limpando conexão       
            SqlConnection conexao = null;

            try
            {
                //conexão com o banco
                conexao = ConectarBanco.GetConexao();

                //string com o comando SQL
                string sql = "SELECT * FROM tbProduto";

                //criação do comando sql
                SqlCommand cmd = new SqlCommand(sql, conexao);

                //execução para a leitura de dados do comando
                SqlDataReader dr = cmd.ExecuteReader();

                //instanciação de lista de funcionarios
                List<Product> listaProdutos = new List<Product>();


                //Enquanto houver registros adicionará funcionarios a lista
                while (dr.Read())
                {
                    Product produto = new Product
                    {
                        IdProduto = Convert.ToInt16(dr["IdProduto"]),
                        Nome = dr["Nome"].ToString(),
                        Quantidade = int.Parse(dr["Quantidade"].ToString()),
                        Preco = decimal.Parse(dr["Preco"].ToString()),
                        Lote = dr["Lote"].ToString(),
                        Fabricacao = Convert.ToDateTime(dr["Fabricacao"]),
                        Validade = Convert.ToDateTime(dr["Validade"])
                    };
                    //adiciona o produto a lista
                    listaProdutos.Add(produto);
                }
                //retorna a lista de funcionarios preenchida
                return listaProdutos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                }
            }
        }
    }        
    
}
