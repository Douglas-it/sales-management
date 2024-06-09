using System;
using System.Data;
using System.Data.SqlClient;


// Para executar uma consulta SQL que não retorna dados
/*string insertQuery = "INSERT INTO Tabela (Coluna1, Coluna2) VALUES ('Valor1', 'Valor2')";
dbHelper.ExecuteQuery(insertQuery);*/
namespace SalesManagement
{
    class DatabaseHelper
    {
        string ConnectionString = @"Data Source=DESKTOP-QJ9KR1M\SQLEXPRESS;Initial Catalog=sales-management;Integrated Security=True";

        public SqlConnection GetSqlConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public void ExecuteQuery(string query)
        {
            using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
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