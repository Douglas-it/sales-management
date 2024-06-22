namespace SalesManagement
{
    partial class FormLoginAlterarSenha
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
            label4 = new Label();
            btnAdicionar = new Button();
            inputNome = new TextBox();
            inputCodigo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 22);
            label4.Name = "label4";
            label4.Size = new Size(151, 21);
            label4.TabIndex = 35;
            label4.Text = "Nova palavra-passe";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(378, 243);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(108, 33);
            btnAdicionar.TabIndex = 34;
            btnAdicionar.Text = "Mudar password";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // inputNome
            // 
            inputNome.Location = new Point(22, 209);
            inputNome.Name = "inputNome";
            inputNome.Size = new Size(464, 23);
            inputNome.TabIndex = 32;
            // 
            // inputCodigo
            // 
            inputCodigo.Location = new Point(22, 157);
            inputCodigo.Name = "inputCodigo";
            inputCodigo.Size = new Size(464, 23);
            inputCodigo.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 191);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 29;
            label2.Text = "Repetir palavra-passe";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 139);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 28;
            label1.Text = "Palavra-passe";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(22, 58);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(464, 64);
            textBox1.TabIndex = 36;
            textBox1.Text = "\r\n     A sua conta foi marcada por um  administrador para a alteração da palavra-passe. \r\n     Por favor, proceda à alteração da sua password.";
            // 
            // FormLoginAlterarSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 291);
            ControlBox = false;
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(btnAdicionar);
            Controls.Add(inputNome);
            Controls.Add(inputCodigo);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FormLoginAlterarSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atualize a sua palavra-passe";
            FormClosed += FormLoginAlterarSenha_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button btnAdicionar;
        private TextBox inputNome;
        private TextBox inputCodigo;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
    }
}