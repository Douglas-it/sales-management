namespace SalesManagement
{
    partial class FormEditarVendedores
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
            txtNome = new TextBox();
            txtCodigo = new TextBox();
            txtComissao = new TextBox();
            btnCancelar = new Button();
            btnEditar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Editar Vendedor";
            // 
            // txtNome
            // 
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Location = new Point(318, 162);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(235, 23);
            txtNome.TabIndex = 1;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(318, 117);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(235, 23);
            txtCodigo.TabIndex = 2;
            // 
            // txtComissao
            // 
            txtComissao.Cursor = Cursors.IBeam;
            txtComissao.Location = new Point(318, 208);
            txtComissao.Name = "txtComissao";
            txtComissao.Size = new Size(53, 23);
            txtComissao.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(588, 403);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Location = new Point(701, 403);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 125);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 6;
            label2.Text = "Código";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(272, 165);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 7;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(253, 211);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 8;
            label4.Text = "Comissão";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(377, 211);
            label5.Name = "label5";
            label5.Size = new Size(17, 15);
            label5.TabIndex = 9;
            label5.Text = "%";
            // 
            // FormEditarVendedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnEditar);
            Controls.Add(btnCancelar);
            Controls.Add(txtComissao);
            Controls.Add(txtCodigo);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "FormEditarVendedores";
            Text = "Editar Vendedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private TextBox txtCodigo;
        private TextBox txtComissao;
        private Button btnCancelar;
        private Button btnEditar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}