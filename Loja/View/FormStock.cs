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
        int idProduto = -1;
        public FormStock()
        {
            InitializeComponent();
        }



        private void FormEstoque_Load(object sender, EventArgs e)
        {
            DgvProdutos.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            ListarDataGrid();
            TxtPesquisa.Text = "Digite o nome do produto";


        }

        private void PbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            FormAddProduct FormAddProd = new FormAddProduct();
            this.Hide();
            FormAddProd.ShowDialog();
            ListarDataGrid();
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
            ProductController ProdCont = new ProductController();
            DgvProdutos.DataSource = ProdCont.ListarProdutos();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvProdutos.CurrentRow.Index > -1)
                    idProduto = Convert.ToInt16(DgvProdutos.CurrentRow.Cells[0].Value);
                else
                    MessageBox.Show("Selecione um produto para a exclusão", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Você deseja excluir esse produto?", "Confirmação", MessageBoxButtons.YesNo);


                if (dr.Equals(DialogResult.Yes))
                {
                    ProductController prodCont = new ProductController();
                    if (prodCont.ExcluirProduto(idProduto))
                        MessageBox.Show("Excluido com sucesso", "Exito");
                    ListarDataGrid();
                }
            }
            catch
            {                
                MessageBox.Show("Selecione um funcionário para essa ação", "ERROR");
            }
        }

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (TxtPesquisa.Text != "Digite o nome do produto")
            {
                ProductController prodCont = new ProductController();
                if (TxtPesquisa.Text.Trim().Length == 0)
                {
                    ListarDataGrid();
                    DgvProdutos.Refresh();
                }
                else
                {
                    DgvProdutos.DataSource = prodCont.BuscarProduto(TxtPesquisa.Text);
                    DgvProdutos.Refresh();
                }
            }
        }

        /* private void BtnEditar_Click(object sender, EventArgs e)
         {
             try
             {
                 if (DgvProdutos.CurrentRow.Index > -1)
                 {

                     idProduto = Convert.ToInt16(DgvProdutos.CurrentRow.Cells[0].Value.ToString());

                     ProductController pc = new ProductController();
                     Product prod = (idProduto);

                     FormEditEmployee FormEdit = new FormEditEmployee(f);
                     TxtPesquisa.Text = "Digite o nome do Funcionário";
                     this.Hide();
                     FormEdit.ShowDialog();
                     ListarDataGrid();
                     this.Show();
                 }
             }
             catch
             {
                 MessageBox.Show("Selecione um funcionário para essa ação", "ERROR");
             }
         }
         */
    }
}
