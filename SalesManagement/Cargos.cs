using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement
{
    public class Cargos
    {
        /*
         * Função para listar os cargos
         * @param cargos ComboBox
         */
        public static void ListarCargos(ComboBox cargos)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper(); // Inicializar a classe DatabaseHelper

                string selectQuery = "SELECT * FROM UtilizadoresCargos"; // Query para selecionar os cargos

                DataTable resultado = dbHelper.GetDataTable(selectQuery); // Obter o resultado da query

                cargos.Items.Clear(); // Garante que não existe cargos a serem mostrados

                // Se o resultado da não for nulo ou igual a zero
                if (resultado != null || resultado.Rows.Count == 0)
                    foreach (DataRow row in resultado.Rows)
                        cargos.Items.Add(row["CargoNome"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar cargos: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         * Função para obter o ID do cargo
         * @param nome string
         * @return string
         */
        public static string ObterCargoId(string nome)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper(); // Inicializar a classe DatabaseHelper

                string selectQuery = "SELECT CargoId FROM UtilizadoresCargos WHERE CargoNome = @nome"; // Query para selecionar o ID do cargo

                SqlParameter paramProduto = new SqlParameter("@nome", SqlDbType.VarChar) { Value = nome }; // Parâmetros da Query

                DataTable resultado = dbHelper.GetDataTable(selectQuery, paramProduto); // Obter o resultado da query

                // Se o resultado da não for nulo
                if (resultado != null)
                    return resultado.Rows[0]["CargoId"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar cargos: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        /*
         * Função para obter o nome do cargo
         * @param id string
         * @return string
         */
        public static string ObterCargoNome(string id)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper(); // Inicializar a classe DatabaseHelper

                string selectQuery = "SELECT CargoNome FROM UtilizadoresCargos WHERE CargoId = @id";  // Query para selecionar o nome do cargo

                SqlParameter paramProduto = new SqlParameter("@id", SqlDbType.VarChar) { Value = id }; // Parâmetros da Query

                DataTable resultado = dbHelper.GetDataTable(selectQuery, paramProduto); // Obter o resultado da query

                // Se o resultado da não for nulo
                if (resultado != null)
                    return resultado.Rows[0]["CargoNome"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar cargos: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }
    }
}
