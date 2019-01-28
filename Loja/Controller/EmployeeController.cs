using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using Loja.Model;

namespace Loja.Controller
{
    public class EmployeeController
    {

        //Método de cadastro do funcionario, passando um funcionário como parametro
        public void CadastrarFuncionario(Employee funcionario)
        {
            //limpando conexão
            SqlConnection conexao = null;

            try
            {
                //abrindo conexão
                conexao = ConectarBanco.GetConexao();

                //criação da string com o comando SQL
                string sql = "INSERT INTO tbFuncionario (nome, rg, cpf, cargo, endereco, bairro, telefone, dataDeNascimento) " +
                    "VALUES (@nome, @rg, @cpf, @cargo, @endereco, @bairro, @telefone, @dataDeNascimento)";

                //criação do comando SQL
                SqlCommand cmd = new SqlCommand(sql, conexao);


                //Adicionando os parametros para o comando
                cmd.Parameters.AddWithValue("@nome", funcionario.Nome);
                cmd.Parameters.AddWithValue("@rg", funcionario.Rg);
                cmd.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                cmd.Parameters.AddWithValue("@cargo", funcionario.Cargo);
                cmd.Parameters.AddWithValue("@endereco", funcionario.Endereco);
                cmd.Parameters.AddWithValue("@bairro", funcionario.Bairro);
                cmd.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                cmd.Parameters.AddWithValue("@dataDeNascimento", funcionario.DataNascimento);

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


        //Método para listar os funcionarios, trazendo todos os funcionarios do banco de dados em um lista de funcionarios
        public List<Employee> ListarFuncionarios()
        {
            //limpando conexão       
            SqlConnection conexao = null;

            try
            {
                //conexão com o banco
                conexao = ConectarBanco.GetConexao();

                //string com o comando SQL
                string sql = "SELECT * FROM tbFuncionario";

                //criação do comando sql
                SqlCommand cmd = new SqlCommand(sql, conexao);

                //execução para a leitura de dados do comando
                SqlDataReader dr = cmd.ExecuteReader();

                //instanciação de lista de funcionarios
                List<Employee> listaFuncionario = new List<Employee>();


                //Enquanto houver registros adicionará funcionarios a lista
                while (dr.Read())
                {
                    //instancia novo funcionario com os dados vindos do banco
                    Employee funcionario = new Employee
                    {
                        IdFuncionario = Convert.ToInt16(dr["idFuncionario"]),
                        Nome = dr["Nome"].ToString(),
                        Rg = dr["Rg"].ToString(),
                        Cpf = dr["Cpf"].ToString(),
                        Cargo = dr["Cargo"].ToString(),
                        Endereco = dr["Endereco"].ToString(),
                        Bairro = dr["Bairro"].ToString(),
                        Telefone = dr["Telefone"].ToString(),
                        DataNascimento = Convert.ToDateTime(dr["DataDeNascimento"])
                    };
                    //adiciona o funcionário na lista
                    listaFuncionario.Add(funcionario);
                }
                //retorna a lista de funcionarios preenchida
                return listaFuncionario;
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

        //Método para editar um funcionário, passando um funcionário como parametro
        public void EditarFuncionario(Employee funcionario)
        {
            //limpando a conexão
            SqlConnection conexao = null;
            try
            {
                //conexão com o banco
                conexao = ConectarBanco.GetConexao();

                //criação da string com o comando SQL
                string sql = "UPDATE tbFuncionario SET Nome = @nome, Rg = @rg, cpf = @cpf, cargo = @cargo, endereco = @endereco, bairro = @bairro, telefone = @telefone, dataDeNascimento = @dataDeNascimento WHERE IdFuncionario = @IdFuncionario";


                //criação do comando SQL
                SqlCommand cmd = new SqlCommand(sql, conexao);

                //Adição dos parametros para o comando
                cmd.Parameters.AddWithValue("@IdFuncionario", funcionario.IdFuncionario);
                cmd.Parameters.AddWithValue("@nome", funcionario.Nome);
                cmd.Parameters.AddWithValue("@rg", funcionario.Rg);
                cmd.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                cmd.Parameters.AddWithValue("@cargo", funcionario.Cargo);
                cmd.Parameters.AddWithValue("@endereco", funcionario.Endereco);
                cmd.Parameters.AddWithValue("@bairro", funcionario.Bairro);
                cmd.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                cmd.Parameters.AddWithValue("@dataDeNascimento", funcionario.DataNascimento);

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

        //método para excluir um funcionário, passando o ID do funcionário
        public Boolean ExcluirFuncionario(int id)
        {
            //limpando a conexão
            SqlConnection conexao = null;

            try
            {
                //Abrindo a conexão
                conexao = ConectarBanco.GetConexao();

                //criação do a string SQL
                string sql = "delete from tbFuncionario WHERE IdFuncionario = @IdFuncionario";

                //criação do comando SQL
                SqlCommand cmd = new SqlCommand(sql, conexao);

                //adição do parametro para o comando sql
                cmd.Parameters.AddWithValue("@IdFuncionario", id);

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


        //Método para buscar um funcionário a partir do nome
        public DataTable BuscaFuncionario(String nome)
        {
            //limpar conexão
            SqlConnection conexao = null;
            try
            {
                //abrir Conexão
                conexao = ConectarBanco.GetConexao();

                //criação da string com o comando SQL
                string sql = "SELECT * FROM tbFuncionario where Nome like @nome";

                //criação do comando
                SqlCommand cmd = new SqlCommand(sql, conexao);

                //adição do parametro do nome (com % para buscar o nome todo)
                cmd.Parameters.AddWithValue("@nome", nome + "%");

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

        //Método para buscar funcionario a partir de seu ID
        public Employee BuscaFuncionario(int idFuncionario)
        {
            //limpar conexão
            SqlConnection conexao = null;
            try
            {
                //conectar com o banco
                conexao = ConectarBanco.GetConexao();

                //criar string com o SQL
                string sql = "SELECT * FROM tbFuncionario where IdFuncionario = @IdFuncionario";

                //criação do comando sql
                SqlCommand cmd = new SqlCommand(sql, conexao);

                //adição dos parametros para o comando
                cmd.Parameters.AddWithValue("@IdFuncionario", idFuncionario);

                //ler os dados do comando
                SqlDataReader dr = cmd.ExecuteReader();

                //se ler/encontrar o funcionário
                if (dr.Read())
                {
                    //instancia novo funcionário com os dados vindos do banco
                    Employee funcionario = new Employee
                    {
                        IdFuncionario = Convert.ToInt16(dr["IdFuncionario"]),
                        Nome = dr["Nome"].ToString(),
                        Rg = dr["Rg"].ToString(),
                        Cpf = dr["Cpf"].ToString(),
                        Cargo = dr["Cargo"].ToString(),
                        Endereco = dr["Endereco"].ToString(),
                        Bairro = dr["Bairro"].ToString(),
                        Telefone = dr["Telefone"].ToString(),
                        DataNascimento = Convert.ToDateTime(dr["DataDeNascimento"])
                    };

                    //retorna o funcionario
                    return funcionario;
                }

                //retorna nada
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




