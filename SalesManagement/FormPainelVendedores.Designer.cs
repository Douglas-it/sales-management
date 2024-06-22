namespace SalesManagement
{
    partial class FormVendedores
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
            btnVoltar = new Button();
            btnNovoComercial = new Button();
            ListaComerciais = new DataGridView();
            btnSair = new Button();
            btnPesquisar = new Button();
            inputPesquisa = new TextBox();
            btnLimpar = new Button();
            ((System.ComponentModel.ISupportInitialize)ListaComerciais).BeginInit();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.Location = new Point(12, 9);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnNovoComercial
            // 
            btnNovoComercial.Cursor = Cursors.Hand;
            btnNovoComercial.Location = new Point(12, 74);
            btnNovoComercial.Name = "btnNovoComercial";
            btnNovoComercial.Size = new Size(136, 23);
            btnNovoComercial.TabIndex = 3;
            btnNovoComercial.Text = "Novo Comercial";
            btnNovoComercial.UseVisualStyleBackColor = true;
            btnNovoComercial.Click += btnNovoComercial_Click;
            // 
            // ListaComerciais
            // 
            ListaComerciais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListaComerciais.Location = new Point(12, 106);
            ListaComerciais.Name = "ListaComerciais";
            ListaComerciais.Size = new Size(776, 332);
            ListaComerciais.TabIndex = 4;
            ListaComerciais.CellContentClick += ListaComerciais_CellContentClick;
            // 
            // btnSair
            // 
            btnSair.Cursor = Cursors.Hand;
            btnSair.Location = new Point(713, 9);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 13;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Cursor = Cursors.Hand;
            btnPesquisar.Location = new Point(651, 74);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 26);
            btnPesquisar.TabIndex = 14;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // inputPesquisa
            // 
            inputPesquisa.Cursor = Cursors.IBeam;
            inputPesquisa.Location = new Point(388, 75);
            inputPesquisa.Name = "inputPesquisa";
            inputPesquisa.PlaceholderText = "Pesquise por nome, código ou comissão";
            inputPesquisa.Size = new Size(257, 23);
            inputPesquisa.TabIndex = 0;
            // 
            // btnLimpar
            // 
            btnLimpar.Cursor = Cursors.Hand;
            btnLimpar.Location = new Point(732, 74);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(56, 26);
            btnLimpar.TabIndex = 15;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // FormVendedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpar);
            Controls.Add(inputPesquisa);
            Controls.Add(btnPesquisar);
            Controls.Add(btnSair);
            Controls.Add(ListaComerciais);
            Controls.Add(btnNovoComercial);
            Controls.Add(btnVoltar);
            Name = "FormVendedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Painel de Vendedores";
            Load += FormVendedores_Load;
            ((System.ComponentModel.ISupportInitialize)ListaComerciais).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private Button btnNovoComercial;
        private DataGridView ListaComerciais;
        private Button btnSair;
        private Button btnPesquisar;
        private TextBox inputPesquisa;
        private Button btnLimpar;
    }
}