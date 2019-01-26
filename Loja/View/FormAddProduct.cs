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
    public partial class FormAddProduct : Form
    {
        public FormAddProduct()
        {
            InitializeComponent();
        }


        //Picture box para fechar a janela
        private void PbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Colocar o texto do preço como valor monetário
        private void TxtPreco_Leave(object sender, EventArgs e)
        {
            try
            {
                TxtPreco.Text = Decimal.Parse(TxtPreco.Text).ToString("C2");
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            DtpValidade.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
