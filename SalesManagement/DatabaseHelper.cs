using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SalesManagement
{
    class DatabaseHelper
    {
        // Obtém a connection string do ficheiro de configuração (app.config)
        string ConnectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString;

        /* 
         * Cria e retorna uma nova instancia de SqlConnection com a ConnectionString
         * 
         * @return SqlConnection
         */
        public SqlConnection GetSqlConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        /* 
         * Executa um Query que não retorna dados
         * 
         * @param string query
         * @param SqlParameter[] parameters
         */
        public void ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = GetSqlConnection()) // Cria uma nova conexão
            {
                connection.Open(); // Abre a conexão

                using (SqlCommand command = new SqlCommand(query, connection)) // Cria um novo comando SQL
                {
                    command.Parameters.AddRange(parameters); // Adiciona os parâmetros à query
                    command.ExecuteNonQuery(); // Executa a query
                }
            }
        }

        /* 
         * Executa um Query que retorna dados
         * 
         * @param string query
         * @param SqlParameter[] parameters
         * @return DataTable
         */
        public DataTable GetDataTable(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = GetSqlConnection()) // Cria uma nova conexão
            {
                connection.Open(); // Abre a conexão

                using (SqlCommand command = new SqlCommand(query, connection)) // Cria um novo comando SQL
                {
                    command.Parameters.AddRange(parameters); // Adiciona os parâmetros à query

                    using (SqlDataReader reader = command.ExecuteReader()) // Executa a query e obtém o resultado
                    {
                        DataTable result = new DataTable(); // Cria uma nova DataTable
                        result.Load(reader); // Carrega o resultado do reader para a DataTable
                        return result; // Retorna a DataTable
                    }
                }
            }
        }
    }
}