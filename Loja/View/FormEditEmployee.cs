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

namespace Loja.View
{
    public partial class FormEditEmployee : Form
    {
        //instancia um funcionário
        Employee funcionario = new Employee();

        //instancia a validação de cpf
        ValidarCPF vc = new ValidarCPF();


        public FormEditEmployee(Employee f)
        {
            InitializeComponent();
            // o funcionário recebe o funcionário enviado como parametro
            funcionario = f;
        }
        //caso clique na picture box com o "X"
        private void PbExit_Click(object sender, EventArgs e)
        {
            //fecha a janela
            this.Close();
        }

        private void FormEditFuncionario_Load(object sender, EventArgs e)
        {
            // carrega os campos com os dados do funcionário
            TxtNome.Text = funcionario.Nome;
            DtpDataNascimento.Text = Convert.ToString(funcionario.DataNascimento);
            MtxtRG.Text = funcionario.Rg;
            MtxtCPF.Text = funcionario.Cpf;
            TxtCargo.Text = funcionario.Cargo;
            TxtEndereco.Text = funcionario.Endereco;
            TxtBairro.Text = funcionario.Bairro;
            MtxtTelefone.Text = funcionario.Telefone;
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            //limpa todos campos
            TxtNome.Text = String.Empty;
            DtpDataNascimento.Text = String.Empty;
            MtxtRG.Text = String.Empty;
            MtxtCPF.Text = String.Empty;
            TxtCargo.Text = String.Empty;
            TxtEndereco.Text = String.Empty;
            TxtBairro.Text = String.Empty;
            MtxtTelefone.Text = String.Empty;
            PbValido.Image = null;
        }


        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                //se todos os campos e o cpf forém validos
                if (ValidarCampos() && vc.ValidaCPF(MtxtCPF.Text))
                {
                    //funcionário recebe os campos atualizados
                    funcionario.Nome = TxtNome.Text;
                    funcionario.DataNascimento = Convert.ToDateTime(DtpDataNascimento.Text);
                    funcionario.Rg = MtxtRG.Text;
                    funcionario.Cpf = MtxtCPF.Text;
                    funcionario.Cargo = TxtCargo.Text;
                    funcionario.Endereco = TxtEndereco.Text;
                    funcionario.Bairro = TxtBairro.Text;
                    funcionario.Telefone = MtxtTelefone.Text;

                    //instancia novo employee Controller
                    EmployeeController EmployeeCont = new EmployeeController();

                    //Edita o funcionário passando o funcionário atualizado como parametro
                    EmployeeCont.EditarFuncionario(funcionario);

                    //mensagem de sucesso para o usuário
                    MessageBox.Show("Funcionou corretamente", "Êxito");

                    //fecha a janela
                    this.Close();
                }
                else // se não
                {
                    //checa se o cpf não é valido e avisa o usuário
                    if (!vc.ValidaCPF(MtxtCPF.Text))
                        MessageBox.Show("Digite um CPF valido", "ERROR");
                    else
                        MessageBox.Show("Preencha todos os campos corretamente", "ERROR");
                }
            }
            catch
            {
                MessageBox.Show("Preencha todos os campos corretamente", "ERROR");

            }
        }

        //método para checar se todos os campos estão preenchidos corretamente
        private Boolean ValidarCampos()
        {
            // se todos os campos foram preenchidos corretamente retorna verdadeiro
            if (!string.IsNullOrWhiteSpace(TxtNome.Text) &&
                !string.IsNullOrWhiteSpace(DtpDataNascimento.Text) &&
                !string.IsNullOrWhiteSpace(TxtEndereco.Text) && 
                !string.IsNullOrWhiteSpace(TxtCargo.Text) &&
                !string.IsNullOrWhiteSpace(TxtBairro.Text) && 
                 MtxtRG.MaskCompleted &&
                 MtxtCPF.MaskCompleted &&
                 MtxtTelefone.MaskCompleted)
                return true;
            else
                return false;
        }

        //ao sair do campo do cpf
        private void MtxtCPF_Leave(object sender, EventArgs e)
        {
            try
            {   
                //checa se o cpf é válido e mostra uma imagem de êxito ou erro
                if (vc.ValidaCPF(MtxtCPF.Text))
                    PbValido.Image = Properties.Resources.cpfValido;
                else
                    PbValido.Image = Properties.Resources.CpfError;

            }
            catch
            {

            }
        }

        //enquanto o texto é modificado
        private void MtxtCPF_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //checa se o cpf é válido e mostra uma imagem de êxito ou erro
                if (vc.ValidaCPF(MtxtCPF.Text))
                    PbValido.Image = Properties.Resources.cpfValido;
                else
                    PbValido.Image = Properties.Resources.CpfError;

            }
            catch
            {

            }
        }
    }
}
