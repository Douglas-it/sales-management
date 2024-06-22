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

        private string username;
        private string password;

        private void Login(string username, string password)
        {
            try
            {
                // Inicializar a classe DatabaseHelper
                DatabaseHelper dbHelper = new DatabaseHelper();

                // Query para selecionar o utilizador
                string selectQuery = "SELECT * FROM Utilizadores WHERE Utilizador = @Username AND Senha= @Password";

                // Parâmetros para a query
                SqlParameter param1 = new SqlParameter("@Username", SqlDbType.VarChar) { Value = username };
                SqlParameter param2 = new SqlParameter("@Password", SqlDbType.VarChar) { Value = password };


                // Obter o resultado da query
                DataTable result = dbHelper.GetDataTable(selectQuery, param1, param2);

                // Se o resultado tiver 1 linha, então o utilizador existe
                if (result.Rows.Count == 1)
                {
                    // Verifica se o utilizador é Admin ou não
                    if (Convert.ToInt32(result.Rows[0]["Cargo"]) == 1)
                        Globals.admin = true;

                    if (Convert.ToInt32(result.Rows[0]["flag"]) == 1)
                    {
                        MessageBox.Show("Mudar a senha!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    FormInicial FormInicial = new FormInicial(); // Inicializar novo form
                    FormInicial.Show(); // Mostra Novo Form

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Credenciais inválidas!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    inputUsername.Text = "";
                    inputPassword.Text = "";
                }

            }
            catch (Exception ex) // Apanhar exceções
            {
                MessageBox.Show("Erro ao tentar conectar a base de dados: " + ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Obtém o username e password
            username = inputUsername.Text;
            password = inputPassword.Text;

            // Verificar se o username e password são válidos
            if (OperacoesGerais.LerStringValida(username) && OperacoesGerais.LerStringValida(password))
                Login(username, password); // Realiza a autenticação do Utilizador
            else
                MessageBox.Show("O formato das credências esta inválido!"); // Mostrar mensagem de erro
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
