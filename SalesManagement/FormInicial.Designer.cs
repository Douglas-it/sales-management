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
            label5 = new Label();
            label4 = new Label();
            btnSair = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(328, 170);
            button1.Name = "button1";
            button1.Size = new Size(156, 36);
            button1.TabIndex = 0;
            button1.Text = "Gestão de Vendedores";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.Location = new Point(328, 212);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(156, 33);
            btnProdutos.TabIndex = 1;
            btnProdutos.Text = "Gestão de Produtos";
            btnProdutos.UseVisualStyleBackColor = true;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnVendas
            // 
            btnVendas.Location = new Point(328, 251);
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
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(361, 133);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 3;
            label1.Text = "Bem vindo";
            label1.Click += label1_Click;
            // 
            // btnUtilizadores
            // 
            btnUtilizadores.Location = new Point(328, 292);
            btnUtilizadores.Name = "btnUtilizadores";
            btnUtilizadores.Size = new Size(156, 35);
            btnUtilizadores.TabIndex = 4;
            btnUtilizadores.Text = "Gestão de Utilizadores";
            btnUtilizadores.UseVisualStyleBackColor = true;
            btnUtilizadores.Click += btnUtilizadores_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(9, 33);
            label5.Name = "label5";
            label5.Size = new Size(782, 25);
            label5.TabIndex = 10;
            label5.Text = "______________________________________________________________________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 10);
            label4.Name = "label4";
            label4.Size = new Size(202, 25);
            label4.TabIndex = 11;
            label4.Text = "Gestão de Vendas";
            // 
            // btnSair
            // 
            btnSair.Location = new Point(713, 61);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 12;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(632, 61);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 13;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // FormInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnSair);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnUtilizadores);
            Controls.Add(label1);
            Controls.Add(btnVendas);
            Controls.Add(btnProdutos);
            Controls.Add(button1);
            Name = "FormInicial";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label label5;
        private Label label4;
        private Button btnSair;
        private Button btnLogout;
    }
}