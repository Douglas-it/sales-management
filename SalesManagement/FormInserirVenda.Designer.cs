namespace SalesManagement
{
    partial class FormVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenda));
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtQuantidade = new TextBox();
            comboVendedor = new ComboBox();
            comboZona = new ComboBox();
            comboProduto = new ComboBox();
            txtPreco = new TextBox();
            dataVendaCalendario = new MonthCalendar();
            label2 = new Label();
            txtTotalVenda = new TextBox();
            label9 = new Label();
            btnInserir = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 20);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 0;
            label1.Text = "Inserir Venda";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 139);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Produto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 118);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 81);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 4;
            label5.Text = "Vendedor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 168);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 5;
            label6.Text = "Quantidade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(72, 112);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 6;
            label7.Text = "Zona";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(69, 197);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 7;
            label8.Text = "Preço";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(112, 165);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(213, 23);
            txtQuantidade.TabIndex = 12;
            txtQuantidade.TextChanged += txtQuantidade_TextChanged;
            // 
            // comboVendedor
            // 
            comboVendedor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboVendedor.FormattingEnabled = true;
            comboVendedor.Location = new Point(112, 78);
            comboVendedor.Name = "comboVendedor";
            comboVendedor.Size = new Size(213, 23);
            comboVendedor.TabIndex = 13;
            // 
            // comboZona
            // 
            comboZona.DropDownStyle = ComboBoxStyle.DropDownList;
            comboZona.FormattingEnabled = true;
            comboZona.Location = new Point(112, 107);
            comboZona.Name = "comboZona";
            comboZona.Size = new Size(213, 23);
            comboZona.TabIndex = 14;
            // 
            // comboProduto
            // 
            comboProduto.DropDownStyle = ComboBoxStyle.DropDownList;
            comboProduto.FormattingEnabled = true;
            comboProduto.Location = new Point(112, 136);
            comboProduto.Name = "comboProduto";
            comboProduto.Size = new Size(213, 23);
            comboProduto.TabIndex = 16;
            comboProduto.SelectionChangeCommitted += comboProduto_SelectionChangeCommitted;
            // 
            // txtPreco
            // 
            txtPreco.Enabled = false;
            txtPreco.Location = new Point(112, 194);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(213, 23);
            txtPreco.TabIndex = 17;
            // 
            // dataVendaCalendario
            // 
            dataVendaCalendario.Location = new Point(462, 78);
            dataVendaCalendario.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            dataVendaCalendario.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dataVendaCalendario.Name = "dataVendaCalendario";
            dataVendaCalendario.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(427, 156);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 19;
            label2.Text = "Data";
            // 
            // txtTotalVenda
            // 
            txtTotalVenda.Enabled = false;
            txtTotalVenda.Location = new Point(112, 223);
            txtTotalVenda.Name = "txtTotalVenda";
            txtTotalVenda.Size = new Size(213, 23);
            txtTotalVenda.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(39, 226);
            label9.Name = "label9";
            label9.Size = new Size(67, 15);
            label9.TabIndex = 20;
            label9.Text = "Total Venda";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(368, 294);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(121, 33);
            btnInserir.TabIndex = 22;
            btnInserir.Text = "Inserir Venda";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(274, 294);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 33);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnInserir);
            Controls.Add(txtTotalVenda);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(dataVendaCalendario);
            Controls.Add(txtPreco);
            Controls.Add(comboProduto);
            Controls.Add(comboZona);
            Controls.Add(comboVendedor);
            Controls.Add(txtQuantidade);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vendas";
            FormClosed += FormVenda_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtQuantidade;
        private ComboBox comboVendedor;
        private ComboBox comboZona;
        private ComboBox comboProduto;
        private TextBox txtPreco;
        private MonthCalendar dataVendaCalendario;
        private Label label2;
        private TextBox textBox1;
        private Label label9;
        private TextBox txtTotalVenda;
        private Button btnInserir;
        private Button btnCancelar;
    }
}