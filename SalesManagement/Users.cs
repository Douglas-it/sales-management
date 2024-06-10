using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SalesManagement
{
    public class Utilizadores
    {
        public static bool login(string username, string password)
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

                    return true;
                }
                else
                {
                    MessageBox.Show("Credenciais inválidas!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                    
            }
            catch (Exception ex) // Apanhar exceções
            {
                MessageBox.Show("Erro ao tentar conectar a base de dados: " + ex.Message);
            }
            return false;
        }
    }
}
