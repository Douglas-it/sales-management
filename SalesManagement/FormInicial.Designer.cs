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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicial));
            button1 = new Button();
            btnProdutos = new Button();
            btnVendas = new Button();
            label1 = new Label();
            btnUtilizadores = new Button();
            label4 = new Label();
            btnSair = new Button();
            btnLogout = new Button();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(356, 198);
            button1.Name = "button1";
            button1.Size = new Size(396, 33);
            button1.TabIndex = 0;
            button1.Text = "Gestão de Vendedores";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.Cursor = Cursors.Hand;
            btnProdutos.Location = new Point(356, 237);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(396, 33);
            btnProdutos.TabIndex = 1;
            btnProdutos.Text = "Gestão de Produtos";
            btnProdutos.UseVisualStyleBackColor = true;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnVendas
            // 
            btnVendas.Cursor = Cursors.Hand;
            btnVendas.Location = new Point(356, 276);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(396, 33);
            btnVendas.TabIndex = 2;
            btnVendas.Text = "Gestão de Vendas";
            btnVendas.UseVisualStyleBackColor = true;
            btnVendas.Click += btnVendas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(356, 161);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 3;
            label1.Text = "Bem vindo";
            // 
            // btnUtilizadores
            // 
            btnUtilizadores.Cursor = Cursors.Hand;
            btnUtilizadores.Location = new Point(356, 315);
            btnUtilizadores.Name = "btnUtilizadores";
            btnUtilizadores.Size = new Size(396, 33);
            btnUtilizadores.TabIndex = 4;
            btnUtilizadores.Text = "Painel de Administração";
            btnUtilizadores.UseVisualStyleBackColor = true;
            btnUtilizadores.Click += btnUtilizadores_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 23);
            label4.Name = "label4";
            label4.Size = new Size(202, 25);
            label4.TabIndex = 11;
            label4.Text = "Gestão de Vendas";
            // 
            // btnSair
            // 
            btnSair.Cursor = Cursors.Hand;
            btnSair.Location = new Point(713, 74);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 33);
            btnSair.TabIndex = 12;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnLogout
            // 
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Location = new Point(632, 74);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 33);
            btnLogout.TabIndex = 13;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(9, 46);
            label5.Name = "label5";
            label5.Size = new Size(782, 25);
            label5.TabIndex = 10;
            label5.Text = "______________________________________________________________________";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._7298311;
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(12, 110);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(300, 300);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // FormInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(btnLogout);
            Controls.Add(btnSair);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnUtilizadores);
            Controls.Add(label1);
            Controls.Add(btnVendas);
            Controls.Add(btnProdutos);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão de Vendas";
            Load += FormInicial_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnProdutos;
        private Button btnVendas;
        private Label label1;
        private Button btnUtilizadores;
        private Label label4;
        private Button btnSair;
        private Button btnLogout;
        private Label label5;
        private PictureBox pictureBox2;
    }
}