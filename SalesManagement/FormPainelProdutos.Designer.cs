namespace SalesManagement
{
    partial class FormProdutos
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
            btnLimpar = new Button();
            inputPesquisa = new TextBox();
            btnPesquisar = new Button();
            btnSair = new Button();
            ListaProdutos = new DataGridView();
            btnNovoProduto = new Button();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)ListaProdutos).BeginInit();
            SuspendLayout();
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(837, 101);
            btnLimpar.Margin = new Padding(3, 4, 3, 4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(64, 35);
            btnLimpar.TabIndex = 22;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // inputPesquisa
            // 
            inputPesquisa.Location = new Point(404, 105);
            inputPesquisa.Margin = new Padding(3, 4, 3, 4);
            inputPesquisa.Name = "inputPesquisa";
            inputPesquisa.PlaceholderText = "Pesquise por nome ou código ou categoria";
            inputPesquisa.Size = new Size(293, 27);
            inputPesquisa.TabIndex = 16;
            inputPesquisa.TextChanged += inputPesquisa_TextChanged;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(744, 101);
            btnPesquisar.Margin = new Padding(3, 4, 3, 4);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(86, 35);
            btnPesquisar.TabIndex = 21;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(815, 14);
            btnSair.Margin = new Padding(3, 4, 3, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(86, 31);
            btnSair.TabIndex = 20;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // ListaProdutos
            // 
            ListaProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListaProdutos.Location = new Point(14, 143);
            ListaProdutos.Margin = new Padding(3, 4, 3, 4);
            ListaProdutos.Name = "ListaProdutos";
            ListaProdutos.RowHeadersWidth = 51;
            ListaProdutos.Size = new Size(887, 443);
            ListaProdutos.TabIndex = 19;
            // 
            // btnNovoProduto
            // 
            btnNovoProduto.Location = new Point(14, 101);
            btnNovoProduto.Margin = new Padding(3, 4, 3, 4);
            btnNovoProduto.Name = "btnNovoProduto";
            btnNovoProduto.Size = new Size(155, 31);
            btnNovoProduto.TabIndex = 18;
            btnNovoProduto.Text = "Novo Produto";
            btnNovoProduto.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(14, 14);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(86, 31);
            btnVoltar.TabIndex = 17;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // FormProdutos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnLimpar);
            Controls.Add(inputPesquisa);
            Controls.Add(btnPesquisar);
            Controls.Add(btnSair);
            Controls.Add(ListaProdutos);
            Controls.Add(btnNovoProduto);
            Controls.Add(btnVoltar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Painel de Produtos";
            Load += FormProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)ListaProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpar;
        private TextBox inputPesquisa;
        private Button btnPesquisar;
        private Button btnSair;
        private DataGridView ListaProdutos;
        private Button btnNovoProduto;
        private Button btnVoltar;
    }
}