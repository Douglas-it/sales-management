namespace SalesManagement
{
    partial class FormVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVendas));
            btnVoltar = new Button();
            btnSair = new Button();
            btnLimpar = new Button();
            inputPesquisa = new TextBox();
            btnPesquisar = new Button();
            ListaVendas = new DataGridView();
            btnVenda = new Button();
            ((System.ComponentModel.ISupportInitialize)ListaVendas).BeginInit();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.Location = new Point(12, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 1;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnSair
            // 
            btnSair.Cursor = Cursors.Hand;
            btnSair.Location = new Point(919, 12);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 13;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Cursor = Cursors.Hand;
            btnLimpar.Location = new Point(940, 74);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(56, 26);
            btnLimpar.TabIndex = 20;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // inputPesquisa
            // 
            inputPesquisa.Cursor = Cursors.IBeam;
            inputPesquisa.Location = new Point(596, 75);
            inputPesquisa.Name = "inputPesquisa";
            inputPesquisa.PlaceholderText = "Pesquise por nome, código ou comissão";
            inputPesquisa.Size = new Size(257, 23);
            inputPesquisa.TabIndex = 16;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Cursor = Cursors.Hand;
            btnPesquisar.Location = new Point(859, 74);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 26);
            btnPesquisar.TabIndex = 19;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // ListaVendas
            // 
            ListaVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListaVendas.Location = new Point(12, 106);
            ListaVendas.Name = "ListaVendas";
            ListaVendas.Size = new Size(984, 444);
            ListaVendas.TabIndex = 18;
            ListaVendas.CellContentClick += ListaVendas_CellContentClick;
            // 
            // btnVenda
            // 
            btnVenda.Cursor = Cursors.Hand;
            btnVenda.Location = new Point(12, 74);
            btnVenda.Name = "btnVenda";
            btnVenda.Size = new Size(91, 23);
            btnVenda.TabIndex = 17;
            btnVenda.Text = "Venda";
            btnVenda.UseVisualStyleBackColor = true;
            btnVenda.Click += btnVenda_Click;
            // 
            // FormVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 562);
            Controls.Add(btnLimpar);
            Controls.Add(inputPesquisa);
            Controls.Add(btnPesquisar);
            Controls.Add(ListaVendas);
            Controls.Add(btnVenda);
            Controls.Add(btnSair);
            Controls.Add(btnVoltar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormVendas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Painel de Vendas";
            Load += FormVendas_Load;
            ((System.ComponentModel.ISupportInitialize)ListaVendas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private Button btnSair;
        private Button btnLimpar;
        private TextBox inputPesquisa;
        private Button btnPesquisar;
        private DataGridView ListaVendas;
        private Button btnVenda;
    }
}