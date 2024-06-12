namespace SalesManagement
{
    partial class NovoComercial
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
            btnVoltar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            inputCodigo = new TextBox();
            inputNome = new TextBox();
            inputComissao = new TextBox();
            btnAdicionar = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(25, 220);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 17;
            btnVoltar.Text = "Cancelar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 60);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 19;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 112);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 20;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 165);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 21;
            label3.Text = "Comissão";
            // 
            // inputCodigo
            // 
            inputCodigo.Location = new Point(25, 78);
            inputCodigo.Name = "inputCodigo";
            inputCodigo.Size = new Size(239, 23);
            inputCodigo.TabIndex = 22;
            // 
            // inputNome
            // 
            inputNome.Location = new Point(25, 130);
            inputNome.Name = "inputNome";
            inputNome.Size = new Size(239, 23);
            inputNome.TabIndex = 23;
            // 
            // inputComissao
            // 
            inputComissao.Location = new Point(25, 183);
            inputComissao.Name = "inputComissao";
            inputComissao.Size = new Size(239, 23);
            inputComissao.TabIndex = 24;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(189, 220);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 25;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(81, 22);
            label4.Name = "label4";
            label4.Size = new Size(127, 21);
            label4.TabIndex = 26;
            label4.Text = "Novo Comercial";
            // 
            // NovoComercial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 270);
            Controls.Add(label4);
            Controls.Add(btnAdicionar);
            Controls.Add(inputComissao);
            Controls.Add(inputNome);
            Controls.Add(inputCodigo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVoltar);
            Name = "NovoComercial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo Comercial";
            Load += NovoComercial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox inputCodigo;
        private TextBox inputNome;
        private TextBox inputComissao;
        private Button btnAdicionar;
        private Label label4;
    }
}