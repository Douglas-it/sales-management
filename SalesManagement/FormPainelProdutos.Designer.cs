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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdutos));
            btnLimpar = new Button();
            inputPesquisa = new TextBox();
            btnPesquisar = new Button();
            btnSair = new Button();
            ListaProdutos = new DataGridView();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)ListaProdutos).BeginInit();
            SuspendLayout();
            // 
            // btnLimpar
            // 
            btnLimpar.Cursor = Cursors.Hand;
            btnLimpar.Location = new Point(732, 76);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(56, 26);
            btnLimpar.TabIndex = 22;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // inputPesquisa
            // 
            inputPesquisa.Cursor = Cursors.IBeam;
            inputPesquisa.Location = new Point(354, 79);
            inputPesquisa.Name = "inputPesquisa";
            inputPesquisa.PlaceholderText = "Pesquise por nome ou código ou categoria";
            inputPesquisa.Size = new Size(292, 23);
            inputPesquisa.TabIndex = 16;
            inputPesquisa.TextChanged += inputPesquisa_TextChanged;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Cursor = Cursors.Hand;
            btnPesquisar.Location = new Point(651, 76);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 26);
            btnPesquisar.TabIndex = 21;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnSair
            // 
            btnSair.Cursor = Cursors.Hand;
            btnSair.Location = new Point(713, 10);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 20;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // ListaProdutos
            // 
            ListaProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListaProdutos.Location = new Point(12, 107);
            ListaProdutos.Name = "ListaProdutos";
            ListaProdutos.RowHeadersWidth = 51;
            ListaProdutos.Size = new Size(776, 332);
            ListaProdutos.TabIndex = 19;
            ListaProdutos.CellContentClick += ListaProdutos_CellContentClick;
            // 
            // btnVoltar
            // 
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.Location = new Point(12, 10);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 17;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FormProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpar);
            Controls.Add(inputPesquisa);
            Controls.Add(btnPesquisar);
            Controls.Add(btnSair);
            Controls.Add(ListaProdutos);
            Controls.Add(btnVoltar);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Button btnVoltar;
    }
}