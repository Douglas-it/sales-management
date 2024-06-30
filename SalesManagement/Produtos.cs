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
        /*
         * Função para obter o id da categoria
         * @param nomeCategoria - Nome da categoria
         * @return string - Retorna o id da categoria
         */
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

        /*
         * Função para obter as categorias
         * @param combo - Combobox para preencher
         */
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

        /*
         * Função para verificar se o produto tem vendas associadas
         * @param codigo - Código do produto
         * @return bool - Retorna true se o produto não tiver vendas associadas, false caso contrário
         */
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

        /*
         * Função para verificar se o produto já existe
         * @param codigo - Código do produto
         * @return bool - Retorna true se o produto não existir, false caso contrário
         */
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

        /*
         * Função para adicionar um produto
         * @param codigo - Código do produto
         * @param nome - Nome do produto
         * @param precoDecimal - Preço do produto
         * @param categoria - Categoria do produto
         */
        public static void AdicionarProduto(string codigo, string nome, decimal precoDecimal, string categoria)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();

                string updateQuery = "UPDATE produtos SET Nome = @nome, Preco = @preco, CodigoCategoria = @categoria WHERE Codigo = @codigo";

                SqlParameter paramNome = new SqlParameter("@nome", SqlDbType.VarChar) { Value = nome };
                SqlParameter paramPreco = new SqlParameter("@preco", SqlDbType.Decimal) { Value = precoDecimal };
                SqlParameter paramCategoria = new SqlParameter("@categoria", SqlDbType.VarChar) { Value = Produtos.ObterIdCategoria(categoria) };
                SqlParameter paramCodigo = new SqlParameter("@codigo", SqlDbType.VarChar) { Value = codigo };

                dbHelper.ExecuteQuery(updateQuery, paramNome, paramPreco, paramCategoria, paramCodigo);

                MessageBox.Show("Produto alterado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static DataTable ObterProdutos(string filtro = "")
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();

                string updateQuery = "SELECT * FROM Produtos" + filtro;

                DataTable resultado = dbHelper.GetDataTable(updateQuery);

                if (resultado != null && resultado.Rows.Count > 0)
                    return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return null;
        }

        public static string ObterIdProduto(string nome)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();

                string updateQuery = "SELECT * FROM Produtos WHERE Nome = @Nome";
                SqlParameter paramNome = new SqlParameter("@Nome", SqlDbType.VarChar) { Value = nome };

                DataTable resultado = dbHelper.GetDataTable(updateQuery, paramNome);

                return resultado.Rows[0]["Codigo"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Obter o ID do produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }
    }
}
