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
        /*
         * Funçaõ para Eliminar uma venda
         * @param codigo - Código da venda
         */
        public static void EliminarVenda(string codigo)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper(); // Inicializa a classe DatabaseHelper

                string deleteQuery = "DELETE FROM vendas WHERE Id = @idProduto"; // Query para eliminar a venda

                SqlParameter paramIdProduto = new SqlParameter("@idProduto", SqlDbType.VarChar) { Value = codigo }; // Cria o parâmetro para o id do produto

                dbHelper.ExecuteQuery(deleteQuery, paramIdProduto); // Executa a query

                MessageBox.Show("Venda eliminada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao eliminar a venda" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         * Função para Inserir uma venda
         * @param codigoProduto - Código do produto
         * @param codigoVendedor - Código do vendedor
         * @param codigoZona - Código da zona
         * @param dataVenda - Data da venda
         * @param quantidade - Quantidade
         * @param valorTotal - Valor total da venda
         */
        public static void InserirVenda(string codigoProduto, int codigoVendedor, int codigoZona, string dataVenda, string quantidade, string valorTotal)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();

                string insertQuery = @"
                    INSERT INTO Vendas (CodigoVendedor, Zona, DataVenda, Quantidade, CodigoProduto, ValorVenda) VALUES 
                    (@codigoVendedor, @codigoZona, @dataVenda, @quantidade, @codigoProduto, @valorTotal)";

                SqlParameter paramCodigoProduto = new SqlParameter("@codigoProduto", SqlDbType.VarChar) { Value = codigoProduto };
                SqlParameter paramCodigoVendedor = new SqlParameter("@codigoVendedor", SqlDbType.Int) { Value = codigoVendedor };
                SqlParameter paramCodigoZona = new SqlParameter("@codigoZona", SqlDbType.Int) { Value = codigoZona };
                SqlParameter paramDataVenda = new SqlParameter("@dataVenda", SqlDbType.Date) { Value = dataVenda };
                SqlParameter paramQuantidade = new SqlParameter("@quantidade", SqlDbType.Int) { Value = quantidade };
                SqlParameter paramValorTotal = new SqlParameter("@valorTotal", SqlDbType.Decimal) { Value = valorTotal };

                dbHelper.ExecuteQuery(insertQuery, paramCodigoProduto, paramCodigoVendedor, paramCodigoZona, paramDataVenda, paramQuantidade, paramValorTotal);

                MessageBox.Show("Venda inserida com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar inserir a venda: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
