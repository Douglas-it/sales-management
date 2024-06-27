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
            txtNome = new TextBox();
            txtCodigo = new TextBox();
            txtComissao = new TextBox();
            btnCancelar = new Button();
            btnEditar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Location = new Point(20, 136);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(238, 23);
            txtNome.TabIndex = 1;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(20, 75);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(235, 23);
            txtCodigo.TabIndex = 2;
            // 
            // txtComissao
            // 
            txtComissao.Cursor = Cursors.IBeam;
            txtComissao.Location = new Point(20, 199);
            txtComissao.Name = "txtComissao";
            txtComissao.Size = new Size(210, 23);
            txtComissao.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(20, 246);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 33);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Location = new Point(101, 246);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(157, 33);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Guardar Alterações";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(20, 53);
            label2.Name = "label2";
            label2.Size = new Size(53, 19);
            label2.TabIndex = 6;
            label2.Text = "Código";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(20, 114);
            label3.Name = "label3";
            label3.Size = new Size(46, 19);
            label3.TabIndex = 7;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(20, 177);
            label4.Name = "label4";
            label4.Size = new Size(68, 19);
            label4.TabIndex = 8;
            label4.Text = "Comissão";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(238, 202);
            label5.Name = "label5";
            label5.Size = new Size(20, 19);
            label5.TabIndex = 9;
            label5.Text = "%";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(74, 14);
            label6.Name = "label6";
            label6.Size = new Size(128, 21);
            label6.TabIndex = 10;
            label6.Text = "Editar Vendedor";
            // 
            // FormEditarVendedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 297);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnEditar);
            Controls.Add(btnCancelar);
            Controls.Add(txtComissao);
            Controls.Add(txtCodigo);
            Controls.Add(txtNome);
            Name = "FormEditarVendedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Vendedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNome;
        private TextBox txtCodigo;
        private TextBox txtComissao;
        private Button btnCancelar;
        private Button btnEditar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}