using SalesManagement;
using System.Data;
using System.Data.SqlClient;

namespace SalesManagement
{
    public partial class FormLogin : System.Windows.Forms.Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        // Botão para fazer login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Obtém o username e password
            string username = inputUsername.Text;
            string password = inputPassword.Text;

            // Verificar se o username e password são válidos
            if (!OperacoesGerais.LerStringValida(username) || !OperacoesGerais.LerStringValida(password))
            {
                MessageBox.Show("O formato das credências esta inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Utilizadores.Login(username, password); // Realiza a autenticação do Utilizador

            // Caso o utilizador não seja autenticado, reseta os campos
            inputUsername.Text = "";
            inputPassword.Text = "";
        }

        // Botão para sair da aplicação
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
