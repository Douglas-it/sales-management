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
                        FormInicial FormInicial = new FormInicial(); // Inicializar novo form
                        FormInicial.Show(); // Mostra Novo Form

                        this.Hide(); // Esconde o Form de Login
                    }
                    else
                        MessageBox.Show("Credenciais inválidas!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex) // Apanhar exceções
                {
                    MessageBox.Show("Erro ao tentar conectar a base de dados: " + ex.Message);
                }
                
            }
            else
                MessageBox.Show("O formato das credências esta inválido!"); // Mostrar mensagem de erro
        }
    }
}
