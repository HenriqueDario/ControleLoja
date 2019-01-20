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


namespace Loja.View
{
    public partial class FormEditFuncionario : Form
    {
        Funcionario funcionario = new Funcionario();
        Controller.ValidarCPF vc = new Controller.ValidarCPF();
        public FormEditFuncionario(Funcionario f)
        {
            InitializeComponent();
            funcionario = f;
        }

        private void PbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditFuncionario_Load(object sender, EventArgs e)
        {
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
                if (ValidarCampos() && vc.ValidaCPF(MtxtCPF.Text))
                {
                    funcionario.Nome = TxtNome.Text;
                    funcionario.DataNascimento = Convert.ToDateTime(DtpDataNascimento.Text);
                    funcionario.Rg = MtxtRG.Text;
                    funcionario.Cpf = MtxtCPF.Text;
                    funcionario.Cargo = TxtCargo.Text;
                    funcionario.Endereco = TxtEndereco.Text;
                    funcionario.Bairro = TxtBairro.Text;
                    funcionario.Telefone = MtxtTelefone.Text;

                    Controller.FuncionarioController fc = new Controller.FuncionarioController();
                    fc.EditarFuncionario(funcionario);

                    MessageBox.Show("Funcionou corretamente", "Êxito");
                    this.Close();
                }
                else
                {
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


        private Boolean ValidarCampos()
        {
            if (TxtNome.Text != String.Empty && DtpDataNascimento.Text != String.Empty && MtxtRG.MaskCompleted &&
            MtxtCPF.MaskCompleted && TxtCargo.Text != String.Empty && TxtEndereco.Text != String.Empty &&
            TxtBairro.Text != String.Empty && MtxtTelefone.MaskCompleted)
                return true;
            else
                return false;
        }

        private void MtxtCPF_Leave(object sender, EventArgs e)
        {
            try
            {
                if (vc.ValidaCPF(MtxtCPF.Text))
                    PbValido.Image = Properties.Resources.cpfValido;

                else
                    PbValido.Image = Properties.Resources.CpfError;

            }
            catch
            {

            }
        }

        private void MtxtCPF_TextChanged(object sender, EventArgs e)
        {
            try
            {
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
