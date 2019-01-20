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
        bool menuFlag = false;

        public Principal()
        {
            InitializeComponent();
        }

        private void PbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void PbMenu_Click_1(object sender, EventArgs e)
        {
            TimerMenu.Start();
            menuFlag = !menuFlag;

        }



        private void TimerMenu_Tick_1(object sender, EventArgs e)
        {
            if (menuFlag)
            {
                PbMenu.Location = new Point(PbMenu.Location.X + 10, PbMenu.Location.Y);
                PnMenu.Location = new Point(PnMenu.Location.X + 10, PnMenu.Location.Y);
                if (PnMenu.Location.X >= 0)
                {
                    TimerMenu.Stop();
                }

            }
            else
            {
                PbMenu.Location = new Point(PbMenu.Location.X - 10, PbMenu.Location.Y);
                PnMenu.Location = new Point(PnMenu.Location.X - 10, PnMenu.Location.Y);
                if (PnMenu.Location.X <= -140)
                {
                    TimerMenu.Stop();
                }

            }
        }

        private void PbJubileu_MouseHover(object sender, EventArgs e)
        {

        }


        private void PbJubileu_MouseEnter(object sender, EventArgs e)
        {
            LblFala.Visible = true;
            PbFala.Visible = true;
        }

        private void PbJubileu_MouseLeave(object sender, EventArgs e)
        {
            LblFala.Visible = false;
            PbFala.Visible = false;
        }

        private void PbAjuda_MouseHover(object sender, EventArgs e)
        {
            //declara a variavel de tooltip
            ToolTip toolTip1 = new ToolTip();

            // Coloca o texto ToolTip para a picture box pbAjuda
            toolTip1.SetToolTip(this.PbAjuda, "Ajuda");

        }

        private void PbJubileu_Click(object sender, EventArgs e)
        {


        }

        private void PbFuncionario_Click(object sender, EventArgs e)
        {
            FormListEmployees FormListar = new View.FormListEmployees();
            this.Hide();
            TimerMenu.Start();
            menuFlag = !menuFlag;
            FormListar.ShowDialog();
            this.Show();
        }

        private void LblFuncionario_Click(object sender, EventArgs e)
        {
            FormListEmployees FormListar = new FormListEmployees();
            this.Hide();
            TimerMenu.Start();
            menuFlag = !menuFlag;
            FormListar.ShowDialog();
            this.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void PbEstoque_Click(object sender, EventArgs e)
        {
            FormStock FormEstoque = new FormStock();
            this.Hide();
            TimerMenu.Start();
            menuFlag = !menuFlag;
            FormEstoque.ShowDialog();
            this.Show();
        }

        private void LblEstoque_Click(object sender, EventArgs e)
        {
          //  View.FormEstoque fe = new View.FormEstoque();
            this.Hide();
           // fe.ShowDialog();
            this.Show();
        }

        private void PbAjuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comando de ajuda", "Em desenvolvimento");
        }
    }
}
