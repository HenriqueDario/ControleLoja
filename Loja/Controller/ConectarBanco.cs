using System;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Controller
{
    public class ConectarBanco
    {
        //Método para conexão com o banco

        public static SqlConnection GetConexao()
        {
            //variavel de conexão sql
            SqlConnection Con = new SqlConnection
            {
                ConnectionString = "Data Source=DÁRIO-PC;Initial Catalog=dbLoja;Integrated Security=True"
            };
            //tentar abrir conexão
            try
            {
                //Checar o estado da conexão
                if (Con.State == System.Data.ConnectionState.Closed)
                {
                    //abre a conexão
                    Con.Open();
                }
                //retorna a conexão
                return Con;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
