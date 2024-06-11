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
    public partial class FormVendas : Form
    {
        public FormVendas()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormInicial FormInicial = new FormInicial();
            FormInicial.Show();

            this.Hide();
        }

        private void FormVendas_Load(object sender, EventArgs e)
        {

        }
    }
}
