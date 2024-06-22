using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SalesManagement
{
    public class Users
    {
        public static bool VerificarUtilizador(string utilizador)
        {
            DatabaseHelper dbHelper = new DatabaseHelper();

            string insertQuery = "SELECT Utilizador FROM Utilizadores WHERE Utilizador=@nome";

            SqlParameter paramNome = new SqlParameter("@nome", SqlDbType.VarChar) { Value = utilizador };

            DataTable resultado = dbHelper.GetDataTable(insertQuery, paramNome);

            return resultado != null && resultado.Rows.Count > 0; // Garante que não existem rows na base de dados
        }

        public static void RegistarUtilizador(string utilizador, string password, string cargo)
        {
            DatabaseHelper dbHelper = new DatabaseHelper();

            string insertQuery = "INSERT INTO Utilizadores (Utilizador, Senha, Cargo) VALUES (@nome, @password, @cargo)";

            SqlParameter paramNome = new SqlParameter("@nome", SqlDbType.VarChar) { Value = utilizador };
            SqlParameter paramPassword = new SqlParameter("@password", SqlDbType.VarChar) { Value = password };
            SqlParameter paramCargo = new SqlParameter("@cargo", SqlDbType.Int) { Value = cargo };

            dbHelper.ExecuteQuery(insertQuery, paramNome, paramPassword, paramCargo);
        }

        public static void EliminarUtilizador(string utilizador)
        {
            DatabaseHelper dbHelper = new DatabaseHelper();

            string deleteQuery = "DELETE FROM Utilizadores WHERE Utilizador=@nome";

            SqlParameter paramNome = new SqlParameter("@nome", SqlDbType.VarChar) { Value = utilizador };

            dbHelper.ExecuteQuery(deleteQuery, paramNome);
        }

        public static DataTable ObterUtilizadores ()
        {
            DatabaseHelper dbHelper = new DatabaseHelper();

            string selectQuery = "SELECT * FROM Utilizadores";

            DataTable resultado = dbHelper.GetDataTable(selectQuery);

            return resultado;
        }
    }
}
