namespace Loja.View
{
    partial class FormEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstoque));
            this.PbExit = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.DgvProdutos = new System.Windows.Forms.DataGridView();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.PnGrey = new System.Windows.Forms.Panel();
            this.pnBlue = new System.Windows.Forms.Panel();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.PbSearch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).BeginInit();
            this.PnGrey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // PbExit
            // 
            this.PbExit.Image = global::Loja.Properties.Resources.IconExit;
            this.PbExit.Location = new System.Drawing.Point(540, 12);
            this.PbExit.Name = "PbExit";
            this.PbExit.Size = new System.Drawing.Size(48, 40);
            this.PbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbExit.TabIndex = 0;
            this.PbExit.TabStop = false;
            this.PbExit.Click += new System.EventHandler(this.PbExit_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(243, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(83, 22);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Estoque";
            // 
            // DgvProdutos
            // 
            this.DgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProdutos.Location = new System.Drawing.Point(12, 210);
            this.DgvProdutos.Name = "DgvProdutos";
            this.DgvProdutos.Size = new System.Drawing.Size(576, 132);
            this.DgvProdutos.TabIndex = 2;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnEditar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.Location = new System.Drawing.Point(190, 160);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(79, 42);
            this.BtnEditar.TabIndex = 10;
            this.BtnEditar.Text = "Editar Produto";
            this.BtnEditar.UseVisualStyleBackColor = false;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnExcluir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.BtnExcluir.ForeColor = System.Drawing.Color.White;
            this.BtnExcluir.Location = new System.Drawing.Point(100, 160);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(79, 42);
            this.BtnExcluir.TabIndex = 9;
            this.BtnExcluir.Text = "Excluir Produto";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnCadastrar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.BtnCadastrar.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCadastrar.Location = new System.Drawing.Point(10, 160);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(79, 42);
            this.BtnCadastrar.TabIndex = 7;
            this.BtnCadastrar.Text = "Cadastrar Produto";
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // PnGrey
            // 
            this.PnGrey.BackColor = System.Drawing.Color.Silver;
            this.PnGrey.Controls.Add(this.pnBlue);
            this.PnGrey.Location = new System.Drawing.Point(332, 197);
            this.PnGrey.Name = "PnGrey";
            this.PnGrey.Size = new System.Drawing.Size(200, 3);
            this.PnGrey.TabIndex = 13;
            // 
            // pnBlue
            // 
            this.pnBlue.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnBlue.Location = new System.Drawing.Point(40, 0);
            this.pnBlue.Name = "pnBlue";
            this.pnBlue.Size = new System.Drawing.Size(0, 3);
            this.pnBlue.TabIndex = 7;
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.BackColor = System.Drawing.SystemColors.Control;
            this.TxtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPesquisa.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.TxtPesquisa.ForeColor = System.Drawing.Color.Silver;
            this.TxtPesquisa.Location = new System.Drawing.Point(332, 181);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(200, 16);
            this.TxtPesquisa.TabIndex = 12;
            // 
            // PbSearch
            // 
            this.PbSearch.Image = global::Loja.Properties.Resources.SearcIconh;
            this.PbSearch.Location = new System.Drawing.Point(286, 160);
            this.PbSearch.Name = "PbSearch";
            this.PbSearch.Size = new System.Drawing.Size(40, 40);
            this.PbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbSearch.TabIndex = 11;
            this.PbSearch.TabStop = false;
            // 
            // FormEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 355);
            this.Controls.Add(this.PnGrey);
            this.Controls.Add(this.TxtPesquisa);
            this.Controls.Add(this.PbSearch);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.DgvProdutos);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.PbExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.FormEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).EndInit();
            this.PnGrey.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbExit;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.DataGridView DgvProdutos;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Panel PnGrey;
        private System.Windows.Forms.Panel pnBlue;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.PictureBox PbSearch;
    }
}