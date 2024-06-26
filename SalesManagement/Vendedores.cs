using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement
{
    public class Vendedores
    {
        public static void ApagarComercial(string id)
        {
            try
            {
                // Inicializar a classe DatabaseHelper
                DatabaseHelper dbHelper = new DatabaseHelper();

                // Query para selecionar o utilizador
                string selectQuery = "DELETE FROM Vendedores WHERE codigo = @codigoComercial";

                // Parâmetros para a query
                SqlParameter param1 = new SqlParameter("@codigoComercial", SqlDbType.VarChar) { Value = id };

                // Obter o resultado da query
                dbHelper.ExecuteQuery(selectQuery, param1);

                MessageBox.Show("O comercial foi eliminado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar apagar o comercial: " + ex.Message);
            }
        }
    }
}
