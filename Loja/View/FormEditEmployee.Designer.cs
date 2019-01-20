namespace Loja.View
{
    partial class FormEditEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditEmployee));
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.MtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.DtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.MtxtRG = new System.Windows.Forms.MaskedTextBox();
            this.MtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.TxtEndereco = new System.Windows.Forms.TextBox();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.TxtCargo = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblTelefone = new System.Windows.Forms.Label();
            this.LblBairro = new System.Windows.Forms.Label();
            this.LblEndereco = new System.Windows.Forms.Label();
            this.LblCargo = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.LblRG = new System.Windows.Forms.Label();
            this.LblDataNascimento = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.PbExit = new System.Windows.Forms.PictureBox();
            this.PbValido = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbValido)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnLimpar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpar.Location = new System.Drawing.Point(372, 238);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(85, 35);
            this.BtnLimpar.TabIndex = 99;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // MtxtTelefone
            // 
            this.MtxtTelefone.Location = new System.Drawing.Point(390, 191);
            this.MtxtTelefone.Mask = "(00) 00000-0000";
            this.MtxtTelefone.Name = "MtxtTelefone";
            this.MtxtTelefone.Size = new System.Drawing.Size(115, 20);
            this.MtxtTelefone.TabIndex = 8;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnEditar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.Location = new System.Drawing.Point(472, 238);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(85, 35);
            this.BtnEditar.TabIndex = 9;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // DtpDataNascimento
            // 
            this.DtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataNascimento.Location = new System.Drawing.Point(162, 114);
            this.DtpDataNascimento.Name = "DtpDataNascimento";
            this.DtpDataNascimento.Size = new System.Drawing.Size(117, 20);
            this.DtpDataNascimento.TabIndex = 2;
            this.DtpDataNascimento.Value = new System.DateTime(2018, 10, 15, 0, 0, 0, 0);
            // 
            // MtxtRG
            // 
            this.MtxtRG.Location = new System.Drawing.Point(65, 153);
            this.MtxtRG.Mask = "00.000.000-C";
            this.MtxtRG.Name = "MtxtRG";
            this.MtxtRG.Size = new System.Drawing.Size(100, 20);
            this.MtxtRG.TabIndex = 3;
            // 
            // MtxtCPF
            // 
            this.MtxtCPF.Location = new System.Drawing.Point(65, 195);
            this.MtxtCPF.Mask = "000.000.000-00";
            this.MtxtCPF.Name = "MtxtCPF";
            this.MtxtCPF.Size = new System.Drawing.Size(100, 20);
            this.MtxtCPF.TabIndex = 4;
            this.MtxtCPF.TextChanged += new System.EventHandler(this.MtxtCPF_TextChanged);
            this.MtxtCPF.Leave += new System.EventHandler(this.MtxtCPF_Leave);
            // 
            // TxtEndereco
            // 
            this.TxtEndereco.Location = new System.Drawing.Point(390, 118);
            this.TxtEndereco.Name = "TxtEndereco";
            this.TxtEndereco.Size = new System.Drawing.Size(115, 20);
            this.TxtEndereco.TabIndex = 6;
            // 
            // TxtBairro
            // 
            this.TxtBairro.Location = new System.Drawing.Point(390, 154);
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(115, 20);
            this.TxtBairro.TabIndex = 7;
            // 
            // TxtCargo
            // 
            this.TxtCargo.Location = new System.Drawing.Point(390, 80);
            this.TxtCargo.Name = "TxtCargo";
            this.TxtCargo.Size = new System.Drawing.Size(115, 20);
            this.TxtCargo.TabIndex = 5;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(68, 83);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(175, 20);
            this.TxtNome.TabIndex = 1;
            // 
            // LblTelefone
            // 
            this.LblTelefone.AutoSize = true;
            this.LblTelefone.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefone.Location = new System.Drawing.Point(315, 194);
            this.LblTelefone.Name = "LblTelefone";
            this.LblTelefone.Size = new System.Drawing.Size(69, 17);
            this.LblTelefone.TabIndex = 34;
            this.LblTelefone.Text = "Telefone:";
            // 
            // LblBairro
            // 
            this.LblBairro.AutoSize = true;
            this.LblBairro.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBairro.Location = new System.Drawing.Point(336, 157);
            this.LblBairro.Name = "LblBairro";
            this.LblBairro.Size = new System.Drawing.Size(52, 17);
            this.LblBairro.TabIndex = 33;
            this.LblBairro.Text = "Bairro:";
            // 
            // LblEndereco
            // 
            this.LblEndereco.AutoSize = true;
            this.LblEndereco.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEndereco.Location = new System.Drawing.Point(314, 118);
            this.LblEndereco.Name = "LblEndereco";
            this.LblEndereco.Size = new System.Drawing.Size(74, 17);
            this.LblEndereco.TabIndex = 32;
            this.LblEndereco.Text = "Endereco:";
            // 
            // LblCargo
            // 
            this.LblCargo.AutoSize = true;
            this.LblCargo.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargo.Location = new System.Drawing.Point(338, 81);
            this.LblCargo.Name = "LblCargo";
            this.LblCargo.Size = new System.Drawing.Size(50, 17);
            this.LblCargo.TabIndex = 28;
            this.LblCargo.Text = "Cargo:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(12, 195);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(38, 17);
            this.lblCpf.TabIndex = 26;
            this.lblCpf.Text = "CPF:";
            // 
            // LblRG
            // 
            this.LblRG.AutoSize = true;
            this.LblRG.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRG.Location = new System.Drawing.Point(12, 154);
            this.LblRG.Name = "LblRG";
            this.LblRG.Size = new System.Drawing.Size(31, 17);
            this.LblRG.TabIndex = 24;
            this.LblRG.Text = "RG:";
            // 
            // LblDataNascimento
            // 
            this.LblDataNascimento.AutoSize = true;
            this.LblDataNascimento.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataNascimento.Location = new System.Drawing.Point(12, 114);
            this.LblDataNascimento.Name = "LblDataNascimento";
            this.LblDataNascimento.Size = new System.Drawing.Size(144, 17);
            this.LblDataNascimento.TabIndex = 22;
            this.LblDataNascimento.Text = "Data de Nascimento:";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(12, 84);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(50, 17);
            this.LblNome.TabIndex = 20;
            this.LblNome.Text = "Nome:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblTitulo.Location = new System.Drawing.Point(205, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(170, 22);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "Editar funcionário";
            // 
            // PbExit
            // 
            this.PbExit.Image = global::Loja.Properties.Resources.IconExit;
            this.PbExit.Location = new System.Drawing.Point(525, 12);
            this.PbExit.Name = "PbExit";
            this.PbExit.Size = new System.Drawing.Size(41, 39);
            this.PbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbExit.TabIndex = 16;
            this.PbExit.TabStop = false;
            this.PbExit.Click += new System.EventHandler(this.PbExit_Click);
            // 
            // PbValido
            // 
            this.PbValido.Image = global::Loja.Properties.Resources.cpfValido;
            this.PbValido.Location = new System.Drawing.Point(170, 190);
            this.PbValido.Name = "PbValido";
            this.PbValido.Size = new System.Drawing.Size(30, 27);
            this.PbValido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbValido.TabIndex = 100;
            this.PbValido.TabStop = false;
            // 
            // FormEditFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 293);
            this.Controls.Add(this.PbValido);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.MtxtTelefone);
            this.Controls.Add(this.BtnEditar);
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
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.LblRG);
            this.Controls.Add(this.LblDataNascimento);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.PbExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEditFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar funcionario";
            this.Load += new System.EventHandler(this.FormEditFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbValido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.MaskedTextBox MtxtTelefone;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.DateTimePicker DtpDataNascimento;
        private System.Windows.Forms.MaskedTextBox MtxtRG;
        private System.Windows.Forms.MaskedTextBox MtxtCPF;
        private System.Windows.Forms.TextBox TxtEndereco;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.TextBox TxtCargo;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblTelefone;
        private System.Windows.Forms.Label LblBairro;
        private System.Windows.Forms.Label LblEndereco;
        private System.Windows.Forms.Label LblCargo;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label LblRG;
        private System.Windows.Forms.Label LblDataNascimento;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox PbExit;
        private System.Windows.Forms.PictureBox PbValido;
    }
}