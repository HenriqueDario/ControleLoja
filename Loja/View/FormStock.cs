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
        //variavel para guardar id do produto
        int idProduto = -1;

        public FormStock()
        {
            InitializeComponent();
        }


        // carrega junto a janela
        private void FormEstoque_Load(object sender, EventArgs e)
        {
            //troca a cor padrão do fundo da datagrid
            DgvProdutos.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;

            //chama o método listar datagrid
            ListarDataGrid();

            //troca o formato da coluna preço da datagrid
            DgvProdutos.Columns["Preco"].DefaultCellStyle.Format = "N2";

            //coloca o texto na TxtPesquisa
            TxtPesquisa.Text = "Digite o nome do produto";


        }

        //ao clicar na PbExit
        private void PbExit_Click(object sender, EventArgs e)
        {
            //fecha a janela
            this.Close();
        }

        //ao clicar no BtnCadastrar
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            //instancia novo form FormAddProduct
            FormAddProduct FormAddProd = new FormAddProduct();

            //esconde essa janela
            this.Hide();

            //mostra o form FormAddProd
            FormAddProd.ShowDialog();

            //chama o metodo listarDataGrid
            ListarDataGrid();

            //mostra essa janela
            this.Show();
        }

        //ao entrar no TxtPesquisa
        private void TxtPesquisa_Enter(object sender, EventArgs e)
        {
            //checa se o texto presente é o padrão
            if (TxtPesquisa.Text == "Digite o nome do produto")
                //limpa o texto do campo
                TxtPesquisa.Text = String.Empty;
        }

        private void TxtPesquisa_Leave(object sender, EventArgs e)
        {
            //checa se o texto está vázio
            if (string.IsNullOrWhiteSpace(TxtPesquisa.Text))
                //coloca o texto padrão no TxtPesquisa
                TxtPesquisa.Text = "Digite o nome do produto";
        }

        //ao clicar no btnExcluir
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //checa se há linha selecionada
                if (DgvProdutos.CurrentRow.Index > -1)
                    //pega o id do produto selecionado e guarda na variavel idProduto
                    idProduto = Convert.ToInt16(DgvProdutos.CurrentRow.Cells[0].Value);
                else
                    //mostra mensagem de erro para o usuário
                    MessageBox.Show("Selecione um produto para a exclusão", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //cria um dialog result
                DialogResult dr = new DialogResult();

                //a variavel dr recebe o resultado da confirmação de exclusão
                dr = MessageBox.Show("Você deseja excluir esse produto?", "Confirmação", MessageBoxButtons.YesNo);

                //checa se o resultado da dr é sim
                if (dr.Equals(DialogResult.Yes))
                {
                    //instacia um ProductController
                    ProductController prodCont = new ProductController();

                    //checa se a exclusão foi realizada
                    if (prodCont.ExcluirProduto(idProduto))
                        //mostra mensagem para o usuário
                        MessageBox.Show("Excluido com sucesso", "Exito");

                    //chama o método ListarDataGrid
                    ListarDataGrid();
                }
            }
            catch
            {                
                //mostra mensagem para o usuário
                MessageBox.Show("Selecione um produto para essa ação", "ERROR");
            }
        }


        //se o texto do TxtPesquisa mudar
        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            //checa se não é o texto padrão
            if (TxtPesquisa.Text != "Digite o nome do produto")
            {
                //instancia um ProductController
                ProductController prodCont = new ProductController();

                //checa se o texto está vázio
                if (string.IsNullOrWhiteSpace(TxtPesquisa.Text))
                {
                    //chama o método ListarDataGrid
                    ListarDataGrid();

                    //atualiza a datagrid
                    DgvProdutos.Refresh();
                }
                else
                {
                    //a fonte de dados da datagrid recebe o método de BuscarProduto do ProductController
                    DgvProdutos.DataSource = prodCont.BuscarProduto(TxtPesquisa.Text);

                    //atualiza a datagrid
                    DgvProdutos.Refresh();
                }
            }
        }

        //ao clicar no btnEditar
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                //checa se há uma linha selecionada
                if (DgvProdutos.CurrentRow.Index > -1)
                {
                    //converte o id do produto da linha e guarda na variavel idProduto
                    idProduto = Convert.ToInt16(DgvProdutos.CurrentRow.Cells[0].Value.ToString());

                    //instancia um ProductController
                    ProductController pc = new ProductController();

                    //intancia um produto recebendo o resultado da busca pelo id
                    Product prod = pc.BuscarProduto(idProduto);

                    //instancia um FormEditProduct, passando prod como parametro
                    FormEditProduct FormEdit = new FormEditProduct(prod);

                    //muda o texto para o texto padrão
                    TxtPesquisa.Text = "Digite o nome do produto";

                    //esconde essa janela
                    this.Hide();

                    //mostra a janela do FormEdite
                    FormEdit.ShowDialog();

                    //chama o método ListarDataGrid
                    ListarDataGrid();

                    //mostra essa janela
                    this.Show();
                }
            }
            catch
            {
                //mostra mensagem de erro para o usuário
                MessageBox.Show("Selecione um produto para essa ação", "ERROR");
            }
        }

        //método para listar datagrid
        public void ListarDataGrid()
        {
            //instancia um ProductController; 
            ProductController ProdCont = new ProductController();

            //DgvProdutos recebe o método de listarProdutos como fonte de dados
            DgvProdutos.DataSource = ProdCont.ListarProdutos();

        }


    }
        
}
