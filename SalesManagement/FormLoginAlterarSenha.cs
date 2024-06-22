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
    public partial class FormLoginAlterarSenha : Form
    {
        public FormLoginAlterarSenha()
        {
            InitializeComponent();
        }

        private void FormLoginAlterarSenha_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
