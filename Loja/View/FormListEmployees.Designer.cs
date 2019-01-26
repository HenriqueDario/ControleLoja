namespace Loja.View
{
    partial class FormListEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListEmployees));
            this.PbExit = new System.Windows.Forms.PictureBox();
            this.DgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.PbSearch = new System.Windows.Forms.PictureBox();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.PnGrey = new System.Windows.Forms.Panel();
            this.PnBlue = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSearch)).BeginInit();
            this.PnGrey.SuspendLayout();
            this.SuspendLayout();
            // 
            // PbExit
            // 
            this.PbExit.Image = global::Loja.Properties.Resources.IconExit;
            this.PbExit.Location = new System.Drawing.Point(608, 12);
            this.PbExit.Name = "PbExit";
            this.PbExit.Size = new System.Drawing.Size(48, 39);
            this.PbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbExit.TabIndex = 0;
            this.PbExit.TabStop = false;
            this.PbExit.Click += new System.EventHandler(this.PbExit_Click);
            // 
            // DgvFuncionarios
            // 
            this.DgvFuncionarios.AllowUserToAddRows = false;
            this.DgvFuncionarios.AllowUserToDeleteRows = false;
            this.DgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFuncionarios.Location = new System.Drawing.Point(12, 217);
            this.DgvFuncionarios.Name = "DgvFuncionarios";
            this.DgvFuncionarios.ReadOnly = true;
            this.DgvFuncionarios.Size = new System.Drawing.Size(644, 141);
            this.DgvFuncionarios.TabIndex = 1;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(269, 12);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(123, 22);
            this.LblTitulo.TabIndex = 2;
            this.LblTitulo.Text = "Funcionários";
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnCadastrar.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.BtnCadastrar.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCadastrar.Location = new System.Drawing.Point(12, 162);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(80, 40);
            this.BtnCadastrar.TabIndex = 1;
            this.BtnCadastrar.Text = "Cadastrar Funcionário";
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnExcluir.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.BtnExcluir.ForeColor = System.Drawing.Color.White;
            this.BtnExcluir.Location = new System.Drawing.Point(112, 162);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(80, 40);
            this.BtnExcluir.TabIndex = 2;
            this.BtnExcluir.Text = "Excluir Funcionário";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnEditar.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.Location = new System.Drawing.Point(212, 162);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(80, 40);
            this.BtnEditar.TabIndex = 3;
            this.BtnEditar.Text = "Editar Funcionário";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // PbSearch
            // 
            this.PbSearch.Image = global::Loja.Properties.Resources.SearcIconh;
            this.PbSearch.Location = new System.Drawing.Point(315, 162);
            this.PbSearch.Name = "PbSearch";
            this.PbSearch.Size = new System.Drawing.Size(40, 40);
            this.PbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbSearch.TabIndex = 4;
            this.PbSearch.TabStop = false;
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.BackColor = System.Drawing.SystemColors.Control;
            this.TxtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPesquisa.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.TxtPesquisa.ForeColor = System.Drawing.Color.Silver;
            this.TxtPesquisa.Location = new System.Drawing.Point(365, 182);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(200, 16);
            this.TxtPesquisa.TabIndex = 5;
            this.TxtPesquisa.TextChanged += new System.EventHandler(this.TxtPesquisa_TextChanged);
            this.TxtPesquisa.Enter += new System.EventHandler(this.TxtPesquisa_Enter);
            this.TxtPesquisa.Leave += new System.EventHandler(this.TxtPesquisa_Leave);
            // 
            // PnGrey
            // 
            this.PnGrey.BackColor = System.Drawing.Color.Silver;
            this.PnGrey.Controls.Add(this.PnBlue);
            this.PnGrey.Location = new System.Drawing.Point(365, 201);
            this.PnGrey.Name = "PnGrey";
            this.PnGrey.Size = new System.Drawing.Size(200, 3);
            this.PnGrey.TabIndex = 6;
            // 
            // PnBlue
            // 
            this.PnBlue.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PnBlue.Location = new System.Drawing.Point(40, 0);
            this.PnBlue.Name = "PnBlue";
            this.PnBlue.Size = new System.Drawing.Size(0, 3);
            this.PnBlue.TabIndex = 7;
            // 
            // FormListEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 384);
            this.Controls.Add(this.PnGrey);
            this.Controls.Add(this.TxtPesquisa);
            this.Controls.Add(this.PbSearch);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.DgvFuncionarios);
            this.Controls.Add(this.PbExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionarios";
            this.Load += new System.EventHandler(this.FormListEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSearch)).EndInit();
            this.PnGrey.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbExit;
        private System.Windows.Forms.DataGridView DgvFuncionarios;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.PictureBox PbSearch;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.Panel PnGrey;
        private System.Windows.Forms.Panel PnBlue;
    }
}