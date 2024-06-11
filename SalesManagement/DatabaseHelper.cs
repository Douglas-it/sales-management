using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SalesManagement
{
    class DatabaseHelper
    {
        // Obter a string de conexão do ficheiro de configuração
        string ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        // Cria a conexão SQL
        public SqlConnection GetSqlConnection()
        {
            return new SqlConnection(ConnectionString);
        }


        // Executa um Query que não retorna dados
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

        // Executa um Query que retorna dados
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