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
    public partial class FormStock : Form
    {
        public FormStock()
        {
            InitializeComponent();
        }

        private void PbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FormEstoque_Load(object sender, EventArgs e)
        {

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            FormAddProduct FormAddProd = new FormAddProduct();
            this.Hide();
            FormAddProd.ShowDialog();
            this.Show();
        }
    }
}
