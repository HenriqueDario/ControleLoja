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
    public partial class FormAddProduto : Form
    {
        public FormAddProduto()
        {
            InitializeComponent();
        }


        //Picture box para fechar a janela
        private void PbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Colocar o texto do preço como valor monetário
        private void TxtPreco_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TxtPreco.Text = Convert.ToString(Convert.ToDouble(TxtPreco.Text).ToString("N2"));
            }
            catch
            {

            }
        }
    }
}
