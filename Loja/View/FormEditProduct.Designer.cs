namespace Loja.View
{
    partial class FormEditProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditProduct));
            this.LblLote = new System.Windows.Forms.Label();
            this.TxtLote = new System.Windows.Forms.TextBox();
            this.DtpDataFabricacao = new System.Windows.Forms.DateTimePicker();
            this.lblDataFabricacao = new System.Windows.Forms.Label();
            this.TxtPreco = new System.Windows.Forms.TextBox();
            this.NumQuantidade = new System.Windows.Forms.NumericUpDown();
            this.DtpValidade = new System.Windows.Forms.DateTimePicker();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblPreco = new System.Windows.Forms.Label();
            this.LblQuantidade = new System.Windows.Forms.Label();
            this.LblValidade = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // LblLote
            // 
            this.LblLote.AutoSize = true;
            this.LblLote.Font = new System.Drawing.Font("Arial Black", 9F);
            this.LblLote.Location = new System.Drawing.Point(301, 171);
            this.LblLote.Name = "LblLote";
            this.LblLote.Size = new System.Drawing.Size(41, 17);
            this.LblLote.TabIndex = 38;
            this.LblLote.Text = "Lote:";
            // 
            // TxtLote
            // 
            this.TxtLote.Location = new System.Drawing.Point(346, 171);
            this.TxtLote.Name = "TxtLote";
            this.TxtLote.Size = new System.Drawing.Size(100, 20);
            this.TxtLote.TabIndex = 37;
            // 
            // DtpDataFabricacao
            // 
            this.DtpDataFabricacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataFabricacao.Location = new System.Drawing.Point(101, 136);
            this.DtpDataFabricacao.Name = "DtpDataFabricacao";
            this.DtpDataFabricacao.Size = new System.Drawing.Size(110, 20);
            this.DtpDataFabricacao.TabIndex = 36;
            // 
            // lblDataFabricacao
            // 
            this.lblDataFabricacao.AutoSize = true;
            this.lblDataFabricacao.Font = new System.Drawing.Font("Arial Black", 9F);
            this.lblDataFabricacao.Location = new System.Drawing.Point(11, 136);
            this.lblDataFabricacao.Name = "lblDataFabricacao";
            this.lblDataFabricacao.Size = new System.Drawing.Size(85, 17);
            this.lblDataFabricacao.TabIndex = 35;
            this.lblDataFabricacao.Text = "Fabricação:";
            // 
            // TxtPreco
            // 
            this.TxtPreco.Location = new System.Drawing.Point(346, 101);
            this.TxtPreco.Name = "TxtPreco";
            this.TxtPreco.Size = new System.Drawing.Size(100, 20);
            this.TxtPreco.TabIndex = 34;
            this.TxtPreco.Leave += new System.EventHandler(this.TxtPreco_Leave);
            // 
            // NumQuantidade
            // 
            this.NumQuantidade.Location = new System.Drawing.Point(346, 136);
            this.NumQuantidade.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.NumQuantidade.Name = "NumQuantidade";
            this.NumQuantidade.Size = new System.Drawing.Size(100, 20);
            this.NumQuantidade.TabIndex = 33;
            // 
            // DtpValidade
            // 
            this.DtpValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpValidade.Location = new System.Drawing.Point(101, 171);
            this.DtpValidade.Name = "DtpValidade";
            this.DtpValidade.Size = new System.Drawing.Size(110, 20);
            this.DtpValidade.TabIndex = 32;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnLimpar.Font = new System.Drawing.Font("Arial Black", 9F);
            this.BtnLimpar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpar.Location = new System.Drawing.Point(332, 222);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(80, 28);
            this.BtnLimpar.TabIndex = 31;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnEditar.Font = new System.Drawing.Font("Arial Black", 9F);
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.Location = new System.Drawing.Point(418, 222);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(80, 28);
            this.BtnEditar.TabIndex = 30;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(101, 101);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(110, 20);
            this.TxtNome.TabIndex = 29;
            // 
            // LblPreco
            // 
            this.LblPreco.AutoSize = true;
            this.LblPreco.Font = new System.Drawing.Font("Arial Black", 9F);
            this.LblPreco.Location = new System.Drawing.Point(274, 101);
            this.LblPreco.Name = "LblPreco";
            this.LblPreco.Size = new System.Drawing.Size(71, 17);
            this.LblPreco.TabIndex = 28;
            this.LblPreco.Text = "Preço: R$";
            // 
            // LblQuantidade
            // 
            this.LblQuantidade.AutoSize = true;
            this.LblQuantidade.Font = new System.Drawing.Font("Arial Black", 9F);
            this.LblQuantidade.Location = new System.Drawing.Point(256, 136);
            this.LblQuantidade.Name = "LblQuantidade";
            this.LblQuantidade.Size = new System.Drawing.Size(87, 17);
            this.LblQuantidade.TabIndex = 27;
            this.LblQuantidade.Text = "Quantidade:";
            // 
            // LblValidade
            // 
            this.LblValidade.AutoSize = true;
            this.LblValidade.Font = new System.Drawing.Font("Arial Black", 9F);
            this.LblValidade.Location = new System.Drawing.Point(26, 171);
            this.LblValidade.Name = "LblValidade";
            this.LblValidade.Size = new System.Drawing.Size(68, 17);
            this.LblValidade.TabIndex = 26;
            this.LblValidade.Text = "Validade:";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Arial Black", 9F);
            this.LblNome.Location = new System.Drawing.Point(46, 101);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(50, 17);
            this.LblNome.TabIndex = 25;
            this.LblNome.Text = "Nome:";
            // 
            // pbExit
            // 
            this.pbExit.Image = global::Loja.Properties.Resources.IconExit;
            this.pbExit.Location = new System.Drawing.Point(451, 13);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(48, 37);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 24;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(190, 13);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(140, 22);
            this.LblTitulo.TabIndex = 23;
            this.LblTitulo.Text = "Editar Produto";
            // 
            // FormEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(510, 260);
            this.Controls.Add(this.LblLote);
            this.Controls.Add(this.TxtLote);
            this.Controls.Add(this.DtpDataFabricacao);
            this.Controls.Add(this.lblDataFabricacao);
            this.Controls.Add(this.TxtPreco);
            this.Controls.Add(this.NumQuantidade);
            this.Controls.Add(this.DtpValidade);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblPreco);
            this.Controls.Add(this.LblQuantidade);
            this.Controls.Add(this.LblValidade);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.LblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEditProduct";
            this.Text = "FormEditProduct";
            this.Load += new System.EventHandler(this.FormEditProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblLote;
        private System.Windows.Forms.TextBox TxtLote;
        private System.Windows.Forms.DateTimePicker DtpDataFabricacao;
        private System.Windows.Forms.Label lblDataFabricacao;
        private System.Windows.Forms.TextBox TxtPreco;
        private System.Windows.Forms.NumericUpDown NumQuantidade;
        private System.Windows.Forms.DateTimePicker DtpValidade;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblPreco;
        private System.Windows.Forms.Label LblQuantidade;
        private System.Windows.Forms.Label LblValidade;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Label LblTitulo;
    }
}