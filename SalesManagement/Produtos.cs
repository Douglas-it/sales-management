using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement
{
    public class Produtos
    {
        public static bool VerificarProduto(string codigo)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();
                string selectQuery = "SELECT * FROM vendas WHERE CodigoProduto = @codigo";
                SqlParameter paramCodigo = new SqlParameter("@codigo", SqlDbType.VarChar) { Value = codigo };

                DataTable result = dbHelper.GetDataTable(selectQuery, paramCodigo);

                if (result.Rows.Count > 0)
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar o produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        public static bool VerificarIdProduto(string codigo)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();
                string selectQuery = "SELECT * FROM Produtos WHERE Codigo = @codigo";
                SqlParameter paramCodigo = new SqlParameter("@codigo", SqlDbType.VarChar) { Value = codigo };

                DataTable result = dbHelper.GetDataTable(selectQuery, paramCodigo);

                if (result.Rows.Count > 0)
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar o produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        public static string ObterIdCategoria(string nomeCategoria)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();
                string selectQuery = "SELECT * FROM categorias WHERE Nome = @nome";
                SqlParameter paramNome = new SqlParameter("@nome", SqlDbType.VarChar) { Value = nomeCategoria };

                DataTable result = dbHelper.GetDataTable(selectQuery, paramNome);

                return result.Rows[0]["Codigo"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter o nome da categoria: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public static void ObterCategorias(ComboBox combo)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();
                string selectQuery = "SELECT * FROM categorias";
                DataTable result = dbHelper.GetDataTable(selectQuery);

                foreach (DataRow row in result.Rows)
                    combo.Items.Add(row["Nome"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter as categorias: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
