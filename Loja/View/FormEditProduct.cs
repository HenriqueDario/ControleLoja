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
    public partial class FormEditProduct : Form
    {
        //instancia novo produto
        Product product = new Product();

        public FormEditProduct(Product prod)
        {
            InitializeComponent();
            
            //o produto recebe o produto recebido por parametro
            this.product = prod;
        }

        private void FormEditProduct_Load(object sender, EventArgs e)
        {
            // carrega os campos junto ao inicio da janela
            TxtNome.Text = product.Nome;
            TxtPreco.Text = product.Preco.ToString();
            TxtLote.Text = product.Lote;
            DtpDataFabricacao.Text = Convert.ToString(product.Fabricacao);
            DtpValidade.Text = Convert.ToString(product.Validade);
            NumQuantidade.Value = product.Quantidade;
        }

        //se clicar na picture box "X"
        private void pbExit_Click(object sender, EventArgs e)
        {
            //fecha a janela
            this.Close();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                //se os campos forem válidos
                if (ValidarCampos())
                {
                    //O produto recebe os campos agora atualizados
                    product.Nome = TxtNome.Text;
                    product.Preco = Convert.ToDouble(TxtPreco.Text);
                    product.Lote = TxtLote.Text;
                    product.Quantidade = Convert.ToInt16(NumQuantidade.Value);
                    product.Fabricacao = DateTime.Parse(DtpDataFabricacao.Text);
                    product.Validade = DateTime.Parse(DtpValidade.Text);

                    //instancia novo product controller
                    ProductController pc = new ProductController();

                    //utiliza o método para editar o produto passando o produto atualizado como parametro
                    pc.EditarProduto(product);

                    //mostra uma mensagem de sucesso para o usuário
                    MessageBox.Show("Funcionou corretamente", "Êxito");

                    //fecha a janela
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Preencha todos os campos corretamente:  " +ex.Message, "ERROR");

            }
        }


        //método para verificar se os campos são válidos
        private Boolean ValidarCampos()
        {
            //checa se os campos de nome, preço e lote estão preenchidos
            if (!string.IsNullOrWhiteSpace(TxtNome.Text) && !string.IsNullOrWhiteSpace(TxtPreco.Text) &&
                !string.IsNullOrWhiteSpace(TxtLote.Text))
            {
                //checa se a quantidade é maior que 0
                if (NumQuantidade.Value < 1)
                    MessageBox.Show("A quantidade minima para cadastro é 1", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else { 
                    //checa se a data de validade é maior que a data de fabricação, se sim retorna verdadeiro
                     if (DtpValidade.Value > DtpDataFabricacao.Value)
                        return true;
                    else // se não maostra uma mensagem para o usuário
                        MessageBox.Show("A data de fabricação não pode ser maior ou igual a data de validade", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // se os campos não estiverem preenchidos mostra uma mensagem de erro para o usuário
                MessageBox.Show("Preencha todos os campos corretamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        // ao sair do campo de preço
        private void TxtPreco_Leave(object sender, EventArgs e)
        {
            //checa se o cmapo não está vázio
            if (TxtPreco.Text != string.Empty)
            {
                try
                {
                    //converte o valor para o valor numérico
                    TxtPreco.Text = Double.Parse(TxtPreco.Text).ToString("N");
                }
                catch (Exception ex)
                {
                    //mostra uma mensagem de erro caso tenha algum problema
                    MessageBox.Show("ERROR: " + ex.Message);
                }
            }
        }

        //botão limpar
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            //limpa todos os campos da janela
            TxtNome.Text = string.Empty;
            TxtPreco.Text = string.Empty;            
            TxtLote.Text = string.Empty;
            NumQuantidade.Value = decimal.Zero;
            DtpValidade.Text = DateTime.Now.ToString("dd/MM/yyyy");
            DtpDataFabricacao.Text = DateTime.Now.ToString("dd/MM/yyyy");
            
        }
    }
}
