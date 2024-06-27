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
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(19, 16);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 0;
            label1.Text = "Editar Produto";
            // 
            // btnGuardar
            // 
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Font = new Font("Segoe UI", 9.5F);
            btnGuardar.Location = new Point(417, 289);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(136, 33);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar Alterações";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Segoe UI", 9.5F);
            btnCancelar.Location = new Point(337, 289);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(74, 33);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // txtNome
            // 
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Location = new Point(19, 131);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(534, 23);
            txtNome.TabIndex = 3;
            // 
            // txtPreco
            // 
            txtPreco.Cursor = Cursors.IBeam;
            txtPreco.Location = new Point(19, 182);
            txtPreco.Margin = new Padding(3, 2, 3, 2);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(534, 23);
            txtPreco.TabIndex = 4;
            txtPreco.TextChanged += textBox2_TextChanged;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(19, 77);
            txtCodigo.Margin = new Padding(3, 2, 3, 2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(534, 23);
            txtCodigo.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(19, 56);
            label2.Name = "label2";
            label2.Size = new Size(53, 19);
            label2.TabIndex = 6;
            label2.Text = "Código";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(19, 110);
            label3.Name = "label3";
            label3.Size = new Size(46, 19);
            label3.TabIndex = 8;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(19, 161);
            label4.Name = "label4";
            label4.Size = new Size(43, 19);
            label4.TabIndex = 9;
            label4.Text = "Preço";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(19, 221);
            label5.Name = "label5";
            label5.Size = new Size(68, 19);
            label5.TabIndex = 10;
            label5.Text = "Categoria";
            // 
            // comboCategoria
            // 
            comboCategoria.Cursor = Cursors.Hand;
            comboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCategoria.FormattingEnabled = true;
            comboCategoria.Location = new Point(19, 242);
            comboCategoria.Margin = new Padding(3, 2, 3, 2);
            comboCategoria.Name = "comboCategoria";
            comboCategoria.Size = new Size(534, 23);
            comboCategoria.TabIndex = 11;
            // 
            // FormEditarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 338);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormEditarProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEditarProduto";
            FormClosed += FormEditarProduto_FormClosed;
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