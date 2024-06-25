namespace SalesManagement
{
    partial class FormEditarProduto
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
            label1 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            txtNome = new TextBox();
            txtPreco = new TextBox();
            txtCodigo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboCategoria = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 0;
            label1.Text = "Editar Produto";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(633, 397);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(155, 29);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar Alterações";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(542, 397);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(85, 29);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(146, 166);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(610, 27);
            txtNome.TabIndex = 3;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(146, 202);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(610, 27);
            txtPreco.TabIndex = 4;
            txtPreco.TextChanged += textBox2_TextChanged;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(146, 126);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(610, 27);
            txtCodigo.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 126);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 6;
            label2.Text = "Código";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 166);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 8;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 202);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 9;
            label4.Text = "Preço";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 239);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 10;
            label5.Text = "Categoria";
            // 
            // comboCategoria
            // 
            comboCategoria.FormattingEnabled = true;
            comboCategoria.Location = new Point(146, 239);
            comboCategoria.Name = "comboCategoria";
            comboCategoria.Size = new Size(610, 28);
            comboCategoria.TabIndex = 11;
            // 
            // FormEditarProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboCategoria);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(label1);
            Name = "FormEditarProduto";
            Text = "FormEditarProduto";
            Load += FormEditarProduto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox txtNome;
        private TextBox txtPreco;
        private TextBox txtCodigo;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboCategoria;
    }
}