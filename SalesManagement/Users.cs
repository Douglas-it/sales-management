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

            string insertQuery = "INSERT INTO Utilizadores (Utilizador, Senha, Cargo, flag) VALUES (@nome, @password, @cargo, 0)";

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

        public static void ObterUtilizadores(ComboBox nome)
        {
            // Limpa o ComboBox 
            nome.Items.Clear();

            DatabaseHelper dbHelper = new DatabaseHelper();

            string selectQuery = "SELECT * FROM Utilizadores";

            DataTable resultado = dbHelper.GetDataTable(selectQuery);
             
            // Verifica se o resultado for nulo ou vazio
            if (resultado == null)
            {
                MessageBox.Show("Não existem utilizadores na base de dados. Por favor adicione um utilizador primeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nome.Items.Add("Utilizadores não encontrados.");
                return;
            }

            // Adicionar os nomes dos utilizadores ao ComboBox
            foreach (DataRow row in resultado.Rows)
            {
                nome.Items.Add(row["Utilizador"].ToString());
            }
        }

        public static DataTable ObterInformacaoUtilizador(string utilizador)
        {
            DatabaseHelper dbHelper = new DatabaseHelper();

            string selectQuery = "SELECT * FROM Utilizadores WHERE Utilizador = @utilizador";

            SqlParameter paramUtilizador = new SqlParameter("@utilizador", SqlDbType.VarChar) { Value = utilizador };

            DataTable resultado = dbHelper.GetDataTable(selectQuery, paramUtilizador);

            // Retorna as informações do utilizador
            return resultado;
        }

        public static void AlterarUtilizador (string id, string utilizador, string cargo)
        {
            DatabaseHelper dbHelper = new DatabaseHelper();

            string updateQuery = "UPDATE Utilizadores SET Utilizador = @utilizador, cargo = @cargo WHERE id = @id";

            SqlParameter paramUtilizador = new SqlParameter("@utilizador", SqlDbType.VarChar) { Value = utilizador };
            SqlParameter paramCargo = new SqlParameter("@cargo", SqlDbType.Int) { Value = cargo };
            SqlParameter paramId = new SqlParameter("@id", SqlDbType.Int) { Value = id };

            dbHelper.ExecuteQuery(updateQuery, paramUtilizador, paramCargo, paramId);

        }

        public static void AlterarSenha(string id)
        {
            DatabaseHelper dbHelper = new DatabaseHelper();

            string updateQuery = "UPDATE Utilizadores SET flag = 1 WHERE id = @id";

            SqlParameter paramId = new SqlParameter("@id", SqlDbType.Int) { Value = id };

            dbHelper.ExecuteQuery(updateQuery, paramId);
        }
    }
}
