namespace SalesManagement
{
    partial class FormInicial
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
            button1 = new Button();
            btnProdutos = new Button();
            btnVendas = new Button();
            label1 = new Label();
            btnUtilizadores = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(313, 158);
            button1.Name = "button1";
            button1.Size = new Size(156, 36);
            button1.TabIndex = 0;
            button1.Text = "Gestão de Vendedores";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.Location = new Point(313, 200);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(156, 33);
            btnProdutos.TabIndex = 1;
            btnProdutos.Text = "Gestão de Produtos";
            btnProdutos.UseVisualStyleBackColor = true;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnVendas
            // 
            btnVendas.Location = new Point(313, 239);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(156, 35);
            btnVendas.TabIndex = 2;
            btnVendas.Text = "Gestão de Vendas";
            btnVendas.UseVisualStyleBackColor = true;
            btnVendas.Click += btnVendas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(316, 110);
            label1.Name = "label1";
            label1.Size = new Size(153, 15);
            label1.TabIndex = 3;
            label1.Text = "Bem vindo, NomeUtilizador";
            // 
            // btnUtilizadores
            // 
            btnUtilizadores.Location = new Point(313, 280);
            btnUtilizadores.Name = "btnUtilizadores";
            btnUtilizadores.Size = new Size(156, 35);
            btnUtilizadores.TabIndex = 4;
            btnUtilizadores.Text = "Gestão de Utilizadores";
            btnUtilizadores.UseVisualStyleBackColor = true;
            // 
            // FormInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUtilizadores);
            Controls.Add(label1);
            Controls.Add(btnVendas);
            Controls.Add(btnProdutos);
            Controls.Add(button1);
            Name = "FormInicial";
            Text = "Gestão de Vendas";
            Load += FormInicial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnProdutos;
        private Button btnVendas;
        private Label label1;
        private Button btnUtilizadores;
    }
}