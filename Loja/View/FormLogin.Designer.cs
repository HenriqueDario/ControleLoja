namespace Loja.View
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblLogin = new System.Windows.Forms.Label();
            this.LblSenha = new System.Windows.Forms.Label();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.PbExit = new System.Windows.Forms.PictureBox();
            this.TimerEntrarLogin = new System.Windows.Forms.Timer(this.components);
            this.TimerSairLogin = new System.Windows.Forms.Timer(this.components);
            this.PnBlackLogin = new System.Windows.Forms.Panel();
            this.PnBlueLogin = new System.Windows.Forms.Panel();
            this.TimerSairSenha = new System.Windows.Forms.Timer(this.components);
            this.TimerEntrarSenha = new System.Windows.Forms.Timer(this.components);
            this.PnBlackSenha = new System.Windows.Forms.Panel();
            this.PnBlueSenha = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(150, 27);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(146, 22);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Loja do Jubileu";
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.BackColor = System.Drawing.Color.Transparent;
            this.LblLogin.Font = new System.Drawing.Font("Arial Black", 9F);
            this.LblLogin.Location = new System.Drawing.Point(105, 110);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(48, 17);
            this.LblLogin.TabIndex = 1;
            this.LblLogin.Text = "Login:";
            this.LblLogin.Click += new System.EventHandler(this.LblLogin_Click);
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.BackColor = System.Drawing.Color.Transparent;
            this.LblSenha.Font = new System.Drawing.Font("Arial Black", 9F);
            this.LblSenha.Location = new System.Drawing.Point(105, 175);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(53, 17);
            this.LblSenha.TabIndex = 2;
            this.LblSenha.Text = "Senha:";
            this.LblSenha.Click += new System.EventHandler(this.LblSenha_Click);
            // 
            // TxtLogin
            // 
            this.TxtLogin.BackColor = System.Drawing.SystemColors.Control;
            this.TxtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLogin.Location = new System.Drawing.Point(105, 113);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(240, 13);
            this.TxtLogin.TabIndex = 1;
            this.TxtLogin.Enter += new System.EventHandler(this.TxtLogin_Enter);
            this.TxtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLogin_KeyPress);
            this.TxtLogin.Leave += new System.EventHandler(this.TxtLogin_Leave);
            // 
            // TxtSenha
            // 
            this.TxtSenha.BackColor = System.Drawing.SystemColors.Control;
            this.TxtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSenha.Location = new System.Drawing.Point(105, 179);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(246, 13);
            this.TxtSenha.TabIndex = 2;
            this.TxtSenha.Enter += new System.EventHandler(this.TxtSenha_Enter);
            this.TxtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSenha_KeyPress);
            this.TxtSenha.Leave += new System.EventHandler(this.TxtSenha_Leave);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(173, 249);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(114, 32);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // PbExit
            // 
            this.PbExit.Image = global::Loja.Properties.Resources.IconExit;
            this.PbExit.Location = new System.Drawing.Point(396, 12);
            this.PbExit.Name = "PbExit";
            this.PbExit.Size = new System.Drawing.Size(45, 37);
            this.PbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbExit.TabIndex = 5;
            this.PbExit.TabStop = false;
            this.PbExit.Click += new System.EventHandler(this.PbExit_Click);
            // 
            // TimerEntrarLogin
            // 
            this.TimerEntrarLogin.Interval = 1;
            this.TimerEntrarLogin.Tick += new System.EventHandler(this.TimerEntrarLogin_Tick);
            // 
            // TimerSairLogin
            // 
            this.TimerSairLogin.Interval = 1;
            this.TimerSairLogin.Tick += new System.EventHandler(this.TimerSairLogin_Tick);
            // 
            // PnBlackLogin
            // 
            this.PnBlackLogin.BackColor = System.Drawing.Color.Black;
            this.PnBlackLogin.Location = new System.Drawing.Point(105, 132);
            this.PnBlackLogin.Name = "PnBlackLogin";
            this.PnBlackLogin.Size = new System.Drawing.Size(240, 2);
            this.PnBlackLogin.TabIndex = 6;
            // 
            // PnBlueLogin
            // 
            this.PnBlueLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PnBlueLogin.Location = new System.Drawing.Point(145, 132);
            this.PnBlueLogin.Name = "PnBlueLogin";
            this.PnBlueLogin.Size = new System.Drawing.Size(0, 2);
            this.PnBlueLogin.TabIndex = 7;
            // 
            // TimerSairSenha
            // 
            this.TimerSairSenha.Interval = 1;
            this.TimerSairSenha.Tick += new System.EventHandler(this.TimerSairSenha_Tick);
            // 
            // TimerEntrarSenha
            // 
            this.TimerEntrarSenha.Interval = 1;
            this.TimerEntrarSenha.Tick += new System.EventHandler(this.TimerEntrarSenha_Tick);
            // 
            // PnBlackSenha
            // 
            this.PnBlackSenha.BackColor = System.Drawing.Color.Black;
            this.PnBlackSenha.Location = new System.Drawing.Point(105, 195);
            this.PnBlackSenha.Name = "PnBlackSenha";
            this.PnBlackSenha.Size = new System.Drawing.Size(240, 2);
            this.PnBlackSenha.TabIndex = 7;
            // 
            // PnBlueSenha
            // 
            this.PnBlueSenha.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PnBlueSenha.Location = new System.Drawing.Point(145, 195);
            this.PnBlueSenha.Name = "PnBlueSenha";
            this.PnBlueSenha.Size = new System.Drawing.Size(0, 2);
            this.PnBlueSenha.TabIndex = 8;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 310);
            this.Controls.Add(this.PnBlueSenha);
            this.Controls.Add(this.PnBlackSenha);
            this.Controls.Add(this.PnBlueLogin);
            this.Controls.Add(this.PnBlackLogin);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.PbExit);
            this.Controls.Add(this.LblSenha);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.TxtLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.PictureBox PbExit;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Timer TimerEntrarLogin;
        private System.Windows.Forms.Timer TimerSairLogin;
        private System.Windows.Forms.Panel PnBlackLogin;
        private System.Windows.Forms.Panel PnBlueLogin;
        private System.Windows.Forms.Timer TimerSairSenha;
        private System.Windows.Forms.Timer TimerEntrarSenha;
        private System.Windows.Forms.Panel PnBlackSenha;
        private System.Windows.Forms.Panel PnBlueSenha;
    }
}