using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Loja.Controller;

namespace Loja.View
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        

        //ao clicar na picture box "X"
        private void PbExit_Click(object sender, EventArgs e)
        {
            //fecha a janela
            this.Close();
        }

        //ao clicar no botão login
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //checa o método de verificar login é verdadeiro
            if (VerificaLogin())
            {

                //instancia a janela principal
                Principal FormPrincipal = new Principal();
                //esconde a tela atual e abre a proxima
                this.Hide();

                //abre a janela principal
                FormPrincipal.ShowDialog();
                //após fechar a janela principal fecha a aplicação
                this.Close();
            }
            else
                //mostra mensagem para o usuário
                MessageBox.Show("Login ou senha invalidos", "ERRO");


        }

        //método para verificar o login
        public Boolean VerificaLogin()
        {
            //instancia uma conexão como null
            SqlConnection conexao = null;
            try
            {
                //conecta com o banco
                conexao = ConectarBanco.GetConexao();

                //instancia uma string com um comando sql
                string sql = "SELECT * FROM tbLogin WHERE Login = @login and Senha = @senha";

                //cria um comando sql passando a string e a conexão
                SqlCommand cmd = new SqlCommand(sql, conexao);

                //adiciona os parametros para o comando
                cmd.Parameters.AddWithValue("@login", TxtLogin.Text);
                cmd.Parameters.AddWithValue("@senha", TxtSenha.Text);

                //cria um dataReader recebendo o comando sql
                SqlDataReader dr = cmd.ExecuteReader();

                //checa se os dados foram encontrados e retorna verdadeiro
                if (dr.Read())
                    return true;

                
                return false;
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

        //ao pressionar uma tecla no campo da senha
        private void TxtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            //checa se a tecla era o Enter
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                //checa o login
                if (VerificaLogin())
                {

                    //instancia a janela principal
                    Principal FormPrincipal = new Principal();
                    //esconde a tela atual e abre a proxima
                    this.Hide();

                    //abre janela principal
                    FormPrincipal.ShowDialog();
                    //após fechar a janela principal fecha a aplicação
                    this.Close();
                }
                else
                    // mostra uma mensagem para o usuário
                    MessageBox.Show("Login ou senha invalidos", "ERRO");

            }


        }

        //ao pressionar uma tecla no campo de login
        private void TxtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            //checa se a tecla é o enter
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                //checa se o resultado do método verificar login é verdadeiro
                if (VerificaLogin())
                {
                    //instancia janela principal
                    Principal FormPrincipal = new Principal();

                    //esconde essa janela
                    this.Hide();
                    //mostra a janela do form principal
                    FormPrincipal.ShowDialog();
                    //fecha essa janela
                    this.Close();
                }
                else
                    //mostra mensagem para o usuário
                    MessageBox.Show("Login ou senha invalidos", "ERRO");

            }
        }

        //ao clicar na lblLogin
        private void LblLogin_Click(object sender, EventArgs e)
        {
            //passa o componente ativo para o txtLogin
            this.ActiveControl = TxtLogin;

            //inicia o timer de entrada no login
            TimerEntrarLogin.Start();
        }

        //ao clicar na label LblSenha
        private void LblSenha_Click(object sender, EventArgs e)
        {
            //Passa o componente ativo para o TxtSenha
            this.ActiveControl = TxtSenha;

            //Inicia o timer de entrada no campo da senha
            TimerEntrarSenha.Start();
        }

        //timer de entrada no login
        private void TimerEntrarLogin_Tick(object sender, EventArgs e)
        {
            //checa se o tamanho do panel é maior ou igual a 240
            if (PnBlueLogin.Width >= 240)
                //para o timer
                TimerEntrarLogin.Stop();
            else
            {
                //aumenta o tamano do panel
                PnBlueLogin.Width += 24;
                //muda a posição do panel
                PnBlueLogin.Location = new Point(PnBlueLogin.Location.X - 4, PnBlueLogin.Location.Y);
            }
            //checa a localização do LblLogin
            if (LblLogin.Location.Y > 90)
            {
                //troca a font do LblLogin
                LblLogin.Font = new Font("Arial", 11);

                //troca a cor da fonte da LblLogin
                LblLogin.ForeColor = System.Drawing.SystemColors.MenuHighlight;

                //troca a localização da LblLogin
                LblLogin.Location = new Point(LblLogin.Location.X, LblLogin.Location.Y - 4);
            }
        }



        //timer de entrar no campo da senha
        private void TimerEntrarSenha_Tick(object sender, EventArgs e)
        {
            //checa o tamanho do panel
            if (PnBlueSenha.Width >= 240)
                //para o timer
                TimerEntrarSenha.Stop();
            else
            {
                //aumenta o tamanho do panel
                PnBlueSenha.Width += 24;
                //troca a posição do panel
                PnBlueSenha.Location = new Point(PnBlueSenha.Location.X - 4, PnBlueSenha.Location.Y);
            }

            //checa a localização do LblSenha
            if (LblSenha.Location.Y > 155)
            {
                //troca a fonte do LblSenha
                LblSenha.Font = new Font("Arial", 11);

                //troca a cor do LblSenha
                LblSenha.ForeColor = System.Drawing.SystemColors.MenuHighlight;

                //Troca a localização do LblSenha
                LblSenha.Location = new Point(LblSenha.Location.X, LblSenha.Location.Y - 4);
            }
        }


        //ao sair do TxtLogin
        private void TxtLogin_Leave(object sender, EventArgs e)
        {
            //checa se o TxtLogin está vázio
            if (string.IsNullOrWhiteSpace(TxtLogin.Text))
            {
                //inicia o timer de sair do login
                TimerSairLogin.Start();

                //troca a posição do panel azul
                this.PnBlueLogin.Location = new System.Drawing.Point(145, 132);

                //troca o tamanho do panel azul
                PnBlueLogin.Width = 0;

            }
        }

        //ao sair do campo de senha
        private void TxtSenha_Leave(object sender, EventArgs e)
        {
            //checa se o campo de senha está vázio
            if (string.IsNullOrWhiteSpace(TxtSenha.Text))
            {
                //inicia o timer de saída do campo senha
                TimerSairSenha.Start();

                //muda a localização do Panel azul
                this.PnBlueSenha.Location = new System.Drawing.Point(145, 195);

                //muda o tamanho do panel Azul
                PnBlueSenha.Width = 0;

            }
        }

        //timer de saída do login
        private void TimerSairLogin_Tick(object sender, EventArgs e)
        {
            //checa a localização da LblLogin
            if (LblLogin.Location.Y == 110)
                //para o Timer
                TimerSairLogin.Stop();
            else
            {
                //troca a fonte do LblLogin
                LblLogin.Font = new Font("Arial Black", 9);
                //troca a cor do LblLogin
                LblLogin.ForeColor = Color.Black;
                //troca a localização do LblLogin
                LblLogin.Location = new Point(LblLogin.Location.X, LblLogin.Location.Y + 2);

            }
        }

        //timer de saida do campo senha
        private void TimerSairSenha_Tick(object sender, EventArgs e)
        {
            //checa a localização da LblSenha
            if (LblSenha.Location.Y == 175)
                //para o timer
                TimerSairSenha.Stop();
            else
            {
                //troca a fonte do LblSenha
                LblSenha.Font = new Font("Arial Black", 9);

                //troca a cor do LblSenha
                LblSenha.ForeColor = Color.Black;

                //troca a posição do LblSenha
                LblSenha.Location = new Point(LblSenha.Location.X, LblSenha.Location.Y + 2);

            }
        }

               //ao entrar no TxtSenha
        private void TxtSenha_Enter(object sender, EventArgs e)
        {
            //inicia o timer TimerEntrarSenha
            TimerEntrarSenha.Start();
        }
        //ao entrar no TxtLogin
        private void TxtLogin_Enter(object sender, EventArgs e)
        {
            //inicia o timer TimerEntrarLogin
            TimerEntrarLogin.Start();
        }

        
        private void FormLogin_Load(object sender, EventArgs e)
        {
            //coloca o componente LblTitulo como ativo
            this.ActiveControl = LblTitulo;
        }
    }
}
