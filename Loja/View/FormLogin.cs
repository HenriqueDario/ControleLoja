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


namespace Loja.View
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void PbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {


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
                MessageBox.Show("Login ou senha invalidos", "ERRO");


        }


        public Boolean VerificaLogin()
        {
            SqlConnection conexao = null;
            try
            {
                conexao = Controller.ConectarBanco.GetConexao();
                string sql = "SELECT * FROM tbLogin WHERE Login = @login and Senha = @senha";

                SqlCommand cmd = new SqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@login", TxtLogin.Text);
                cmd.Parameters.AddWithValue("@senha", TxtSenha.Text);

                SqlDataReader dr = cmd.ExecuteReader();
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


        private void TxtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)

            {
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
                    MessageBox.Show("Login ou senha invalidos", "ERRO");

            }


        }

        private void TxtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)

            {
                if (VerificaLogin())
                {

                    Principal FormPrincipal = new Principal();
                    this.Hide();
                    FormPrincipal.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Login ou senha invalidos", "ERRO");

            }
        }

        private void LblLogin_Click(object sender, EventArgs e)
        {
            this.ActiveControl = TxtLogin;
            TimerEntrarLogin.Start();
        }

        private void LblSenha_Click(object sender, EventArgs e)
        {
            this.ActiveControl = TxtSenha;
            TimerEntrarSenha.Start();
        }

        private void TimerEntrarLogin_Tick(object sender, EventArgs e)
        {
            if (PnBlueLogin.Width >= 240)
                TimerEntrarLogin.Stop();
            else
            {
                PnBlueLogin.Width += 24;
                PnBlueLogin.Location = new Point(PnBlueLogin.Location.X - 4, PnBlueLogin.Location.Y);
            }

            if (LblLogin.Location.Y > 90)
            {
                LblLogin.Font = new Font("Arial", 11);
                LblLogin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
                LblLogin.Location = new Point(LblLogin.Location.X, LblLogin.Location.Y - 4);
            }
        }




        private void TimerEntrarSenha_Tick(object sender, EventArgs e)
        {

            if (PnBlueSenha.Width >= 240)
                TimerEntrarSenha.Stop();

            else
            {
                PnBlueSenha.Width += 24;
                PnBlueSenha.Location = new Point(PnBlueSenha.Location.X - 4, PnBlueSenha.Location.Y);
            }

            if (LblSenha.Location.Y > 155)
            {
                LblSenha.Font = new Font("Arial", 11);
                LblSenha.ForeColor = System.Drawing.SystemColors.MenuHighlight;
                LblSenha.Location = new Point(LblSenha.Location.X, LblSenha.Location.Y - 4);
            }
        }



        private void TxtLogin_Leave(object sender, EventArgs e)
        {
            if (TxtLogin.Text.Trim() == String.Empty)
            {
                TimerSairLogin.Start();
                this.PnBlueLogin.Location = new System.Drawing.Point(145, 132);
                PnBlueLogin.Width = 0;

            }
        }


        private void TxtSenha_Leave(object sender, EventArgs e)
        {
            if (TxtSenha.Text.Trim() == String.Empty)
            {
                TimerSairSenha.Start();
                this.PnBlueSenha.Location = new System.Drawing.Point(145, 195);
                PnBlueSenha.Width = 0;

            }
        }

        private void TimerSairLogin_Tick(object sender, EventArgs e)
        {
            if (LblLogin.Location.Y == 110)
                TimerSairLogin.Stop();
            else
            {
                LblLogin.Font = new Font("Arial Black", 9);
                LblLogin.ForeColor = Color.Black;
                LblLogin.Location = new Point(LblLogin.Location.X, LblLogin.Location.Y + 2);

            }
        }


        private void TimerSairSenha_Tick(object sender, EventArgs e)
        {
            if (LblSenha.Location.Y == 175)
                TimerSairSenha.Stop();
            else
            {
                LblSenha.Font = new Font("Arial Black", 9);
                LblSenha.ForeColor = Color.Black;
                LblSenha.Location = new Point(LblSenha.Location.X, LblSenha.Location.Y + 2);

            }
        }

        private void TxtSenha_Enter(object sender, EventArgs e)
        {
            TimerEntrarSenha.Start();
        }

        private void TxtLogin_Enter(object sender, EventArgs e)
        {
            TimerEntrarLogin.Start();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = LblTitulo;
        }
    }
}
