namespace SalesManagement
{
    partial class FormBackoffice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBackoffice));
            btnLogout = new Button();
            btnSair = new Button();
            btnCriarConta = new Button();
            button2 = new Button();
            btnAlterarConta = new Button();
            btnEliminarConta = new Button();
            tabControl = new TabControl();
            tabCriarConta = new TabPage();
            label11 = new Label();
            checkSim = new CheckBox();
            labelPergunta = new Label();
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
            label13 = new Label();
            textBox4 = new TextBox();
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
            tabAdicionarVendedor = new TabPage();
            label10 = new Label();
            btnAdicionar = new Button();
            inputComissao = new TextBox();
            inputNome = new TextBox();
            inputCodigo = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            btnVoltar = new Button();
            tabAdicionarProduto = new TabPage();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            comboCategoriasProduto = new ComboBox();
            txtPrecoProduto = new TextBox();
            txtNomeProduto = new TextBox();
            txtCodigoProduto = new TextBox();
            label17 = new Label();
            btnCancelar = new Button();
            btnAdicionarArtigo = new Button();
            label12 = new Label();
            btnAdicionarVendedor = new Button();
            btnAdicionarProduto = new Button();
            tabControl.SuspendLayout();
            tabCriarConta.SuspendLayout();
            tabAlterarConta.SuspendLayout();
            tabEliminarConta.SuspendLayout();
            tabAdicionarVendedor.SuspendLayout();
            tabAdicionarProduto.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Cursor = Cursors.Hand;
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
            btnSair.Cursor = Cursors.Hand;
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
            btnCriarConta.Cursor = Cursors.Hand;
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
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(12, 756);
            button2.Name = "button2";
            button2.Size = new Size(136, 42);
            button2.TabIndex = 18;
            button2.Text = "Estatisticas";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnAlterarConta
            // 
            btnAlterarConta.Cursor = Cursors.Hand;
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
            btnEliminarConta.Cursor = Cursors.Hand;
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
            tabControl.Controls.Add(tabAdicionarVendedor);
            tabControl.Controls.Add(tabAdicionarProduto);
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
            tabCriarConta.Controls.Add(labelPergunta);
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
            // checkSim
            // 
            checkSim.AutoSize = true;
            checkSim.Cursor = Cursors.Hand;
            checkSim.Location = new Point(201, 572);
            checkSim.Name = "checkSim";
            checkSim.Size = new Size(46, 19);
            checkSim.TabIndex = 26;
            checkSim.Text = "Sim";
            checkSim.UseVisualStyleBackColor = true;
            // 
            // labelPergunta
            // 
            labelPergunta.AutoSize = true;
            labelPergunta.Location = new Point(201, 544);
            labelPergunta.Name = "labelPergunta";
            labelPergunta.Size = new Size(342, 15);
            labelPergunta.TabIndex = 25;
            labelPergunta.Text = "Deseja que o utilizador altere a palavra-passe no próximo login?\r\n";
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
            btnNovoUtilizador.Cursor = Cursors.Hand;
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
            cargos.Cursor = Cursors.IBeam;
            cargos.DropDownStyle = ComboBoxStyle.DropDownList;
            cargos.FormattingEnabled = true;
            cargos.Location = new Point(201, 500);
            cargos.Name = "cargos";
            cargos.Size = new Size(825, 23);
            cargos.TabIndex = 7;
            // 
            // txtRepeatPassword
            // 
            txtRepeatPassword.Cursor = Cursors.IBeam;
            txtRepeatPassword.Location = new Point(201, 467);
            txtRepeatPassword.Name = "txtRepeatPassword";
            txtRepeatPassword.PasswordChar = '*';
            txtRepeatPassword.Size = new Size(825, 23);
            txtRepeatPassword.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Location = new Point(201, 433);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(825, 23);
            txtPassword.TabIndex = 5;
            // 
            // txtUtilizador
            // 
            txtUtilizador.Cursor = Cursors.IBeam;
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
            tabAlterarConta.Controls.Add(label13);
            tabAlterarConta.Controls.Add(textBox4);
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
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(29, 26);
            label13.Name = "label13";
            label13.Size = new Size(265, 18);
            label13.TabIndex = 27;
            label13.Text = "Instruções para editar um utilizador";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(29, 60);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(1046, 77);
            textBox4.TabIndex = 26;
            textBox4.Text = resources.GetString("textBox4.Text");
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(999, 286);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(26, 23);
            txtUserId.TabIndex = 25;
            txtUserId.Visible = false;
            // 
            // checkYes
            // 
            checkYes.AutoSize = true;
            checkYes.Cursor = Cursors.Hand;
            checkYes.Location = new Point(232, 428);
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
            labelSenha.Location = new Point(232, 400);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(342, 15);
            labelSenha.TabIndex = 22;
            labelSenha.Text = "Deseja que o utilizador altere a palavra-passe no próximo login?\r\n";
            labelSenha.Visible = false;
            // 
            // btnModificarConta
            // 
            btnModificarConta.Cursor = Cursors.Hand;
            btnModificarConta.Location = new Point(933, 415);
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
            comboCargos.Cursor = Cursors.Hand;
            comboCargos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCargos.FormattingEnabled = true;
            comboCargos.Location = new Point(232, 354);
            comboCargos.Name = "comboCargos";
            comboCargos.Size = new Size(794, 23);
            comboCargos.TabIndex = 20;
            comboCargos.Visible = false;
            // 
            // txtNomeUser
            // 
            txtNomeUser.Cursor = Cursors.IBeam;
            txtNomeUser.Location = new Point(232, 315);
            txtNomeUser.Name = "txtNomeUser";
            txtNomeUser.Size = new Size(794, 23);
            txtNomeUser.TabIndex = 17;
            txtNomeUser.Visible = false;
            // 
            // labelCargo
            // 
            labelCargo.AutoSize = true;
            labelCargo.Location = new Point(104, 357);
            labelCargo.Name = "labelCargo";
            labelCargo.Size = new Size(109, 15);
            labelCargo.TabIndex = 16;
            labelCargo.Text = "Cargo do Utilizador";
            labelCargo.Visible = false;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Location = new Point(104, 318);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(109, 15);
            labelUser.TabIndex = 13;
            labelUser.Text = "Nome de Utilizador";
            labelUser.Visible = false;
            // 
            // selecionarUtilizador
            // 
            selecionarUtilizador.Cursor = Cursors.Hand;
            selecionarUtilizador.DropDownStyle = ComboBoxStyle.DropDownList;
            selecionarUtilizador.FormattingEnabled = true;
            selecionarUtilizador.Location = new Point(232, 177);
            selecionarUtilizador.Name = "selecionarUtilizador";
            selecionarUtilizador.Size = new Size(793, 23);
            selecionarUtilizador.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(82, 180);
            label9.Name = "label9";
            label9.Size = new Size(131, 15);
            label9.TabIndex = 11;
            label9.Text = "Selecione um Utilizador";
            // 
            // btnObterDados
            // 
            btnObterDados.Cursor = Cursors.Hand;
            btnObterDados.Location = new Point(916, 216);
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
            selectUsername.Cursor = Cursors.Hand;
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
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Location = new Point(917, 216);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(109, 32);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar Conta";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // tabAdicionarVendedor
            // 
            tabAdicionarVendedor.Controls.Add(label10);
            tabAdicionarVendedor.Controls.Add(btnAdicionar);
            tabAdicionarVendedor.Controls.Add(inputComissao);
            tabAdicionarVendedor.Controls.Add(inputNome);
            tabAdicionarVendedor.Controls.Add(inputCodigo);
            tabAdicionarVendedor.Controls.Add(label14);
            tabAdicionarVendedor.Controls.Add(label15);
            tabAdicionarVendedor.Controls.Add(label16);
            tabAdicionarVendedor.Controls.Add(btnVoltar);
            tabAdicionarVendedor.Location = new Point(4, 24);
            tabAdicionarVendedor.Name = "tabAdicionarVendedor";
            tabAdicionarVendedor.Padding = new Padding(3);
            tabAdicionarVendedor.Size = new Size(1103, 726);
            tabAdicionarVendedor.TabIndex = 3;
            tabAdicionarVendedor.Text = "Adicionar Vendedor";
            tabAdicionarVendedor.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(19, 23);
            label10.Name = "label10";
            label10.Size = new Size(126, 21);
            label10.TabIndex = 35;
            label10.Text = "Novo Vendedor";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Cursor = Cursors.Hand;
            btnAdicionar.Location = new Point(204, 221);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 34;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // inputComissao
            // 
            inputComissao.Cursor = Cursors.IBeam;
            inputComissao.Location = new Point(40, 184);
            inputComissao.Name = "inputComissao";
            inputComissao.Size = new Size(239, 23);
            inputComissao.TabIndex = 33;
            // 
            // inputNome
            // 
            inputNome.Cursor = Cursors.IBeam;
            inputNome.Location = new Point(40, 131);
            inputNome.Name = "inputNome";
            inputNome.Size = new Size(239, 23);
            inputNome.TabIndex = 32;
            // 
            // inputCodigo
            // 
            inputCodigo.Cursor = Cursors.IBeam;
            inputCodigo.Location = new Point(40, 79);
            inputCodigo.Name = "inputCodigo";
            inputCodigo.Size = new Size(239, 23);
            inputCodigo.TabIndex = 31;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(40, 166);
            label14.Name = "label14";
            label14.Size = new Size(59, 15);
            label14.TabIndex = 30;
            label14.Text = "Comissão";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(40, 113);
            label15.Name = "label15";
            label15.Size = new Size(40, 15);
            label15.TabIndex = 29;
            label15.Text = "Nome";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(40, 61);
            label16.Name = "label16";
            label16.Size = new Size(46, 15);
            label16.TabIndex = 28;
            label16.Text = "Código";
            // 
            // btnVoltar
            // 
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.Location = new Point(40, 221);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 27;
            btnVoltar.Text = "Cancelar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // tabAdicionarProduto
            // 
            tabAdicionarProduto.Controls.Add(label21);
            tabAdicionarProduto.Controls.Add(label20);
            tabAdicionarProduto.Controls.Add(label19);
            tabAdicionarProduto.Controls.Add(label18);
            tabAdicionarProduto.Controls.Add(comboCategoriasProduto);
            tabAdicionarProduto.Controls.Add(txtPrecoProduto);
            tabAdicionarProduto.Controls.Add(txtNomeProduto);
            tabAdicionarProduto.Controls.Add(txtCodigoProduto);
            tabAdicionarProduto.Controls.Add(label17);
            tabAdicionarProduto.Controls.Add(btnCancelar);
            tabAdicionarProduto.Controls.Add(btnAdicionarArtigo);
            tabAdicionarProduto.Location = new Point(4, 24);
            tabAdicionarProduto.Name = "tabAdicionarProduto";
            tabAdicionarProduto.Padding = new Padding(3);
            tabAdicionarProduto.Size = new Size(1103, 726);
            tabAdicionarProduto.TabIndex = 4;
            tabAdicionarProduto.Text = "Adicionar Produto";
            tabAdicionarProduto.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(78, 218);
            label21.Name = "label21";
            label21.Size = new Size(58, 15);
            label21.TabIndex = 10;
            label21.Text = "Categoria";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(82, 182);
            label20.Name = "label20";
            label20.Size = new Size(37, 15);
            label20.TabIndex = 9;
            label20.Text = "Preço";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(78, 146);
            label19.Name = "label19";
            label19.Size = new Size(40, 15);
            label19.TabIndex = 8;
            label19.Text = "Nome";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(78, 102);
            label18.Name = "label18";
            label18.Size = new Size(46, 15);
            label18.TabIndex = 7;
            label18.Text = "Código";
            // 
            // comboCategoriasProduto
            // 
            comboCategoriasProduto.Cursor = Cursors.Hand;
            comboCategoriasProduto.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCategoriasProduto.FormattingEnabled = true;
            comboCategoriasProduto.Location = new Point(143, 218);
            comboCategoriasProduto.Name = "comboCategoriasProduto";
            comboCategoriasProduto.Size = new Size(432, 23);
            comboCategoriasProduto.TabIndex = 6;
            // 
            // txtPrecoProduto
            // 
            txtPrecoProduto.Cursor = Cursors.IBeam;
            txtPrecoProduto.Location = new Point(143, 179);
            txtPrecoProduto.Name = "txtPrecoProduto";
            txtPrecoProduto.Size = new Size(432, 23);
            txtPrecoProduto.TabIndex = 5;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Cursor = Cursors.IBeam;
            txtNomeProduto.Location = new Point(143, 138);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(432, 23);
            txtNomeProduto.TabIndex = 4;
            // 
            // txtCodigoProduto
            // 
            txtCodigoProduto.Cursor = Cursors.IBeam;
            txtCodigoProduto.Location = new Point(143, 99);
            txtCodigoProduto.Name = "txtCodigoProduto";
            txtCodigoProduto.Size = new Size(432, 23);
            txtCodigoProduto.TabIndex = 3;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(18, 12);
            label17.Name = "label17";
            label17.Size = new Size(104, 15);
            label17.TabIndex = 2;
            label17.Text = "Adicionar Produto";
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(835, 522);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(87, 33);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarArtigo
            // 
            btnAdicionarArtigo.Cursor = Cursors.Hand;
            btnAdicionarArtigo.Location = new Point(942, 522);
            btnAdicionarArtigo.Name = "btnAdicionarArtigo";
            btnAdicionarArtigo.Size = new Size(136, 33);
            btnAdicionarArtigo.TabIndex = 0;
            btnAdicionarArtigo.Text = "Adicionar Produto";
            btnAdicionarArtigo.UseVisualStyleBackColor = true;
            btnAdicionarArtigo.Click += btnAdicionarArtigo_Click;
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
            // btnAdicionarVendedor
            // 
            btnAdicionarVendedor.Cursor = Cursors.Hand;
            btnAdicionarVendedor.Location = new Point(12, 302);
            btnAdicionarVendedor.Name = "btnAdicionarVendedor";
            btnAdicionarVendedor.Size = new Size(136, 42);
            btnAdicionarVendedor.TabIndex = 23;
            btnAdicionarVendedor.Text = "Adicionar Vendedor";
            btnAdicionarVendedor.UseVisualStyleBackColor = true;
            btnAdicionarVendedor.Click += btnAdicionarVendedor_Click;
            // 
            // btnAdicionarProduto
            // 
            btnAdicionarProduto.Cursor = Cursors.Hand;
            btnAdicionarProduto.Location = new Point(12, 359);
            btnAdicionarProduto.Name = "btnAdicionarProduto";
            btnAdicionarProduto.Size = new Size(136, 42);
            btnAdicionarProduto.TabIndex = 24;
            btnAdicionarProduto.Text = "Adicionar Produto";
            btnAdicionarProduto.UseVisualStyleBackColor = true;
            btnAdicionarProduto.Click += btnAdicionarProduto_Click;
            // 
            // FormBackoffice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 814);
            Controls.Add(btnAdicionarProduto);
            Controls.Add(btnAdicionarVendedor);
            Controls.Add(label12);
            Controls.Add(tabControl);
            Controls.Add(btnEliminarConta);
            Controls.Add(btnAlterarConta);
            Controls.Add(button2);
            Controls.Add(btnCriarConta);
            Controls.Add(btnLogout);
            Controls.Add(btnSair);
            Name = "FormBackoffice";
            Text = "Backoffice";
            tabControl.ResumeLayout(false);
            tabCriarConta.ResumeLayout(false);
            tabCriarConta.PerformLayout();
            tabAlterarConta.ResumeLayout(false);
            tabAlterarConta.PerformLayout();
            tabEliminarConta.ResumeLayout(false);
            tabEliminarConta.PerformLayout();
            tabAdicionarVendedor.ResumeLayout(false);
            tabAdicionarVendedor.PerformLayout();
            tabAdicionarProduto.ResumeLayout(false);
            tabAdicionarProduto.PerformLayout();
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
        private Label labelPergunta;
        private Label label11;
        private Label label13;
        private TextBox textBox4;
        private Button btnAdicionarVendedor;
        private TabPage tabAdicionarVendedor;
        private Label label10;
        private Button btnAdicionar;
        private TextBox inputComissao;
        private TextBox inputNome;
        private TextBox inputCodigo;
        private Label label14;
        private Label label15;
        private Label label16;
        private Button btnVoltar;
        private TabPage tabAdicionarProduto;
        private Button btnAdicionarProduto;
        private Button btnAdicionarArtigo;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private ComboBox comboCategoriasProduto;
        private TextBox txtPrecoProduto;
        private TextBox txtNomeProduto;
        private TextBox txtCodigoProduto;
        private Label label17;
        private Button btnCancelar;
    }
}