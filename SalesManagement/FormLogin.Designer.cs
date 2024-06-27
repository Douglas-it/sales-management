namespace SalesManagement
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            label1 = new Label();
            label3 = new Label();
            inputUsername = new TextBox();
            inputPassword = new TextBox();
            btnLogin = new Button();
            label2 = new Label();
            btnSair = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(337, 133);
            label1.Name = "label1";
            label1.Size = new Size(67, 19);
            label1.TabIndex = 2;
            label1.Text = "Utilizador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(337, 194);
            label3.Name = "label3";
            label3.Size = new Size(67, 19);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // inputUsername
            // 
            inputUsername.Cursor = Cursors.IBeam;
            inputUsername.Location = new Point(337, 155);
            inputUsername.Name = "inputUsername";
            inputUsername.Size = new Size(295, 23);
            inputUsername.TabIndex = 4;
            // 
            // inputPassword
            // 
            inputPassword.Cursor = Cursors.IBeam;
            inputPassword.Location = new Point(337, 216);
            inputPassword.Name = "inputPassword";
            inputPassword.PasswordChar = '*';
            inputPassword.Size = new Size(295, 23);
            inputPassword.TabIndex = 5;
            inputPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Location = new Point(536, 245);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(96, 33);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(337, 94);
            label2.Name = "label2";
            label2.Size = new Size(51, 21);
            label2.TabIndex = 7;
            label2.Text = "Login";
            // 
            // btnSair
            // 
            btnSair.Cursor = Cursors.Hand;
            btnSair.Location = new Point(460, 245);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(70, 33);
            btnSair.TabIndex = 8;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._7298311;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 7.5F);
            textBox1.Location = new Point(337, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 52);
            textBox1.TabIndex = 10;
            textBox1.Text = "\r\nProjeto de Algoritmos e Estruturas de Dados\r\nRealizado por: Gabriel Ferreira, Maicon Douglas e Rui Azevedo";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 324);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(btnSair);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(inputPassword);
            Controls.Add(inputUsername);
            Controls.Add(label3);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão de Vendas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox inputUsername;
        private TextBox inputPassword;
        private Button btnLogin;
        private Label label2;
        private Button btnSair;
        private PictureBox pictureBox1;
        private TextBox textBox1;
    }
}
