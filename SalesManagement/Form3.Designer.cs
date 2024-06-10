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
            listComerciais = new ListView();
            btnNovoComercial = new Button();
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
            // listComerciais
            // 
            listComerciais.Location = new Point(12, 106);
            listComerciais.Name = "listComerciais";
            listComerciais.Size = new Size(776, 332);
            listComerciais.TabIndex = 2;
            listComerciais.UseCompatibleStateImageBehavior = false;
            listComerciais.SelectedIndexChanged += listComerciais_SelectedIndexChanged;
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
            // FormVendedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNovoComercial);
            Controls.Add(listComerciais);
            Controls.Add(btnVoltar);
            Name = "FormVendedores";
            Text = "Painel de Vendedores";
            ResumeLayout(false);
        }

        #endregion

        private Button btnVoltar;
        private ListView listComerciais;
        private Button btnNovoComercial;
    }
}