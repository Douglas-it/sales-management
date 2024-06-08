using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class FormInicial : System.Windows.Forms.Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        private void FormInicial_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVendedores formVendedores = new FormVendedores();
            formVendedores.Show();

            this.Hide();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FormProdutos formProdutos = new FormProdutos();
            formProdutos.Show();

            this.Hide();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            FormVendas formVendas = new FormVendas();
            formVendas.Show();

            this.Hide();
        }
    }
}
