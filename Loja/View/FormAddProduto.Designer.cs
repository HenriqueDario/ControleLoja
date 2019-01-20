namespace Loja.View
{
    partial class FormAddProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddProduto));
            this.label1 = new System.Windows.Forms.Label();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblValidade = new System.Windows.Forms.Label();
            this.LblQuantidade = new System.Windows.Forms.Label();
            this.LblPreco = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.DtpValidade = new System.Windows.Forms.DateTimePicker();
            this.NumQuantidade = new System.Windows.Forms.NumericUpDown();
            this.TxtPreco = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicionar Produto";
            // 
            // pbExit
            // 
            this.pbExit.Image = global::Loja.Properties.Resources.IconExit;
            this.pbExit.Location = new System.Drawing.Point(386, 12);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(48, 37);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 1;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.PbExit_Click);
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Arial Black", 9F);
            this.LblNome.Location = new System.Drawing.Point(12, 97);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(50, 17);
            this.LblNome.TabIndex = 2;
            this.LblNome.Text = "Nome:";
            // 
            // LblValidade
            // 
            this.LblValidade.AutoSize = true;
            this.LblValidade.Font = new System.Drawing.Font("Arial Black", 9F);
            this.LblValidade.Location = new System.Drawing.Point(12, 133);
            this.LblValidade.Name = "LblValidade";
            this.LblValidade.Size = new System.Drawing.Size(68, 17);
            this.LblValidade.TabIndex = 3;
            this.LblValidade.Text = "Validade:";
            // 
            // LblQuantidade
            // 
            this.LblQuantidade.AutoSize = true;
            this.LblQuantidade.Font = new System.Drawing.Font("Arial Black", 9F);
            this.LblQuantidade.Location = new System.Drawing.Point(222, 133);
            this.LblQuantidade.Name = "LblQuantidade";
            this.LblQuantidade.Size = new System.Drawing.Size(87, 17);
            this.LblQuantidade.TabIndex = 5;
            this.LblQuantidade.Text = "Quantidade:";
            // 
            // LblPreco
            // 
            this.LblPreco.AutoSize = true;
            this.LblPreco.Font = new System.Drawing.Font("Arial Black", 9F);
            this.LblPreco.Location = new System.Drawing.Point(222, 97);
            this.LblPreco.Name = "LblPreco";
            this.LblPreco.Size = new System.Drawing.Size(95, 17);
            this.LblPreco.TabIndex = 6;
            this.LblPreco.Text = "Preço:       R$";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(86, 97);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(110, 20);
            this.TxtNome.TabIndex = 7;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnCadastrar.Font = new System.Drawing.Font("Arial Black", 9F);
            this.BtnCadastrar.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrar.Location = new System.Drawing.Point(354, 186);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(80, 28);
            this.BtnCadastrar.TabIndex = 12;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnLimpar.Font = new System.Drawing.Font("Arial Black", 9F);
            this.BtnLimpar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpar.Location = new System.Drawing.Point(263, 186);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(80, 28);
            this.BtnLimpar.TabIndex = 13;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            // 
            // DtpValidade
            // 
            this.DtpValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpValidade.Location = new System.Drawing.Point(86, 133);
            this.DtpValidade.Name = "DtpValidade";
            this.DtpValidade.Size = new System.Drawing.Size(110, 20);
            this.DtpValidade.TabIndex = 14;
            // 
            // NumQuantidade
            // 
            this.NumQuantidade.Location = new System.Drawing.Point(315, 130);
            this.NumQuantidade.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.NumQuantidade.Name = "NumQuantidade";
            this.NumQuantidade.Size = new System.Drawing.Size(100, 20);
            this.NumQuantidade.TabIndex = 16;
            // 
            // TxtPreco
            // 
            this.TxtPreco.Location = new System.Drawing.Point(315, 96);
            this.TxtPreco.Name = "TxtPreco";
            this.TxtPreco.Size = new System.Drawing.Size(100, 20);
            this.TxtPreco.TabIndex = 17;
            // 
            // FormAddProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 221);
            this.Controls.Add(this.TxtPreco);
            this.Controls.Add(this.NumQuantidade);
            this.Controls.Add(this.DtpValidade);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblPreco);
            this.Controls.Add(this.LblQuantidade);
            this.Controls.Add(this.LblValidade);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Produto";
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblValidade;
        private System.Windows.Forms.Label LblQuantidade;
        private System.Windows.Forms.Label LblPreco;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.DateTimePicker DtpValidade;
        private System.Windows.Forms.NumericUpDown NumQuantidade;
        private System.Windows.Forms.TextBox TxtPreco;
    }
}