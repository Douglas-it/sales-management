namespace SalesManagement
{
    partial class FormEditarVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarVenda));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtPrecoUnitario = new TextBox();
            txtValorTotal = new TextBox();
            comboVendedores = new ComboBox();
            comboZonas = new ComboBox();
            comboProdutos = new ComboBox();
            txtQuantidade = new TextBox();
            dataVendaCalendario = new MonthCalendar();
            btnGuardar = new Button();
            btnCancelar = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(341, 70);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Produto Vendido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(368, 98);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Quantidade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 69);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Vendedor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 96);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 3;
            label4.Text = "Zona";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 202);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 4;
            label5.Text = "Data";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(355, 127);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 5;
            label6.Text = "Preço Unitário";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(377, 158);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 6;
            label7.Text = "Valor total";
            // 
            // txtPrecoUnitario
            // 
            txtPrecoUnitario.Enabled = false;
            txtPrecoUnitario.Location = new Point(443, 124);
            txtPrecoUnitario.Name = "txtPrecoUnitario";
            txtPrecoUnitario.Size = new Size(227, 23);
            txtPrecoUnitario.TabIndex = 7;
            // 
            // txtValorTotal
            // 
            txtValorTotal.Enabled = false;
            txtValorTotal.Location = new Point(443, 153);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new Size(227, 23);
            txtValorTotal.TabIndex = 8;
            // 
            // comboVendedores
            // 
            comboVendedores.DropDownStyle = ComboBoxStyle.DropDownList;
            comboVendedores.FormattingEnabled = true;
            comboVendedores.Location = new Point(87, 64);
            comboVendedores.Name = "comboVendedores";
            comboVendedores.Size = new Size(227, 23);
            comboVendedores.TabIndex = 9;
            // 
            // comboZonas
            // 
            comboZonas.DropDownStyle = ComboBoxStyle.DropDownList;
            comboZonas.FormattingEnabled = true;
            comboZonas.Location = new Point(87, 91);
            comboZonas.Name = "comboZonas";
            comboZonas.Size = new Size(227, 23);
            comboZonas.TabIndex = 10;
            // 
            // comboProdutos
            // 
            comboProdutos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboProdutos.FormattingEnabled = true;
            comboProdutos.Location = new Point(443, 66);
            comboProdutos.Name = "comboProdutos";
            comboProdutos.Size = new Size(227, 23);
            comboProdutos.TabIndex = 11;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(443, 95);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(227, 23);
            txtQuantidade.TabIndex = 12;
            txtQuantidade.TextChanged += txtQuantidade_TextChanged;
            // 
            // dataVendaCalendario
            // 
            dataVendaCalendario.Location = new Point(87, 126);
            dataVendaCalendario.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            dataVendaCalendario.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dataVendaCalendario.Name = "dataVendaCalendario";
            dataVendaCalendario.TabIndex = 13;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(550, 265);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 33);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar Alterações";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(464, 265);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 33);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(24, 23);
            label8.Name = "label8";
            label8.Size = new Size(101, 21);
            label8.TabIndex = 16;
            label8.Text = "Editar Venda";
            // 
            // FormEditarVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 321);
            Controls.Add(label8);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(dataVendaCalendario);
            Controls.Add(txtQuantidade);
            Controls.Add(comboProdutos);
            Controls.Add(comboZonas);
            Controls.Add(comboVendedores);
            Controls.Add(txtValorTotal);
            Controls.Add(txtPrecoUnitario);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormEditarVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Venda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtPrecoUnitario;
        private TextBox txtValorTotal;
        private ComboBox comboVendedores;
        private ComboBox comboZonas;
        private ComboBox comboProdutos;
        private TextBox txtQuantidade;
        private MonthCalendar dataVendaCalendario;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label label8;
    }
}