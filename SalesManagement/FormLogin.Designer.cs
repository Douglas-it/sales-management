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
            label1 = new Label();
            label3 = new Label();
            inputUsername = new TextBox();
            inputPassword = new TextBox();
            btnLogin = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 68);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 2;
            label1.Text = "Utilizador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 129);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // inputUsername
            // 
            inputUsername.Location = new Point(29, 86);
            inputUsername.Name = "inputUsername";
            inputUsername.Size = new Size(185, 23);
            inputUsername.TabIndex = 4;
            // 
            // inputPassword
            // 
            inputPassword.Location = new Point(29, 147);
            inputPassword.Name = "inputPassword";
            inputPassword.PasswordChar = '*';
            inputPassword.Size = new Size(185, 23);
            inputPassword.TabIndex = 5;
            inputPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(82, 188);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 27);
            label2.Name = "label2";
            label2.Size = new Size(51, 21);
            label2.TabIndex = 7;
            label2.Text = "Login";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 242);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(inputPassword);
            Controls.Add(inputUsername);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão de Vendas";
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
    }
}
