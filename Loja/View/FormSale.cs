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
    public partial class FormSale : Form
    {
        public FormSale()
        {
            InitializeComponent();
        }

        private void PbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSale_Load(object sender, EventArgs e)
        {
            LblData.Text += Convert.ToString(DateTime.Now);
        }


    }
}
