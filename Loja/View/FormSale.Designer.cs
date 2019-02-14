namespace Loja.View
{
    partial class FormSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSale));
            this.PnAddProduct = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblPrecoUnitario = new System.Windows.Forms.Label();
            this.LblQuantidade = new System.Windows.Forms.Label();
            this.LblCode = new System.Windows.Forms.Label();
            this.TxtPrecoTotal = new System.Windows.Forms.TextBox();
            this.TxtPrecoUnitario = new System.Windows.Forms.TextBox();
            this.TxtQuantidadeEstoque = new System.Windows.Forms.TextBox();
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.BtnRemoveProduct = new System.Windows.Forms.Button();
            this.BtnAddProduct = new System.Windows.Forms.Button();
            this.CmbProdutos = new System.Windows.Forms.ComboBox();
            this.PnProductsList = new System.Windows.Forms.Panel();
            this.LsvProductsList = new System.Windows.Forms.ListView();
            this.PbExit = new System.Windows.Forms.PictureBox();
            this.PnTotalObs = new System.Windows.Forms.Panel();
            this.TxtObservacao = new System.Windows.Forms.TextBox();
            this.LblTotalObs = new System.Windows.Forms.Label();
            this.BtnFinalizar = new System.Windows.Forms.Button();
            this.PnDadosVenda = new System.Windows.Forms.Panel();
            this.LblNumPedido = new System.Windows.Forms.Label();
            this.LblData = new System.Windows.Forms.Label();
            this.TimerHora = new System.Windows.Forms.Timer(this.components);
            this.PnAddProduct.SuspendLayout();
            this.PnProductsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbExit)).BeginInit();
            this.PnTotalObs.SuspendLayout();
            this.PnDadosVenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnAddProduct
            // 
            this.PnAddProduct.Controls.Add(this.label6);
            this.PnAddProduct.Controls.Add(this.label5);
            this.PnAddProduct.Controls.Add(this.LblPrecoUnitario);
            this.PnAddProduct.Controls.Add(this.LblQuantidade);
            this.PnAddProduct.Controls.Add(this.CmbProdutos);
            this.PnAddProduct.Controls.Add(this.LblCode);
            this.PnAddProduct.Controls.Add(this.TxtPrecoTotal);
            this.PnAddProduct.Controls.Add(this.TxtPrecoUnitario);
            this.PnAddProduct.Controls.Add(this.TxtQuantidadeEstoque);
            this.PnAddProduct.Controls.Add(this.TxtQuantidade);
            this.PnAddProduct.Controls.Add(this.TxtCode);
            this.PnAddProduct.Controls.Add(this.BtnRemoveProduct);
            this.PnAddProduct.Controls.Add(this.BtnAddProduct);
            this.PnAddProduct.Location = new System.Drawing.Point(498, 89);
            this.PnAddProduct.Name = "PnAddProduct";
            this.PnAddProduct.Size = new System.Drawing.Size(290, 343);
            this.PnAddProduct.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nome do produto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Preço Total:";
            // 
            // LblPrecoUnitario
            // 
            this.LblPrecoUnitario.AutoSize = true;
            this.LblPrecoUnitario.BackColor = System.Drawing.Color.Transparent;
            this.LblPrecoUnitario.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecoUnitario.Location = new System.Drawing.Point(19, 192);
            this.LblPrecoUnitario.Name = "LblPrecoUnitario";
            this.LblPrecoUnitario.Size = new System.Drawing.Size(106, 17);
            this.LblPrecoUnitario.TabIndex = 10;
            this.LblPrecoUnitario.Text = "Preço Unitário:";
            // 
            // LblQuantidade
            // 
            this.LblQuantidade.AutoSize = true;
            this.LblQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.LblQuantidade.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuantidade.Location = new System.Drawing.Point(19, 118);
            this.LblQuantidade.Name = "LblQuantidade";
            this.LblQuantidade.Size = new System.Drawing.Size(93, 17);
            this.LblQuantidade.TabIndex = 9;
            this.LblQuantidade.Text = "Quantidade:";
            // 
            // LblCode
            // 
            this.LblCode.AutoSize = true;
            this.LblCode.BackColor = System.Drawing.Color.Transparent;
            this.LblCode.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCode.Location = new System.Drawing.Point(19, 61);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(63, 17);
            this.LblCode.TabIndex = 8;
            this.LblCode.Text = "Código:";
            // 
            // TxtPrecoTotal
            // 
            this.TxtPrecoTotal.Location = new System.Drawing.Point(22, 262);
            this.TxtPrecoTotal.Name = "TxtPrecoTotal";
            this.TxtPrecoTotal.Size = new System.Drawing.Size(177, 20);
            this.TxtPrecoTotal.TabIndex = 7;
            // 
            // TxtPrecoUnitario
            // 
            this.TxtPrecoUnitario.Location = new System.Drawing.Point(22, 212);
            this.TxtPrecoUnitario.Name = "TxtPrecoUnitario";
            this.TxtPrecoUnitario.Size = new System.Drawing.Size(177, 20);
            this.TxtPrecoUnitario.TabIndex = 6;
            // 
            // TxtQuantidadeEstoque
            // 
            this.TxtQuantidadeEstoque.Enabled = false;
            this.TxtQuantidadeEstoque.Location = new System.Drawing.Point(150, 164);
            this.TxtQuantidadeEstoque.Name = "TxtQuantidadeEstoque";
            this.TxtQuantidadeEstoque.Size = new System.Drawing.Size(137, 20);
            this.TxtQuantidadeEstoque.TabIndex = 5;
            this.TxtQuantidadeEstoque.Text = "Qtd. em Estoque: ";
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.Location = new System.Drawing.Point(22, 138);
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.Size = new System.Drawing.Size(177, 20);
            this.TxtQuantidade.TabIndex = 4;
            // 
            // TxtCode
            // 
            this.TxtCode.Location = new System.Drawing.Point(22, 84);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(177, 20);
            this.TxtCode.TabIndex = 3;
            // 
            // BtnRemoveProduct
            // 
            this.BtnRemoveProduct.Location = new System.Drawing.Point(22, 304);
            this.BtnRemoveProduct.Name = "BtnRemoveProduct";
            this.BtnRemoveProduct.Size = new System.Drawing.Size(122, 27);
            this.BtnRemoveProduct.TabIndex = 2;
            this.BtnRemoveProduct.Text = "Remover produto";
            this.BtnRemoveProduct.UseVisualStyleBackColor = true;
            // 
            // BtnAddProduct
            // 
            this.BtnAddProduct.Location = new System.Drawing.Point(160, 304);
            this.BtnAddProduct.Name = "BtnAddProduct";
            this.BtnAddProduct.Size = new System.Drawing.Size(122, 27);
            this.BtnAddProduct.TabIndex = 1;
            this.BtnAddProduct.Text = "Adicionar produto";
            this.BtnAddProduct.UseVisualStyleBackColor = true;
            // 
            // CmbProdutos
            // 
            this.CmbProdutos.FormattingEnabled = true;
            this.CmbProdutos.Location = new System.Drawing.Point(22, 33);
            this.CmbProdutos.Name = "CmbProdutos";
            this.CmbProdutos.Size = new System.Drawing.Size(250, 21);
            this.CmbProdutos.TabIndex = 0;
            // 
            // PnProductsList
            // 
            this.PnProductsList.Controls.Add(this.LsvProductsList);
            this.PnProductsList.Location = new System.Drawing.Point(12, 89);
            this.PnProductsList.Name = "PnProductsList";
            this.PnProductsList.Size = new System.Drawing.Size(477, 299);
            this.PnProductsList.TabIndex = 1;
            // 
            // LsvProductsList
            // 
            this.LsvProductsList.BackColor = System.Drawing.Color.White;
            this.LsvProductsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvProductsList.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LsvProductsList.FullRowSelect = true;
            this.LsvProductsList.GridLines = true;
            this.LsvProductsList.Location = new System.Drawing.Point(3, 33);
            this.LsvProductsList.Name = "LsvProductsList";
            this.LsvProductsList.Size = new System.Drawing.Size(471, 263);
            this.LsvProductsList.TabIndex = 0;
            this.LsvProductsList.TileSize = new System.Drawing.Size(160, 30);
            this.LsvProductsList.UseCompatibleStateImageBehavior = false;
            this.LsvProductsList.View = System.Windows.Forms.View.Details;
            // 
            // PbExit
            // 
            this.PbExit.Image = global::Loja.Properties.Resources.IconExit;
            this.PbExit.Location = new System.Drawing.Point(744, 12);
            this.PbExit.Name = "PbExit";
            this.PbExit.Size = new System.Drawing.Size(44, 36);
            this.PbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbExit.TabIndex = 2;
            this.PbExit.TabStop = false;
            this.PbExit.Click += new System.EventHandler(this.PbExit_Click);
            // 
            // PnTotalObs
            // 
            this.PnTotalObs.BackColor = System.Drawing.Color.DarkTurquoise;
            this.PnTotalObs.Controls.Add(this.TxtObservacao);
            this.PnTotalObs.Controls.Add(this.LblTotalObs);
            this.PnTotalObs.Location = new System.Drawing.Point(28, 447);
            this.PnTotalObs.Name = "PnTotalObs";
            this.PnTotalObs.Size = new System.Drawing.Size(471, 40);
            this.PnTotalObs.TabIndex = 3;
            // 
            // TxtObservacao
            // 
            this.TxtObservacao.BackColor = System.Drawing.Color.White;
            this.TxtObservacao.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtObservacao.Location = new System.Drawing.Point(19, 10);
            this.TxtObservacao.Name = "TxtObservacao";
            this.TxtObservacao.Size = new System.Drawing.Size(190, 20);
            this.TxtObservacao.TabIndex = 1;
            this.TxtObservacao.Text = "Observações";
            // 
            // LblTotalObs
            // 
            this.LblTotalObs.AutoSize = true;
            this.LblTotalObs.Font = new System.Drawing.Font("Century Gothic", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalObs.ForeColor = System.Drawing.Color.White;
            this.LblTotalObs.Location = new System.Drawing.Point(273, 8);
            this.LblTotalObs.Name = "LblTotalObs";
            this.LblTotalObs.Size = new System.Drawing.Size(103, 22);
            this.LblTotalObs.TabIndex = 0;
            this.LblTotalObs.Text = "SUBTOTAL: ";
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.Location = new System.Drawing.Point(648, 448);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(132, 40);
            this.BtnFinalizar.TabIndex = 4;
            this.BtnFinalizar.Text = "Finalizar Venda";
            this.BtnFinalizar.UseVisualStyleBackColor = true;
            // 
            // PnDadosVenda
            // 
            this.PnDadosVenda.Controls.Add(this.LblNumPedido);
            this.PnDadosVenda.Controls.Add(this.LblData);
            this.PnDadosVenda.Location = new System.Drawing.Point(15, 12);
            this.PnDadosVenda.Name = "PnDadosVenda";
            this.PnDadosVenda.Size = new System.Drawing.Size(723, 56);
            this.PnDadosVenda.TabIndex = 5;
            // 
            // LblNumPedido
            // 
            this.LblNumPedido.AutoSize = true;
            this.LblNumPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumPedido.Location = new System.Drawing.Point(27, 11);
            this.LblNumPedido.Name = "LblNumPedido";
            this.LblNumPedido.Size = new System.Drawing.Size(104, 25);
            this.LblNumPedido.TabIndex = 1;
            this.LblNumPedido.Text = "Pedido Nº ";
            // 
            // LblData
            // 
            this.LblData.AutoSize = true;
            this.LblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblData.Location = new System.Drawing.Point(403, 11);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(64, 25);
            this.LblData.TabIndex = 0;
            this.LblData.Text = "Data: ";
            // 
            // TimerHora
            // 
            this.TimerHora.Interval = 1;
            this.TimerHora.Tick += new System.EventHandler(this.TimerHora_Tick);
            // 
            // FormSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.PnDadosVenda);
            this.Controls.Add(this.BtnFinalizar);
            this.Controls.Add(this.PnTotalObs);
            this.Controls.Add(this.PbExit);
            this.Controls.Add(this.PnProductsList);
            this.Controls.Add(this.PnAddProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.FormSale_Load);
            this.PnAddProduct.ResumeLayout(false);
            this.PnAddProduct.PerformLayout();
            this.PnProductsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbExit)).EndInit();
            this.PnTotalObs.ResumeLayout(false);
            this.PnTotalObs.PerformLayout();
            this.PnDadosVenda.ResumeLayout(false);
            this.PnDadosVenda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnAddProduct;
        private System.Windows.Forms.ComboBox CmbProdutos;
        private System.Windows.Forms.Panel PnProductsList;
        private System.Windows.Forms.PictureBox PbExit;
        private System.Windows.Forms.ListView LsvProductsList;
        private System.Windows.Forms.Button BtnRemoveProduct;
        private System.Windows.Forms.Button BtnAddProduct;
        private System.Windows.Forms.TextBox TxtPrecoTotal;
        private System.Windows.Forms.TextBox TxtPrecoUnitario;
        private System.Windows.Forms.TextBox TxtQuantidadeEstoque;
        private System.Windows.Forms.TextBox TxtQuantidade;
        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.Panel PnTotalObs;
        private System.Windows.Forms.TextBox TxtObservacao;
        private System.Windows.Forms.Label LblTotalObs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblPrecoUnitario;
        private System.Windows.Forms.Label LblQuantidade;
        private System.Windows.Forms.Label LblCode;
        private System.Windows.Forms.Button BtnFinalizar;
        private System.Windows.Forms.Panel PnDadosVenda;
        private System.Windows.Forms.Label LblNumPedido;
        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.Timer TimerHora;
    }
}