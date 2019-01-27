using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using Loja.Model;
using System.Data;

namespace Loja.Controller
{
    public class ProductController
    {

        //método para cadastrar produto no banco de dados, passando o produto como parametro
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

        //Método para listar os produtos cadastrados no banco de dados
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
                    //instancia novo produto pegando e convertando cada campo do banco de dados
                    Product produto = new Product
                    {
                        IdProduto = Convert.ToInt16(dr["IdProduto"]),
                        Nome = dr["Nome"].ToString(),
                        Quantidade = Convert.ToInt16(dr["Quantidade"]),
                        Preco = Convert.ToDecimal(dr["Preco"]),
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

        //Método para editar o produto
        public void EditarProduto(Product prod)
        {
            //limpando a conexão
            SqlConnection conexao = null;
            try
            {
                //conexão com o banco
                conexao = ConectarBanco.GetConexao();

                //criação da string com o comando SQL
                string sql = "UPDATE tbProduto SET Nome = @Nome, Quantidade = @Quantidade, Preco = @Preco, Lote = @Lote, Fabricacao = @Fabricacao, Validade = @Validade WHERE IdProduto = @IdProduto";


                //criação do comando SQL
                SqlCommand cmd = new SqlCommand(sql, conexao);

                //Adicionando os parametros para o comando
                cmd.Parameters.AddWithValue("@Nome", prod.Nome);
                cmd.Parameters.AddWithValue("@Quantidade", prod.Quantidade);
                cmd.Parameters.AddWithValue("@Preco", prod.Preco);
                cmd.Parameters.AddWithValue("@Lote", prod.Lote);
                cmd.Parameters.AddWithValue("@Fabricacao", prod.Fabricacao);
                cmd.Parameters.AddWithValue("@Validade", prod.Validade); ;

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

        //método para excluir um produto, passando o ID
        public Boolean ExcluirProduto(int idProduto)
        {
            //limpando a conexão
            SqlConnection conexao = null;

            try
            {
                //Abrindo a conexão
                conexao = ConectarBanco.GetConexao();

                //criação do a string SQL
                string sql = "delete from tbProduto WHERE IdProduto = @IdProduto";

                //criação do comando SQL
                SqlCommand cmd = new SqlCommand(sql, conexao);

                //adição do parametro para o comando sql
                cmd.Parameters.AddWithValue("@IdProduto", idProduto);

                //execução do comando
                cmd.ExecuteNonQuery();

                //Retorna verdadeiro (caso de tudo certo)
                return true;
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

        //Método para buscar um produto a partir do nome
        public DataTable BuscarProduto(String nomeProduto)
        {
            //limpar conexão
            SqlConnection conexao = null;
            try
            {
                //abrir Conexão
                conexao = ConectarBanco.GetConexao();

                //criação da string com o comando SQL
                string sql = "SELECT * FROM tbProduto where Nome like @Nome";

                //criação do comando
                SqlCommand cmd = new SqlCommand(sql, conexao);

                //adição do parametro do nome (com % para buscar o nome todo)
                cmd.Parameters.AddWithValue("@Nome", nomeProduto + "%");

                //guardar todo o select do comando sql
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //criar data table
                DataTable dt = new DataTable();

                //preencher a data table com os dados SQL
                adapter.Fill(dt);

                //retornar a data table
                return dt;
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

        //Método para buscar um produto a partir do ID
        public Product BuscarProduto(int idProduto)
        {
            //limpar conexão
            SqlConnection conexao = null;

            try
            {
                //conectar com o banco
                conexao = ConectarBanco.GetConexao();

                //string com o comando SQL
                string sql = "SELECT * FROM tbProduto where IdProduto = @IdProduto";

                //criação do comando sql
                SqlCommand cmd = new SqlCommand(sql, conexao);

                //adição dos parametros para o comando
                cmd.Parameters.AddWithValue("@IdProduto", idProduto);

                //ler os dados do comando
                SqlDataReader dr = cmd.ExecuteReader();

                //se ler/encontrar o produto
                if (dr.Read())
                {
                    Product prod = new Product
                    {
                        IdProduto = Convert.ToInt16(dr["IdProduto"]),
                        Nome = dr["Nome"].ToString(),
                        Quantidade = Convert.ToInt16(dr["Quantidade"]),
                        Preco = Convert.ToDecimal(dr["Preco"]),
                        Lote = dr["Lote"].ToString(),
                        Fabricacao = Convert.ToDateTime(dr["Fabricacao"]),
                        Validade = Convert.ToDateTime(dr["Validade"])
                    };

                    //retorna o produto
                    return prod;
                }
                
                //não retorna nada
                return null;
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
