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
using Loja.Controller;

namespace Loja.View
{
    public partial class FormListEmployees : Form
    {
        //variavel para id do funcionário
        int idFuncionario = -1;
        public FormListEmployees()
        {
            InitializeComponent();
        }

        private void FormListEmployees_Load(object sender, EventArgs e)
        {
            //troca a cor do fundo da datagrid quando selecionada
            DgvFuncionarios.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            //chama o método para listar a datagrid
            ListarDataGrid();
            //coloca texto no textbox de Pesquisa
            TxtPesquisa.Text = "Digite o nome do Funcionário";
        }

        //ao clicar no botão cadastrar
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            //instancia formulário de cadastro de funcionário
            FormAddFuncionario FormAdd = new FormAddFuncionario();

            //esconde essa janela
            this.Hide();

            //abre janela de dialogo do formulário de cadastro
            FormAdd.ShowDialog();

            //ao sair da janela chama o método de listar datagrid
            ListarDataGrid();

            //mostra essa janela novamente
            this.Show();
        }

        //ao clicar no botão de excluir
        private void BtnExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                //checa se há alguma linha selecionada
                if (DgvFuncionarios.CurrentRow.Index > -1)
                    //pega o id da linha selecionada e guarda na variavel de idFuncionário
                    idFuncionario = Convert.ToInt16(DgvFuncionarios.CurrentRow.Cells[0].Value.ToString());
                else
                    //mostra mensagem para o usuário
                    MessageBox.Show("Selecione um Funcionario para a exclusão", "ERROR");

                //instancia um dialogResult
                DialogResult dr = new DialogResult();

                //a variavel recebe o resultado de uma messagebox de confirmação
                dr = MessageBox.Show("Você Deseja Excluir esse funcionário?", "Confirmação", MessageBoxButtons.YesNo);

                //checa se o resultado foi sim
                if (dr.Equals(DialogResult.Yes))
                {
                    //instancia novo employee controller
                    EmployeeController employeeCont = new EmployeeController();

                    //checa se a exclusão do funcionário foi feita
                    if (employeeCont.ExcluirFuncionario(idFuncionario)) 
                        //mostra mensagem de sucesso
                        MessageBox.Show("Excluido com sucesso", "Exito");

                    //chama o método de listar datagrid
                    ListarDataGrid();
                }
            }
            catch
            {
                MessageBox.Show("Selecione um funcionário para essa ação", "ERROR");
            }
        }



        //ao clicar no botão de editar
        private void BtnEditar_Click(object sender, EventArgs e)
        {

            try
            {
                //checa se há alguma linha selecionada
                if (DgvFuncionarios.CurrentRow.Index > -1)
                {
                    //converte o id presente na linha selecionada e guarda na variavel idFuncionario
                    idFuncionario = Convert.ToInt16(DgvFuncionarios.CurrentRow.Cells[0].Value.ToString());

                    //Instancia novo employee controller
                    EmployeeController fc = new EmployeeController();

                    //instancia um novo funcionário recebendo o resultado da busca feita pelo id
                    Employee f = fc.BuscaFuncionario(idFuncionario);

                    //instancia janela de edição do funcionário, passando um funcionário como parametro
                    FormEditEmployee FormEdit = new FormEditEmployee(f);

                    //volta o texto da textbox de pesquisa para o padrão
                    TxtPesquisa.Text = "Digite o nome do Funcionário";

                    //esconde essa janela
                    this.Hide();

                    //mostra a janela de edição do funcionário
                    FormEdit.ShowDialog();

                    //chama o método de listar datagrid
                    ListarDataGrid();

                    //mostra essa janela novamente
                    this.Show();
                }
            }
            catch
            {
                MessageBox.Show("Selecione um funcionário para essa ação", "ERROR");
            }
        }





        //ao trocar o texto do textbox de pesquisa
        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            //checa se o texto é diferente do padrão
            if (TxtPesquisa.Text != "Digite o nome do Funcionário")
            {
                //instancia novo employee controller
                EmployeeController EmployeeCont = new EmployeeController();

                //checa se o texto está vázio
                if (string.IsNullOrWhiteSpace(TxtPesquisa.Text))
                {
                    //chama o método de listar datagrid
                    ListarDataGrid();
                    //atualiza a datagrid
                    DgvFuncionarios.Refresh();
                }
                else
                {
                    //atualiza a datagrid recebendo o resultado da pesquisa dos funcionários
                    DgvFuncionarios.DataSource = EmployeeCont.BuscaFuncionario(TxtPesquisa.Text);
                    //atualiza o datagrid
                    DgvFuncionarios.Refresh();
                }
            }
        }
        //ao clicar na picture box com "X" 
        private void PbExit_Click(object sender, EventArgs e)
        {
            //fecha a janela
            this.Close();
        }

        //ao entrar no textbox txtPesquisa
        private void TxtPesquisa_Enter(object sender, EventArgs e)
        {
            //checa se o texto é o padrão
            if (TxtPesquisa.Text == "Digite o nome do Funcionário")
                //limpa o texto
                TxtPesquisa.Text = String.Empty;
        }

        //ao sair da textbox txtPesquisa
        private void TxtPesquisa_Leave(object sender, EventArgs e)
        {
            //checa se o texto está vázio
            if (string.IsNullOrWhiteSpace(TxtPesquisa.Text))
                TxtPesquisa.Text = "Digite o nome do Funcionário";

        }

        //método para listar a datagrid
        public void ListarDataGrid()
        {
            //instancia novo employee controller
            EmployeeController EmployeeCont = new EmployeeController();

            //a fonte de dados da datagrid recebe o método de listar funcionários do employee controller
            DgvFuncionarios.DataSource = EmployeeCont.ListarFuncionarios();
        }
    }
}



