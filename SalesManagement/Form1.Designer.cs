namespace SalesManagement
{
    partial class Form1
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            inputUsername = new TextBox();
            inputPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(412, 96);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(262, 141);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 2;
            label1.Text = "Utilizador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(262, 189);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // inputUsername
            // 
            inputUsername.Location = new Point(343, 138);
            inputUsername.Name = "inputUsername";
            inputUsername.Size = new Size(185, 23);
            inputUsername.TabIndex = 4;
            // 
            // inputPassword
            // 
            inputPassword.Location = new Point(343, 186);
            inputPassword.Name = "inputPassword";
            inputPassword.Size = new Size(185, 23);
            inputPassword.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(396, 227);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(inputPassword);
            Controls.Add(inputUsername);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Gestão de Vendas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox inputUsername;
        private TextBox inputPassword;
        private Button btnLogin;
    }
}
