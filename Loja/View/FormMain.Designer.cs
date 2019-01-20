namespace Loja.View
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.PbExit = new System.Windows.Forms.PictureBox();
            this.PnMenu = new System.Windows.Forms.Panel();
            this.LblRelatorio = new System.Windows.Forms.Label();
            this.LblEstoque = new System.Windows.Forms.Label();
            this.LblVenda = new System.Windows.Forms.Label();
            this.LblFuncionario = new System.Windows.Forms.Label();
            this.PbAjuda = new System.Windows.Forms.PictureBox();
            this.PbRelatorio = new System.Windows.Forms.PictureBox();
            this.PbEstoque = new System.Windows.Forms.PictureBox();
            this.PbVenda = new System.Windows.Forms.PictureBox();
            this.PbFuncionario = new System.Windows.Forms.PictureBox();
            this.PbMenu = new System.Windows.Forms.PictureBox();
            this.PbJubileu = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.PbFala = new System.Windows.Forms.PictureBox();
            this.LblFala = new System.Windows.Forms.Label();
            this.TimerMenu = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PbExit)).BeginInit();
            this.PnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbAjuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbRelatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbJubileu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbFala)).BeginInit();
            this.SuspendLayout();
            // 
            // PbExit
            // 
            this.PbExit.Image = global::Loja.Properties.Resources.IconExit;
            this.PbExit.Location = new System.Drawing.Point(659, 12);
            this.PbExit.Name = "PbExit";
            this.PbExit.Size = new System.Drawing.Size(48, 41);
            this.PbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbExit.TabIndex = 0;
            this.PbExit.TabStop = false;
            this.PbExit.Click += new System.EventHandler(this.PbExit_Click);
            // 
            // PnMenu
            // 
            this.PnMenu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.PnMenu.Controls.Add(this.LblRelatorio);
            this.PnMenu.Controls.Add(this.LblEstoque);
            this.PnMenu.Controls.Add(this.LblVenda);
            this.PnMenu.Controls.Add(this.LblFuncionario);
            this.PnMenu.Controls.Add(this.PbAjuda);
            this.PnMenu.Controls.Add(this.PbRelatorio);
            this.PnMenu.Controls.Add(this.PbEstoque);
            this.PnMenu.Controls.Add(this.PbVenda);
            this.PnMenu.Controls.Add(this.PbFuncionario);
            this.PnMenu.Location = new System.Drawing.Point(-140, 0);
            this.PnMenu.Name = "PnMenu";
            this.PnMenu.Size = new System.Drawing.Size(137, 432);
            this.PnMenu.TabIndex = 1;
            // 
            // LblRelatorio
            // 
            this.LblRelatorio.AutoSize = true;
            this.LblRelatorio.Location = new System.Drawing.Point(36, 398);
            this.LblRelatorio.Name = "LblRelatorio";
            this.LblRelatorio.Size = new System.Drawing.Size(54, 13);
            this.LblRelatorio.TabIndex = 8;
            this.LblRelatorio.Text = "Relatórios";
            // 
            // LblEstoque
            // 
            this.LblEstoque.AutoSize = true;
            this.LblEstoque.Location = new System.Drawing.Point(41, 305);
            this.LblEstoque.Name = "LblEstoque";
            this.LblEstoque.Size = new System.Drawing.Size(46, 13);
            this.LblEstoque.TabIndex = 7;
            this.LblEstoque.Text = "Estoque";
            this.LblEstoque.Click += new System.EventHandler(this.LblEstoque_Click);
            // 
            // LblVenda
            // 
            this.LblVenda.AutoSize = true;
            this.LblVenda.Location = new System.Drawing.Point(45, 211);
            this.LblVenda.Name = "LblVenda";
            this.LblVenda.Size = new System.Drawing.Size(38, 13);
            this.LblVenda.TabIndex = 6;
            this.LblVenda.Text = "Venda";
            // 
            // LblFuncionario
            // 
            this.LblFuncionario.AutoSize = true;
            this.LblFuncionario.Location = new System.Drawing.Point(36, 114);
            this.LblFuncionario.Name = "LblFuncionario";
            this.LblFuncionario.Size = new System.Drawing.Size(62, 13);
            this.LblFuncionario.TabIndex = 5;
            this.LblFuncionario.Text = "Funcionário";
            this.LblFuncionario.Click += new System.EventHandler(this.LblFuncionario_Click);
            // 
            // PbAjuda
            // 
            this.PbAjuda.Image = global::Loja.Properties.Resources.IconeHelp;
            this.PbAjuda.Location = new System.Drawing.Point(3, 3);
            this.PbAjuda.Name = "PbAjuda";
            this.PbAjuda.Size = new System.Drawing.Size(30, 28);
            this.PbAjuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbAjuda.TabIndex = 4;
            this.PbAjuda.TabStop = false;
            this.PbAjuda.Click += new System.EventHandler(this.PbAjuda_Click);
            this.PbAjuda.MouseHover += new System.EventHandler(this.PbAjuda_MouseHover);
            // 
            // PbRelatorio
            // 
            this.PbRelatorio.Image = global::Loja.Properties.Resources.IconRelatorio;
            this.PbRelatorio.Location = new System.Drawing.Point(31, 333);
            this.PbRelatorio.Name = "PbRelatorio";
            this.PbRelatorio.Size = new System.Drawing.Size(71, 62);
            this.PbRelatorio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbRelatorio.TabIndex = 3;
            this.PbRelatorio.TabStop = false;
            // 
            // PbEstoque
            // 
            this.PbEstoque.Image = global::Loja.Properties.Resources.IconEstoque;
            this.PbEstoque.Location = new System.Drawing.Point(31, 239);
            this.PbEstoque.Name = "PbEstoque";
            this.PbEstoque.Size = new System.Drawing.Size(71, 61);
            this.PbEstoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbEstoque.TabIndex = 2;
            this.PbEstoque.TabStop = false;
            this.PbEstoque.Click += new System.EventHandler(this.PbEstoque_Click);
            // 
            // PbVenda
            // 
            this.PbVenda.Image = global::Loja.Properties.Resources.IconVenda;
            this.PbVenda.Location = new System.Drawing.Point(31, 145);
            this.PbVenda.Name = "PbVenda";
            this.PbVenda.Size = new System.Drawing.Size(70, 63);
            this.PbVenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbVenda.TabIndex = 1;
            this.PbVenda.TabStop = false;
            // 
            // PbFuncionario
            // 
            this.PbFuncionario.Image = global::Loja.Properties.Resources.IconFuncionario;
            this.PbFuncionario.Location = new System.Drawing.Point(31, 52);
            this.PbFuncionario.Name = "PbFuncionario";
            this.PbFuncionario.Size = new System.Drawing.Size(70, 59);
            this.PbFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbFuncionario.TabIndex = 0;
            this.PbFuncionario.TabStop = false;
            this.PbFuncionario.Click += new System.EventHandler(this.PbFuncionario_Click);
            // 
            // PbMenu
            // 
            this.PbMenu.BackColor = System.Drawing.SystemColors.Control;
            this.PbMenu.Image = global::Loja.Properties.Resources.IconMenu;
            this.PbMenu.Location = new System.Drawing.Point(2, 2);
            this.PbMenu.Name = "PbMenu";
            this.PbMenu.Size = new System.Drawing.Size(48, 46);
            this.PbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbMenu.TabIndex = 9;
            this.PbMenu.TabStop = false;
            this.PbMenu.Click += new System.EventHandler(this.PbMenu_Click_1);
            // 
            // PbJubileu
            // 
            this.PbJubileu.Image = global::Loja.Properties.Resources.jubileuRender;
            this.PbJubileu.Location = new System.Drawing.Point(247, 114);
            this.PbJubileu.Name = "PbJubileu";
            this.PbJubileu.Size = new System.Drawing.Size(216, 268);
            this.PbJubileu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbJubileu.TabIndex = 10;
            this.PbJubileu.TabStop = false;
            this.PbJubileu.Click += new System.EventHandler(this.PbJubileu_Click);
            this.PbJubileu.MouseEnter += new System.EventHandler(this.PbJubileu_MouseEnter);
            this.PbJubileu.MouseLeave += new System.EventHandler(this.PbJubileu_MouseLeave);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(184, 25);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(336, 28);
            this.LblTitulo.TabIndex = 11;
            this.LblTitulo.Text = "O jubileu te da boas vindas :D";
            // 
            // PbFala
            // 
            this.PbFala.BackColor = System.Drawing.Color.Transparent;
            this.PbFala.Image = global::Loja.Properties.Resources.falaJubileu;
            this.PbFala.Location = new System.Drawing.Point(426, 72);
            this.PbFala.Name = "PbFala";
            this.PbFala.Size = new System.Drawing.Size(205, 104);
            this.PbFala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbFala.TabIndex = 12;
            this.PbFala.TabStop = false;
            this.PbFala.Visible = false;
            // 
            // LblFala
            // 
            this.LblFala.AutoSize = true;
            this.LblFala.BackColor = System.Drawing.Color.White;
            this.LblFala.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFala.Location = new System.Drawing.Point(478, 94);
            this.LblFala.Name = "LblFala";
            this.LblFala.Size = new System.Drawing.Size(123, 42);
            this.LblFala.TabIndex = 13;
            this.LblFala.Text = "Você falou\r\n em pipoca?";
            this.LblFala.Visible = false;
            // 
            // TimerMenu
            // 
            this.TimerMenu.Interval = 10;
            this.TimerMenu.Tick += new System.EventHandler(this.TimerMenu_Tick_1);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(719, 433);
            this.Controls.Add(this.LblFala);
            this.Controls.Add(this.PbFala);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.PbJubileu);
            this.Controls.Add(this.PnMenu);
            this.Controls.Add(this.PbExit);
            this.Controls.Add(this.PbMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbExit)).EndInit();
            this.PnMenu.ResumeLayout(false);
            this.PnMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbAjuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbRelatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbJubileu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbFala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbExit;
        private System.Windows.Forms.Panel PnMenu;
        private System.Windows.Forms.PictureBox PbAjuda;
        private System.Windows.Forms.PictureBox PbRelatorio;
        private System.Windows.Forms.PictureBox PbEstoque;
        private System.Windows.Forms.PictureBox PbVenda;
        private System.Windows.Forms.PictureBox PbFuncionario;
        private System.Windows.Forms.Label LblRelatorio;
        private System.Windows.Forms.Label LblEstoque;
        private System.Windows.Forms.Label LblVenda;
        private System.Windows.Forms.Label LblFuncionario;
        private System.Windows.Forms.PictureBox PbMenu;
        private System.Windows.Forms.PictureBox PbJubileu;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.PictureBox PbFala;
        private System.Windows.Forms.Label LblFala;
        private System.Windows.Forms.Timer TimerMenu;
    }
}