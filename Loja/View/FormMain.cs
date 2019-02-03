using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja.View
{
    public partial class Principal : Form
    {
        //variavel para marcar o menu
        bool menuFlag = false;

        public Principal()
        {
            InitializeComponent();
        }

        //ao clicar no Picture box "X"
        private void PbExit_Click(object sender, EventArgs e)
        {
            //fecha a janela
            this.Close();
        }

        //ao clicar no Picture box "menu"
        private void PbMenu_Click(object sender, EventArgs e)
        {
            //inicia o timer do menu
            TimerMenu.Start();
            //muda o valor do menuFlag
            menuFlag = !menuFlag;

        }


        //Timer do Menu
        private void TimerMenu_Tick(object sender, EventArgs e)
        {
            //checa o estado da variavel MenuFlag
            if (menuFlag) // se verdadeiro
            {
                //muda a posição da picture box PbMenu
                PbMenu.Location = new Point(PbMenu.Location.X + 10, PbMenu.Location.Y);

                //muda a posição do panel PnMenu
                PnMenu.Location = new Point(PnMenu.Location.X + 10, PnMenu.Location.Y);

                if (PnMenu.Location.X >= 0) // checa a posição do pnMenu
                {
                    //para o timer
                    TimerMenu.Stop();
                }

            }
            else // se não
            {
                //muda a posição da picture box PbMenu
                PbMenu.Location = new Point(PbMenu.Location.X - 10, PbMenu.Location.Y);

                //muda a posição do panel PnMenu
                PnMenu.Location = new Point(PnMenu.Location.X - 10, PnMenu.Location.Y);

                if (PnMenu.Location.X <= -140) // checa a posição do pnMenu
                {
                    //para o timer
                    TimerMenu.Stop();
                }

            }
        }

        //ao entrar na picture box pbJubileu
        private void PbJubileu_MouseEnter(object sender, EventArgs e)
        {
            //coloca a LblFala e a PbFala visiveis
            LblFala.Visible = true;
            PbFala.Visible = true;
        }

        //ao sair
        private void PbJubileu_MouseLeave(object sender, EventArgs e)
        {
            //coloca a LblFala e a PbFala invisiveis
            LblFala.Visible = false;
            PbFala.Visible = false;
        }

        //ao colocar o mouse sobre a PbAjuda
        private void PbAjuda_MouseHover(object sender, EventArgs e)
        {
            //declara a variavel de tooltip
            ToolTip toolTip1 = new ToolTip();

            // Coloca o texto ToolTip para a picture box pbAjuda
            toolTip1.SetToolTip(this.PbAjuda, "Ajuda");

        }

        //ao clicar na PbFuncionario
        private void PbFuncionario_Click(object sender, EventArgs e)
        {
            //instancia FormListEmployees
            FormListEmployees FormListar = new FormListEmployees();

            //esconde essa janela
            this.Hide();

            //inicia o timer do menu
            TimerMenu.Start();

            //troca o valor da menuFlag
            menuFlag = !menuFlag;

            //mostra a janela FormListar
            FormListar.ShowDialog();

            //mostra essa janela
            this.Show();
        }

        //ao clicar na lblFuncionario
        private void LblFuncionario_Click(object sender, EventArgs e)
        {
            //instancia FormListEmployees
            FormListEmployees FormListar = new FormListEmployees();

            //esconde essa janela
            this.Hide();

            //inicia o timer do menu
            TimerMenu.Start();

            //troca o valor da menuFlag
            menuFlag = !menuFlag;

            //mostra a janela FormListar
            FormListar.ShowDialog();

            //mostra essa janela
            this.Show();
        }

        //ao clicar na PbEstoque
        private void PbEstoque_Click(object sender, EventArgs e)
        {
            //instancia novo formStock
            FormStock FormEstoque = new FormStock();

            //esconde essa janela
            this.Hide();

            //inicia o timer menu
            TimerMenu.Start();

            //troca o valor da menuFlag
            menuFlag = !menuFlag;

            //mostra a janela do FormEstoque
            FormEstoque.ShowDialog();

            //mostra essa janela
            this.Show();
        }

        private void LblEstoque_Click(object sender, EventArgs e)
        {
            //instancia novo formStock
            FormStock FormEstoque = new FormStock();

            //esconde essa janela
            this.Hide();

            //inicia o timer menu
            TimerMenu.Start();

            //troca o valor da menuFlag
            menuFlag = !menuFlag;

            //mostra a janela do FormEstoque
            FormEstoque.ShowDialog();

            //mostra essa janela
            this.Show();
        }

        //ao clicar na PbAjuda
        private void PbAjuda_Click(object sender, EventArgs e)
        {
            //mostra mensagem ao usuário
            MessageBox.Show("Comando de ajuda", "Em desenvolvimento");
        }

        private void PbVenda_Click(object sender, EventArgs e)
        {
            //instancia novo form de venda
            FormSale FormVenda = new FormSale();

            //esconde essa janela
            this.Hide();

            //inicia o timer menu
            TimerMenu.Start();

            //troca o valor da menuFlag
            menuFlag = !menuFlag;

            //mostra a janela do FormSale
            FormVenda.ShowDialog();

            //mostra essa janela
            this.Show();
        }

        private void LblVenda_Click(object sender, EventArgs e)
        {
            //instancia novo form de venda
            FormSale FormVenda = new FormSale();

            //esconde essa janela
            this.Hide();

            //inicia o timer menu
            TimerMenu.Start();

            //troca o valor da menuFlag
            menuFlag = !menuFlag;

            //mostra a janela do FormSale
            FormVenda.ShowDialog();

            //mostra essa janela
            this.Show();
        }
    }
}
