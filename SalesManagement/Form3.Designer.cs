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
            ((System.ComponentModel.ISupportInitialize)ListaComerciais).BeginInit();
            SuspendLayout();
            // 
            // btnVoltar
            // 
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
            btnNovoComercial.Location = new Point(12, 77);
            btnNovoComercial.Name = "btnNovoComercial";
            btnNovoComercial.Size = new Size(136, 23);
            btnNovoComercial.TabIndex = 3;
            btnNovoComercial.Text = "Novo Comercial";
            btnNovoComercial.UseVisualStyleBackColor = true;
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
            // FormVendedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListaComerciais);
            Controls.Add(btnNovoComercial);
            Controls.Add(btnVoltar);
            Name = "FormVendedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Painel de Vendedores";
            ((System.ComponentModel.ISupportInitialize)ListaComerciais).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVoltar;
        private Button btnNovoComercial;
        private DataGridView ListaComerciais;
    }
}