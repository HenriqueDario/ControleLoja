namespace Loja
{
    partial class FormAddFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddFuncionario));
            this.PbExit = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblDataNascimento = new System.Windows.Forms.Label();
            this.LblRg = new System.Windows.Forms.Label();
            this.LblCpf = new System.Windows.Forms.Label();
            this.LblCargo = new System.Windows.Forms.Label();
            this.LblEndereco = new System.Windows.Forms.Label();
            this.LblBairro = new System.Windows.Forms.Label();
            this.LblTelefone = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtCargo = new System.Windows.Forms.TextBox();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.TxtEndereco = new System.Windows.Forms.TextBox();
            this.MtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.MtxtRG = new System.Windows.Forms.MaskedTextBox();
            this.DtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.MtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.PbValido = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbValido)).BeginInit();
            this.SuspendLayout();
            // 
            // PbExit
            // 
            this.PbExit.Image = global::Loja.Properties.Resources.IconExit;
            this.PbExit.Location = new System.Drawing.Point(524, 12);
            this.PbExit.Name = "PbExit";
            this.PbExit.Size = new System.Drawing.Size(41, 39);
            this.PbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbExit.TabIndex = 0;
            this.PbExit.TabStop = false;
            this.PbExit.Click += new System.EventHandler(this.PbExit_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.LblTitulo.Location = new System.Drawing.Point(197, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(211, 22);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Cadastrar funcionário";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(15, 89);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(50, 17);
            this.LblNome.TabIndex = 2;
            this.LblNome.Text = "Nome:";
            // 
            // LblDataNascimento
            // 
            this.LblDataNascimento.AutoSize = true;
            this.LblDataNascimento.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataNascimento.Location = new System.Drawing.Point(15, 123);
            this.LblDataNascimento.Name = "LblDataNascimento";
            this.LblDataNascimento.Size = new System.Drawing.Size(144, 17);
            this.LblDataNascimento.TabIndex = 3;
            this.LblDataNascimento.Text = "Data de Nascimento:";
            // 
            // LblRg
            // 
            this.LblRg.AutoSize = true;
            this.LblRg.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRg.Location = new System.Drawing.Point(15, 165);
            this.LblRg.Name = "LblRg";
            this.LblRg.Size = new System.Drawing.Size(27, 17);
            this.LblRg.TabIndex = 4;
            this.LblRg.Text = "RG";
            // 
            // LblCpf
            // 
            this.LblCpf.AutoSize = true;
            this.LblCpf.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCpf.Location = new System.Drawing.Point(15, 205);
            this.LblCpf.Name = "LblCpf";
            this.LblCpf.Size = new System.Drawing.Size(34, 17);
            this.LblCpf.TabIndex = 5;
            this.LblCpf.Text = "CPF";
            // 
            // LblCargo
            // 
            this.LblCargo.AutoSize = true;
            this.LblCargo.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargo.Location = new System.Drawing.Point(342, 92);
            this.LblCargo.Name = "LblCargo";
            this.LblCargo.Size = new System.Drawing.Size(50, 17);
            this.LblCargo.TabIndex = 6;
            this.LblCargo.Text = "Cargo:";
            // 
            // LblEndereco
            // 
            this.LblEndereco.AutoSize = true;
            this.LblEndereco.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEndereco.Location = new System.Drawing.Point(320, 127);
            this.LblEndereco.Name = "LblEndereco";
            this.LblEndereco.Size = new System.Drawing.Size(74, 17);
            this.LblEndereco.TabIndex = 9;
            this.LblEndereco.Text = "Endereco:";
            // 
            // LblBairro
            // 
            this.LblBairro.AutoSize = true;
            this.LblBairro.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBairro.Location = new System.Drawing.Point(340, 165);
            this.LblBairro.Name = "LblBairro";
            this.LblBairro.Size = new System.Drawing.Size(52, 17);
            this.LblBairro.TabIndex = 10;
            this.LblBairro.Text = "Bairro:";
            // 
            // LblTelefone
            // 
            this.LblTelefone.AutoSize = true;
            this.LblTelefone.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefone.Location = new System.Drawing.Point(321, 205);
            this.LblTelefone.Name = "LblTelefone";
            this.LblTelefone.Size = new System.Drawing.Size(69, 17);
            this.LblTelefone.TabIndex = 14;
            this.LblTelefone.Text = "Telefone:";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(67, 89);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(175, 20);
            this.TxtNome.TabIndex = 1;
            // 
            // TxtCargo
            // 
            this.TxtCargo.Location = new System.Drawing.Point(398, 91);
            this.TxtCargo.Name = "TxtCargo";
            this.TxtCargo.Size = new System.Drawing.Size(100, 20);
            this.TxtCargo.TabIndex = 5;
            // 
            // TxtBairro
            // 
            this.TxtBairro.Location = new System.Drawing.Point(398, 166);
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(100, 20);
            this.TxtBairro.TabIndex = 7;
            // 
            // TxtEndereco
            // 
            this.TxtEndereco.Location = new System.Drawing.Point(398, 126);
            this.TxtEndereco.Name = "TxtEndereco";
            this.TxtEndereco.Size = new System.Drawing.Size(100, 20);
            this.TxtEndereco.TabIndex = 6;
            // 
            // MtxtCPF
            // 
            this.MtxtCPF.Location = new System.Drawing.Point(55, 205);
            this.MtxtCPF.Mask = "000.000.000-00";
            this.MtxtCPF.Name = "MtxtCPF";
            this.MtxtCPF.Size = new System.Drawing.Size(100, 20);
            this.MtxtCPF.TabIndex = 4;
            this.MtxtCPF.TextChanged += new System.EventHandler(this.MtxtCPF_TextChanged);
            this.MtxtCPF.Leave += new System.EventHandler(this.MtxtCPF_Leave);
            // 
            // MtxtRG
            // 
            this.MtxtRG.Location = new System.Drawing.Point(55, 165);
            this.MtxtRG.Mask = "00.000.000-C";
            this.MtxtRG.Name = "MtxtRG";
            this.MtxtRG.Size = new System.Drawing.Size(100, 20);
            this.MtxtRG.TabIndex = 3;
            // 
            // DtpDataNascimento
            // 
            this.DtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataNascimento.Location = new System.Drawing.Point(166, 123);
            this.DtpDataNascimento.Name = "DtpDataNascimento";
            this.DtpDataNascimento.Size = new System.Drawing.Size(117, 20);
            this.DtpDataNascimento.TabIndex = 2;
            this.DtpDataNascimento.Value = new System.DateTime(2019, 1, 28, 0, 0, 0, 0);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnCadastrar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrar.Location = new System.Drawing.Point(470, 249);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(85, 35);
            this.BtnCadastrar.TabIndex = 9;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // MtxtTelefone
            // 
            this.MtxtTelefone.Location = new System.Drawing.Point(398, 202);
            this.MtxtTelefone.Mask = "(00) 00000-0000";
            this.MtxtTelefone.Name = "MtxtTelefone";
            this.MtxtTelefone.Size = new System.Drawing.Size(100, 20);
            this.MtxtTelefone.TabIndex = 8;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnLimpar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpar.Location = new System.Drawing.Point(370, 249);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(85, 35);
            this.BtnLimpar.TabIndex = 99;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // PbValido
            // 
            this.PbValido.Location = new System.Drawing.Point(160, 200);
            this.PbValido.Name = "PbValido";
            this.PbValido.Size = new System.Drawing.Size(30, 27);
            this.PbValido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbValido.TabIndex = 101;
            this.PbValido.TabStop = false;
            // 
            // FormAddFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 300);
            this.Controls.Add(this.PbValido);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.MtxtTelefone);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.DtpDataNascimento);
            this.Controls.Add(this.MtxtRG);
            this.Controls.Add(this.MtxtCPF);
            this.Controls.Add(this.TxtEndereco);
            this.Controls.Add(this.TxtBairro);
            this.Controls.Add(this.TxtCargo);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblTelefone);
            this.Controls.Add(this.LblBairro);
            this.Controls.Add(this.LblEndereco);
            this.Controls.Add(this.LblCargo);
            this.Controls.Add(this.LblCpf);
            this.Controls.Add(this.LblRg);
            this.Controls.Add(this.LblDataNascimento);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.PbExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Funcionário";
            this.Load += new System.EventHandler(this.FormAddFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbValido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbExit;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblDataNascimento;
        private System.Windows.Forms.Label LblRg;
        private System.Windows.Forms.Label LblCpf;
        private System.Windows.Forms.Label LblCargo;
        private System.Windows.Forms.Label LblEndereco;
        private System.Windows.Forms.Label LblBairro;
        private System.Windows.Forms.Label LblTelefone;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtCargo;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.TextBox TxtEndereco;
        private System.Windows.Forms.MaskedTextBox MtxtCPF;
        private System.Windows.Forms.MaskedTextBox MtxtRG;
        private System.Windows.Forms.DateTimePicker DtpDataNascimento;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.MaskedTextBox MtxtTelefone;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.PictureBox PbValido;
    }
}