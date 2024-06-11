using SalesManagement;
using System.Data;
using System.Data.SqlClient;

namespace SalesManagement
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Obter o username e password
            string username = inputUsername.Text;
            string password = inputPassword.Text;

            // Verificar se o username e password são válidos
            if (OperacoesGerais.LerStringValida(username) && OperacoesGerais.LerStringValida(password))
            {

                if (Utilizadores.Login(username, password)) // Chamar a função login da classe Utilizadores
                    this.Hide(); // Esconder o form atual
                else
                {
                    inputUsername.Text = "";
                    inputPassword.Text = "";
                }
            }
            else
                MessageBox.Show("O formato das credências esta inválido!"); // Mostrar mensagem de erro
        }
    }
}
