using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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

        private void btnMudarSenha_Click(object sender, EventArgs e)
        {
            string password = inputSenha.Text;
            string repetirPassword = inputRepetirSenha.Text;

            // Verificar se as senhas são válidas
            if (!OperacoesGerais.LerStringValida(password) || !OperacoesGerais.LerStringValida(repetirPassword))
            {
                MessageBox.Show("A senha introduzida não é válida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar se as senhas coincidem
            if (password != repetirPassword)
            {
                MessageBox.Show("As senhas não coincidem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Tem a certeza que deseja guardar esta alteração?", "Confirme a sua operação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            
            if (result == DialogResult.OK)
            {
                Utilizadores.AlterarSenha(password, Globals.idUtilizador);
                
                this.Hide();

                FormInicial FormInicial = new FormInicial();
                FormInicial.Show();
            }
        }
    }
}
