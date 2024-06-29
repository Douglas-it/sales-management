using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace SalesManagement
{
    public class BackOffice
    {
        public static void InserirProduto(string nome, string codigo, string preco, string categoria)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();

                string insertQuery = "INSERT INTO Produtos (Codigo, Nome, CodigoCategoria, Preco) VALUES (@codigo, @nome, @CodigoCategoria, @preco)";

                SqlParameter paramNome = new SqlParameter("@nome", SqlDbType.VarChar) { Value = nome };
                SqlParameter paramCodigo = new SqlParameter("@codigo", SqlDbType.VarChar) { Value = codigo };
                SqlParameter paramPreco = new SqlParameter("@preco", SqlDbType.Float) { Value = preco };
                SqlParameter paramCategoria = new SqlParameter("@CodigoCategoria", SqlDbType.VarChar) { Value = Produtos.ObterIdCategoria(categoria) };

                dbHelper.ExecuteQuery(insertQuery, paramNome, paramCodigo, paramPreco, paramCategoria);

                MessageBox.Show("Produto adicionado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar adicionar o produto: " + ex.Message);
            }
        }
    }
}
    