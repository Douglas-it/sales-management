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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Backoffice));
            btnLogout = new Button();
            btnSair = new Button();
            btnCriarConta = new Button();
            button2 = new Button();
            btnAlterarConta = new Button();
            btnEliminarConta = new Button();
            tabControl = new TabControl();
            tabCriarConta = new TabPage();
            label7 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
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
            txtUserId = new TextBox();
            checkYes = new CheckBox();
            labelSenha = new Label();
            btnModificarConta = new Button();
            comboCargos = new ComboBox();
            txtNomeUser = new TextBox();
            labelCargo = new Label();
            labelUser = new Label();
            selecionarUtilizador = new ComboBox();
            label9 = new Label();
            btnObterDados = new Button();
            tabEliminarConta = new TabPage();
            label8 = new Label();
            textBox3 = new TextBox();
            selectUsername = new ComboBox();
            label6 = new Label();
            btnEliminar = new Button();
            label12 = new Label();
            checkSim = new CheckBox();
            label10 = new Label();
            label11 = new Label();
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
            tabCriarConta.Controls.Add(label11);
            tabCriarConta.Controls.Add(checkSim);
            tabCriarConta.Controls.Add(label10);
            tabCriarConta.Controls.Add(label7);
            tabCriarConta.Controls.Add(textBox2);
            tabCriarConta.Controls.Add(label5);
            tabCriarConta.Controls.Add(textBox1);
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
            tabCriarConta.Click += tabCriarConta_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(28, 196);
            label7.Name = "label7";
            label7.Size = new Size(208, 18);
            label7.TabIndex = 12;
            label7.Text = "Tipos de cargos disponíveis";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(28, 230);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(1046, 63);
            textBox2.TabIndex = 11;
            textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(28, 35);
            label5.Name = "label5";
            label5.Size = new Size(242, 18);
            label5.TabIndex = 10;
            label5.Text = "Instruções para criar uma conta";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(28, 69);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(1046, 90);
            textBox1.TabIndex = 9;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // btnNovoUtilizador
            // 
            btnNovoUtilizador.Location = new Point(951, 572);
            btnNovoUtilizador.Name = "btnNovoUtilizador";
            btnNovoUtilizador.Size = new Size(75, 32);
            btnNovoUtilizador.TabIndex = 8;
            btnNovoUtilizador.Text = "Criar Conta";
            btnNovoUtilizador.UseVisualStyleBackColor = true;
            btnNovoUtilizador.Click += btnNovoUtilizador_Click;
            // 
            // cargos
            // 
            cargos.DropDownStyle = ComboBoxStyle.DropDownList;
            cargos.FormattingEnabled = true;
            cargos.Location = new Point(201, 500);
            cargos.Name = "cargos";
            cargos.Size = new Size(825, 23);
            cargos.TabIndex = 7;
            // 
            // txtRepeatPassword
            // 
            txtRepeatPassword.Location = new Point(201, 467);
            txtRepeatPassword.Name = "txtRepeatPassword";
            txtRepeatPassword.Size = new Size(825, 23);
            txtRepeatPassword.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(201, 433);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(825, 23);
            txtPassword.TabIndex = 5;
            // 
            // txtUtilizador
            // 
            txtUtilizador.Location = new Point(201, 398);
            txtUtilizador.Name = "txtUtilizador";
            txtUtilizador.Size = new Size(825, 23);
            txtUtilizador.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 503);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 3;
            label4.Text = "Cargo do Utilizador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 470);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 2;
            label3.Text = "Repetir Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 436);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 401);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome de Utilizador";
            // 
            // tabAlterarConta
            // 
            tabAlterarConta.Controls.Add(txtUserId);
            tabAlterarConta.Controls.Add(checkYes);
            tabAlterarConta.Controls.Add(labelSenha);
            tabAlterarConta.Controls.Add(btnModificarConta);
            tabAlterarConta.Controls.Add(comboCargos);
            tabAlterarConta.Controls.Add(txtNomeUser);
            tabAlterarConta.Controls.Add(labelCargo);
            tabAlterarConta.Controls.Add(labelUser);
            tabAlterarConta.Controls.Add(selecionarUtilizador);
            tabAlterarConta.Controls.Add(label9);
            tabAlterarConta.Controls.Add(btnObterDados);
            tabAlterarConta.Location = new Point(4, 24);
            tabAlterarConta.Name = "tabAlterarConta";
            tabAlterarConta.Padding = new Padding(3);
            tabAlterarConta.Size = new Size(1103, 726);
            tabAlterarConta.TabIndex = 1;
            tabAlterarConta.Text = "Alterar Conta";
            tabAlterarConta.UseVisualStyleBackColor = true;
            tabAlterarConta.Click += tabAlterarConta_Click;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(1000, 250);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(26, 23);
            txtUserId.TabIndex = 25;
            txtUserId.Visible = false;
            // 
            // checkYes
            // 
            checkYes.AutoSize = true;
            checkYes.Location = new Point(202, 392);
            checkYes.Name = "checkYes";
            checkYes.Size = new Size(46, 19);
            checkYes.TabIndex = 24;
            checkYes.Text = "Sim";
            checkYes.UseVisualStyleBackColor = true;
            checkYes.Visible = false;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(202, 364);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(342, 15);
            labelSenha.TabIndex = 22;
            labelSenha.Text = "Deseja que o utilizador altere a palavra-passe no próximo login?\r\n";
            labelSenha.Visible = false;
            // 
            // btnModificarConta
            // 
            btnModificarConta.Location = new Point(934, 379);
            btnModificarConta.Name = "btnModificarConta";
            btnModificarConta.Size = new Size(92, 32);
            btnModificarConta.TabIndex = 21;
            btnModificarConta.Text = "Alterar Conta";
            btnModificarConta.UseVisualStyleBackColor = true;
            btnModificarConta.Visible = false;
            btnModificarConta.Click += btnModificarConta_Click;
            // 
            // comboCargos
            // 
            comboCargos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCargos.FormattingEnabled = true;
            comboCargos.Location = new Point(202, 318);
            comboCargos.Name = "comboCargos";
            comboCargos.Size = new Size(825, 23);
            comboCargos.TabIndex = 20;
            comboCargos.Visible = false;
            // 
            // txtNomeUser
            // 
            txtNomeUser.Location = new Point(202, 279);
            txtNomeUser.Name = "txtNomeUser";
            txtNomeUser.Size = new Size(825, 23);
            txtNomeUser.TabIndex = 17;
            txtNomeUser.Visible = false;
            // 
            // labelCargo
            // 
            labelCargo.AutoSize = true;
            labelCargo.Location = new Point(75, 321);
            labelCargo.Name = "labelCargo";
            labelCargo.Size = new Size(109, 15);
            labelCargo.TabIndex = 16;
            labelCargo.Text = "Cargo do Utilizador";
            labelCargo.Visible = false;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Location = new Point(75, 282);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(109, 15);
            labelUser.TabIndex = 13;
            labelUser.Text = "Nome de Utilizador";
            labelUser.Visible = false;
            // 
            // selecionarUtilizador
            // 
            selecionarUtilizador.DropDownStyle = ComboBoxStyle.DropDownList;
            selecionarUtilizador.FormattingEnabled = true;
            selecionarUtilizador.Location = new Point(233, 109);
            selecionarUtilizador.Name = "selecionarUtilizador";
            selecionarUtilizador.Size = new Size(793, 23);
            selecionarUtilizador.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(83, 112);
            label9.Name = "label9";
            label9.Size = new Size(131, 15);
            label9.TabIndex = 11;
            label9.Text = "Selecione um Utilizador";
            // 
            // btnObterDados
            // 
            btnObterDados.Location = new Point(917, 148);
            btnObterDados.Name = "btnObterDados";
            btnObterDados.Size = new Size(109, 32);
            btnObterDados.TabIndex = 10;
            btnObterDados.Text = "Obter Dados";
            btnObterDados.UseVisualStyleBackColor = true;
            btnObterDados.Click += btnObterDados_Click;
            // 
            // tabEliminarConta
            // 
            tabEliminarConta.Controls.Add(label8);
            tabEliminarConta.Controls.Add(textBox3);
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(29, 34);
            label8.Name = "label8";
            label8.Size = new Size(72, 18);
            label8.TabIndex = 12;
            label8.Text = "Atenção";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(29, 68);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(1046, 62);
            textBox3.TabIndex = 11;
            textBox3.Text = "    \r\n     Ao eliminar uma conta, a mesma deixa de ter acesso ao sistema. \r\n     Caso pretenda alterar o nível de acesso de utilizador, pode utilizar a seção de \"Alterar Conta\" para o fazer.";
            // 
            // selectUsername
            // 
            selectUsername.DropDownStyle = ComboBoxStyle.DropDownList;
            selectUsername.FormattingEnabled = true;
            selectUsername.Location = new Point(208, 177);
            selectUsername.Name = "selectUsername";
            selectUsername.Size = new Size(818, 23);
            selectUsername.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(83, 180);
            label6.Name = "label6";
            label6.Size = new Size(109, 15);
            label6.TabIndex = 8;
            label6.Text = "Nome de Utilizador";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(917, 216);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(109, 32);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar Conta";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(12, 64);
            label12.Name = "label12";
            label12.Size = new Size(92, 18);
            label12.TabIndex = 22;
            label12.Text = "Utilizadores";
            // 
            // checkSim
            // 
            checkSim.AutoSize = true;
            checkSim.Location = new Point(201, 572);
            checkSim.Name = "checkSim";
            checkSim.Size = new Size(46, 19);
            checkSim.TabIndex = 26;
            checkSim.Text = "Sim";
            checkSim.UseVisualStyleBackColor = true;
            checkSim.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(201, 544);
            label10.Name = "label10";
            label10.Size = new Size(342, 15);
            label10.TabIndex = 25;
            label10.Text = "Deseja que o utilizador altere a palavra-passe no próximo login?\r\n";
            label10.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(28, 351);
            label11.Name = "label11";
            label11.Size = new Size(128, 18);
            label11.TabIndex = 27;
            label11.Text = "Dados da Conta";
            // 
            // Backoffice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 814);
            Controls.Add(label12);
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
            tabAlterarConta.PerformLayout();
            tabEliminarConta.ResumeLayout(false);
            tabEliminarConta.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox textBox1;
        private Label label5;
        private Label label7;
        private TextBox textBox2;
        private Label label8;
        private TextBox textBox3;
        private ComboBox selecionarUtilizador;
        private Label label9;
        private Button btnObterDados;
        private Label labelSenha;
        private Button btnModificarConta;
        private ComboBox comboCargos;
        private TextBox txtNomeUser;
        private Label labelCargo;
        private Label labelUser;
        private CheckBox checkYes;
        private Label label12;
        private TextBox txtUserId;
        private CheckBox checkSim;
        private Label label10;
        private Label label11;
    }
}