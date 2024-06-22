namespace SalesManagement
{
    partial class Backoffice
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
            btnLogout = new Button();
            btnSair = new Button();
            btnCriarConta = new Button();
            button2 = new Button();
            btnAlterarConta = new Button();
            btnEliminarConta = new Button();
            tabControl = new TabControl();
            tabCriarConta = new TabPage();
            btnNovoUtilizador = new Button();
            cargos = new ComboBox();
            txtRepeatPassword = new TextBox();
            txtPassword = new TextBox();
            txtUtilizador = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabAlterarConta = new TabPage();
            button5 = new Button();
            tabEliminarConta = new TabPage();
            selectUsername = new ComboBox();
            label6 = new Label();
            btnEliminar = new Button();
            tabControl.SuspendLayout();
            tabCriarConta.SuspendLayout();
            tabAlterarConta.SuspendLayout();
            tabEliminarConta.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1109, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 15;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(1190, 12);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 14;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnCriarConta
            // 
            btnCriarConta.Location = new Point(12, 95);
            btnCriarConta.Name = "btnCriarConta";
            btnCriarConta.Size = new Size(136, 42);
            btnCriarConta.TabIndex = 17;
            btnCriarConta.Text = "Criar Conta";
            btnCriarConta.UseVisualStyleBackColor = true;
            btnCriarConta.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 306);
            button2.Name = "button2";
            button2.Size = new Size(136, 42);
            button2.TabIndex = 18;
            button2.Text = "Estatisticas";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnAlterarConta
            // 
            btnAlterarConta.Location = new Point(12, 143);
            btnAlterarConta.Name = "btnAlterarConta";
            btnAlterarConta.Size = new Size(136, 42);
            btnAlterarConta.TabIndex = 19;
            btnAlterarConta.Text = "Alterar Conta";
            btnAlterarConta.UseVisualStyleBackColor = true;
            btnAlterarConta.Click += btnAlterarConta_Click;
            // 
            // btnEliminarConta
            // 
            btnEliminarConta.Location = new Point(12, 191);
            btnEliminarConta.Name = "btnEliminarConta";
            btnEliminarConta.Size = new Size(136, 42);
            btnEliminarConta.TabIndex = 20;
            btnEliminarConta.Text = "Eliminar Conta";
            btnEliminarConta.UseVisualStyleBackColor = true;
            btnEliminarConta.Click += btnEliminarConta_Click;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabCriarConta);
            tabControl.Controls.Add(tabAlterarConta);
            tabControl.Controls.Add(tabEliminarConta);
            tabControl.Location = new Point(154, 48);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1111, 754);
            tabControl.TabIndex = 21;
            tabControl.Tag = "";
            // 
            // tabCriarConta
            // 
            tabCriarConta.Controls.Add(btnNovoUtilizador);
            tabCriarConta.Controls.Add(cargos);
            tabCriarConta.Controls.Add(txtRepeatPassword);
            tabCriarConta.Controls.Add(txtPassword);
            tabCriarConta.Controls.Add(txtUtilizador);
            tabCriarConta.Controls.Add(label4);
            tabCriarConta.Controls.Add(label3);
            tabCriarConta.Controls.Add(label2);
            tabCriarConta.Controls.Add(label1);
            tabCriarConta.Location = new Point(4, 24);
            tabCriarConta.Name = "tabCriarConta";
            tabCriarConta.Padding = new Padding(3);
            tabCriarConta.Size = new Size(1103, 726);
            tabCriarConta.TabIndex = 0;
            tabCriarConta.Text = "Criar Conta";
            tabCriarConta.UseVisualStyleBackColor = true;
            // 
            // btnNovoUtilizador
            // 
            btnNovoUtilizador.Location = new Point(378, 185);
            btnNovoUtilizador.Name = "btnNovoUtilizador";
            btnNovoUtilizador.Size = new Size(75, 23);
            btnNovoUtilizador.TabIndex = 8;
            btnNovoUtilizador.Text = "Criar Conta";
            btnNovoUtilizador.UseVisualStyleBackColor = true;
            btnNovoUtilizador.Click += btnNovoUtilizador_Click;
            // 
            // cargos
            // 
            cargos.FormattingEnabled = true;
            cargos.Location = new Point(194, 146);
            cargos.Name = "cargos";
            cargos.Size = new Size(259, 23);
            cargos.TabIndex = 7;
            // 
            // txtRepeatPassword
            // 
            txtRepeatPassword.Location = new Point(194, 116);
            txtRepeatPassword.Name = "txtRepeatPassword";
            txtRepeatPassword.Size = new Size(259, 23);
            txtRepeatPassword.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(194, 82);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(259, 23);
            txtPassword.TabIndex = 5;
            // 
            // txtUtilizador
            // 
            txtUtilizador.Location = new Point(194, 47);
            txtUtilizador.Name = "txtUtilizador";
            txtUtilizador.Size = new Size(259, 23);
            txtUtilizador.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 146);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 3;
            label4.Text = "Cargo do Utilizador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 119);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 2;
            label3.Text = "Repetir Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 85);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 50);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome de Utilizador";
            // 
            // tabAlterarConta
            // 
            tabAlterarConta.Controls.Add(button5);
            tabAlterarConta.Location = new Point(4, 24);
            tabAlterarConta.Name = "tabAlterarConta";
            tabAlterarConta.Padding = new Padding(3);
            tabAlterarConta.Size = new Size(1103, 726);
            tabAlterarConta.TabIndex = 1;
            tabAlterarConta.Text = "Alterar Conta";
            tabAlterarConta.UseVisualStyleBackColor = true;
            tabAlterarConta.Click += tabAlterarConta_Click;
            // 
            // button5
            // 
            button5.Location = new Point(514, 352);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 1;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // tabEliminarConta
            // 
            tabEliminarConta.Controls.Add(selectUsername);
            tabEliminarConta.Controls.Add(label6);
            tabEliminarConta.Controls.Add(btnEliminar);
            tabEliminarConta.Location = new Point(4, 24);
            tabEliminarConta.Name = "tabEliminarConta";
            tabEliminarConta.Padding = new Padding(3);
            tabEliminarConta.Size = new Size(1103, 726);
            tabEliminarConta.TabIndex = 2;
            tabEliminarConta.Text = "Eliminar Conta";
            tabEliminarConta.UseVisualStyleBackColor = true;
            // 
            // selectUsername
            // 
            selectUsername.DropDownStyle = ComboBoxStyle.DropDownList;
            selectUsername.FormattingEnabled = true;
            selectUsername.Location = new Point(156, 42);
            selectUsername.Name = "selectUsername";
            selectUsername.Size = new Size(259, 23);
            selectUsername.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 42);
            label6.Name = "label6";
            label6.Size = new Size(109, 15);
            label6.TabIndex = 8;
            label6.Text = "Nome de Utilizador";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(340, 71);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar Conta";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // Backoffice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 814);
            Controls.Add(tabControl);
            Controls.Add(btnEliminarConta);
            Controls.Add(btnAlterarConta);
            Controls.Add(button2);
            Controls.Add(btnCriarConta);
            Controls.Add(btnLogout);
            Controls.Add(btnSair);
            Name = "Backoffice";
            Text = "Backoffice";
            tabControl.ResumeLayout(false);
            tabCriarConta.ResumeLayout(false);
            tabCriarConta.PerformLayout();
            tabAlterarConta.ResumeLayout(false);
            tabEliminarConta.ResumeLayout(false);
            tabEliminarConta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnLogout;
        private Button btnSair;
        private Button btnCriarConta;
        private Button button2;
        private Button btnAlterarConta;
        private Button btnEliminarConta;
        private TabControl tabControl;
        private TabPage tabCriarConta;
        private TabPage tabAlterarConta;
        private TabPage tabEliminarConta;
        private Button button5;
        private Label label1;
        private ComboBox cargos;
        private TextBox txtRepeatPassword;
        private TextBox txtPassword;
        private TextBox txtUtilizador;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnNovoUtilizador;
        private ComboBox selectUsername;
        private Label label6;
        private Button btnEliminar;
    }
}