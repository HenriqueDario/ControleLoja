using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using Loja.Model;

namespace Loja.View
{
    public partial class FormListEmployees : Form
    {
        int idFuncionario = -1;
        public FormListEmployees()
        {
            InitializeComponent();
        }



        private void FormListarFuncionarios_Load(object sender, EventArgs e)
        {
            DgvFuncionarios.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            ListarDataGrid();
            TxtPesquisa.Text = "Digite o nome do Funcionário";
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            FormAddFuncionario FormAdd = new FormAddFuncionario();
            this.Hide();
            FormAdd.ShowDialog();
            ListarDataGrid();
            this.Show();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (DgvFuncionarios.CurrentRow.Index > -1)
                    idFuncionario = Convert.ToInt16(DgvFuncionarios.CurrentRow.Cells[0].Value.ToString());
                else
                    MessageBox.Show("Selecione um Funcionario para a exclusão", "ERROR");

                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Você Deseja Excluir esse funcionário?", "Confirmação", MessageBoxButtons.YesNo);
                if (dr.Equals(DialogResult.Yes))
                {
                    Controller.EmployeeController fc = new Controller.EmployeeController();
                    if (fc.ExcluirFuncionario(idFuncionario))
                        MessageBox.Show("Excluido com sucesso", "Exito");
                    ListarDataGrid();
                }
            }
            catch
            {
                MessageBox.Show("Selecione um funcionário para essa ação", "ERROR");
            }
        }

        public void ListarDataGrid()
        {
            Controller.EmployeeController fc = new Controller.EmployeeController();
            DgvFuncionarios.DataSource = fc.ListarFuncionarios();
        }



        private void BtnEditar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (DgvFuncionarios.CurrentRow.Index > -1)
                {

                    idFuncionario = Convert.ToInt16(DgvFuncionarios.CurrentRow.Cells[0].Value.ToString());

                    Controller.EmployeeController fc = new Controller.EmployeeController();
                    Employee f = fc.BuscaFuncionario(idFuncionario);

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




        private void TxtPesquisa_Enter(object sender, EventArgs e)
        {
            if (TxtPesquisa.Text == "Digite o nome do Funcionário")
                TxtPesquisa.Text = String.Empty;

        }


        private void TxtPesquisa_Leave(object sender, EventArgs e)
        {
            if (TxtPesquisa.Text.Trim() == String.Empty)
                TxtPesquisa.Text = "Digite o nome do Funcionário";

        }

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (TxtPesquisa.Text != "Digite o nome do Funcionário")
            {
                Controller.EmployeeController fc = new Controller.EmployeeController();
                if (TxtPesquisa.Text.Trim().Length == 0)
                {
                    ListarDataGrid();
                    DgvFuncionarios.Refresh();
                }
                else
                {
                    DgvFuncionarios.DataSource = fc.BuscaFuncionario(TxtPesquisa.Text);
                    DgvFuncionarios.Refresh();
                }
            }
        }

        private void PbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



