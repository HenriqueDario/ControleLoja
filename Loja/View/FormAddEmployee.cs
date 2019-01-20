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
using System.Data.Sql;
using System.Data.SqlClient;

namespace Loja
{
    public partial class FormAddFuncionario : Form
    {
        Controller.ValidarCPF vc = new Controller.ValidarCPF();

        public FormAddFuncionario()
        {
            InitializeComponent();
        }


        private void BtnCadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                //Checa se os campos estão validos
                if (ValidarCampos() && vc.ValidaCPF(MtxtCPF.Text))
                {
                    //instancia um novo funcionário
                    Employee funcionario = new Employee
                    {
                        Nome = TxtNome.Text,
                        DataNascimento = Convert.ToDateTime(DtpDataNascimento.Text),
                        Rg = MtxtRG.Text,
                        Cpf = MtxtCPF.Text,
                        Cargo = TxtCargo.Text,
                        Endereco = TxtEndereco.Text,
                        Bairro = TxtBairro.Text,
                        Telefone = MtxtTelefone.Text
                    };
                    //instanciação de um Funcionário Controller
                    Controller.EmployeeController fc = new Controller.EmployeeController();

                    //Usa o método de cadastrar funcionário passando um funcionário
                    fc.CadastrarFuncionario(funcionario);

                    //mensagem para o usuário
                    MessageBox.Show("Funcionou perfeitamente", "Êxito");

                    //fecha janela
                    this.Close();
                }
                else
                {   //Checa se o CPF é invalido e avisa o usuário
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

        //Click na picture box do "X"
        private void PbExit_Click(object sender, EventArgs e)
        {
            //fechar janela
            this.Close();
        }

        //Botão para limpar todos os campos
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
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

        //Método para checar se todos os campos foram preenchidos corretamente
        private Boolean ValidarCampos()
        {
            //se tudo estiver correto retorna True
            if (TxtNome.Text.Trim() != String.Empty && DtpDataNascimento.Text.Trim() != String.Empty
                && MtxtRG.MaskCompleted && MtxtCPF.MaskCompleted && TxtCargo.Text.Trim() != String.Empty
                && TxtEndereco.Text.Trim() != String.Empty && TxtBairro.Text.Trim() != String.Empty && MtxtTelefone.MaskCompleted)
                return true;


            return false;
        }


        //ao sair do campo de CPF
        private void MtxtCPF_Leave(object sender, EventArgs e)
        {

            try
            {
                //checa se o CPF é valido
                if (vc.ValidaCPF(MtxtCPF.Text))
                    PbValido.Image = Properties.Resources.cpfValido; //adiciona uma imagem de Êxito
                else
                    PbValido.Image = Properties.Resources.CpfError; // adiciona uma imagem de erro

            }
            catch
            {

            }

        }
        //ao "trocar" texto do campo de CPF
        private void MtxtCPF_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //checa se o CPF é valido
                if (vc.ValidaCPF(MtxtCPF.Text))
                    PbValido.Image = Properties.Resources.cpfValido; // adiciona uma imagem de Êxito
                else
                    PbValido.Image = Properties.Resources.CpfError; //adiciona uma imagem de erro

            }
            catch
            {

            }
        }
    }
}
