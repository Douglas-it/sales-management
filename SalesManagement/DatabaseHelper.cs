using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


// Para executar uma consulta SQL que não retorna dados
/*string insertQuery = "INSERT INTO Tabela (Coluna1, Coluna2) VALUES ('Valor1', 'Valor2')";
dbHelper.ExecuteQuery(insertQuery);*/
namespace SalesManagement
{
    class DatabaseHelper
    {
        // Obter a string de conexão do ficheiro de configuração
        string ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        public SqlConnection GetSqlConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public void ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();
                
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddRange(parameters);
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetDataTable(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddRange(parameters);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable result = new DataTable();
                        result.Load(reader);
                        return result;
                    }
                }
            }
        }

    }
}