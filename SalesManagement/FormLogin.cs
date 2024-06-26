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

        // Bot�o para fazer login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Obt�m o username e password
            string username = inputUsername.Text;
            string password = inputPassword.Text;

            // Verificar se o username e password s�o v�lidos
            if (!OperacoesGerais.LerStringValida(username) || !OperacoesGerais.LerStringValida(password))
            {
                MessageBox.Show("O formato das cred�ncias esta inv�lido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Utilizadores.Login(username, password); // Realiza a autentica��o do Utilizador

            // Caso o utilizador n�o seja autenticado, reseta os campos
            inputUsername.Text = "";
            inputPassword.Text = "";
        }

        // Bot�o para sair da aplica��o
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
