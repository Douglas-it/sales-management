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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textVendedor = new TextBox();
            textZona = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(292, 20);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 0;
            label1.Text = "Inserir Venda";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 150);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 1;
            label2.Text = "Código Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 185);
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
            label5.Location = new Point(15, 92);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 4;
            label5.Text = "Vendedor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 219);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 5;
            label6.Text = "Quantidade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 118);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 6;
            label7.Text = "Zona";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 251);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 7;
            label8.Text = "Preço";
            // 
            // textVendedor
            // 
            textVendedor.Location = new Point(124, 89);
            textVendedor.Name = "textVendedor";
            textVendedor.Size = new Size(138, 23);
            textVendedor.TabIndex = 8;
            // 
            // textZona
            // 
            textZona.Location = new Point(124, 118);
            textZona.Name = "textZona";
            textZona.Size = new Size(138, 23);
            textZona.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(124, 150);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(138, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(124, 179);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(138, 23);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(124, 216);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(138, 23);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(124, 245);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(138, 23);
            textBox6.TabIndex = 13;
            // 
            // FormVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textZona);
            Controls.Add(textVendedor);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vendas";
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
        private Label label8;
        private TextBox textVendedor;
        private TextBox textZona;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}