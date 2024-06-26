using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement
{
    public class Vendas
    {
        public static void EliminarVenda(string codigo)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper(); // Inicializa a classe DatabaseHelper

                string deleteQuery = "DELETE FROM vendas WHERE Id = @idProduto"; // Query para eliminar a venda

                SqlParameter paramIdProduto = new SqlParameter("@idProduto", SqlDbType.Char) { Value = codigo }; // Cria o parametro para o id do produto

                dbHelper.ExecuteQuery(deleteQuery, paramIdProduto); // Executa a query

                MessageBox.Show("Produto eliminado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao eliminar a venda" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
