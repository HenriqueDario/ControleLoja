using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loja.Controller;
using Loja.Model;

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
            DgvProdutos.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            ListarDataGrid();
            TxtPesquisa.Text = "Digite o nome do produto";


        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            FormAddProduct FormAddProd = new FormAddProduct();
            this.Hide();
            FormAddProd.ShowDialog();
            this.Show();
        }

        private void TxtPesquisa_Enter(object sender, EventArgs e)
        {
            if (TxtPesquisa.Text == "Digite o nome do produto")
                TxtPesquisa.Text = String.Empty;
        }

        private void TxtPesquisa_Leave(object sender, EventArgs e)
        {
            if (TxtPesquisa.Text.Trim() == String.Empty)
                TxtPesquisa.Text = "Digite o nome do produto";
        }

        public void ListarDataGrid()
        {
            ProductController pc = new ProductController();
            DgvProdutos.DataSource = pc.ListarProdutos();
        }
    }
}
