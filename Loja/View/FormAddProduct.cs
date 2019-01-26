using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loja.Model;
using Loja.Controller;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Loja.View
{
    public partial class FormAddProduct : Form
    {
        public FormAddProduct()
        {
            InitializeComponent();
        }


        //Botão de cadastro
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                //checa se todos os campos estão validados
                if (ValidarCampos())
                {
                    //instancia novo produto
                    Product prod = new Product
                    {
                        Nome = TxtNome.Text,
                        Quantidade = int.Parse(NumQuantidade.Value.ToString()),
                        Preco = Decimal.Parse(TxtPreco.Text),
                        Lote = TxtLote.Text,
                        Fabricacao = DateTime.Parse(DtpDataFabricacao.Text),
                        Validade = DateTime.Parse(DtpValidade.Text)
                    };
                    //instancia novo Product Controller
                    ProductController pc = new ProductController();

                    //usa o metodo de cadastro de produto presente na classe Product Controller
                    pc.CadastroProduto(prod);

                    //mensagem para o usuário
                    MessageBox.Show("Funcionou perfeitamente", "Êxito");

                    //fecha janela
                    this.Close();
                }

            }catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

        }


        //Picture box para fechar a janela
        private void PbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Colocar o texto do preço como valor monetário
        private void TxtPreco_Leave(object sender, EventArgs e)
        {
            if (TxtPreco.Text != string.Empty)
            {
                try
                {
                    TxtPreco.Text = Decimal.Parse(TxtPreco.Text).ToString("N");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }
            }
        }

        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            DtpValidade.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }


        private Boolean ValidarCampos()
        {
            if (!string.IsNullOrWhiteSpace(TxtNome.Text) && !string.IsNullOrWhiteSpace(TxtPreco.Text) &&
                !string.IsNullOrWhiteSpace(TxtLote.Text))
            {                
                if (NumQuantidade.Value < 1)
                    MessageBox.Show("A quantidade minima para cadastro é 1", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                     if (DtpValidade.Value > DtpDataFabricacao.Value)
                        return true;
                    else
                        MessageBox.Show("A data de fabricação não pode ser maior ou igual a data de validade", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Preencha todos os campos corretamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

      
    }
}
