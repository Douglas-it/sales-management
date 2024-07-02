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
         * @return int - Retorna o id da categoria
         */
        public static int ObterCategoriaId(string nomeCategoria)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper(); // Inicializa a classe DatabaseHelper

                string selectQuery = "SELECT * FROM Categorias WHERE nome = @nome"; // Query para obter o id da categoria

                SqlParameter paramNome = new SqlParameter("@nome", SqlDbType.VarChar) { Value = nomeCategoria };

                DataTable resultado = dbHelper.GetDataTable(selectQuery, paramNome);

                return Convert.ToInt32(resultado.Rows[0]["Codigo"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter as categorias: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        /*
         * Função para obter as categorias
         * @param combo - Combobox para preencher
         */
        public static DataTable ObterCategorias(string filtro = "")
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper(); // Inicializa a classe DatabaseHelper

                string selectQuery = "SELECT * FROM categorias " + filtro; // Query para obter as categorias

                DataTable resultado = dbHelper.GetDataTable(selectQuery); // Executa a query

                return resultado; // Retorna o resultado em DataTable
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter as categorias: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /*
         * Função para criar uma nova categoria
         * @param nomeCategoria
         */
        public static void CriarCategoria(string nomeCategoria)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper(); // Inicializa a classe DatabaseHelper

                string selectQuery = "INSERT INTO Categorias(Nome) VALUES (@nome)"; // Query para inserir a categoria

                SqlParameter paramNome = new SqlParameter("@nome", SqlDbType.VarChar) { Value = nomeCategoria }; // Cria o parâmetro para o nome da categoria

                dbHelper.ExecuteQuery(selectQuery, paramNome); // Executa a query
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter as categorias: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         * Função para editar uma categoria
         * @param nomeCategoria
         * @param id
         */
        public static void EditarCategoria(string nomeCategoria, int id)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper(); // Inicializa a classe DatabaseHelper

                string selectQuery = "UPDATE Categorias SET nome = @nome WHERE Codigo = @id"; // Query para editar a categoria
                 
                SqlParameter paramNome = new SqlParameter("@nome", SqlDbType.VarChar) { Value = nomeCategoria }; // Cria o parâmetro para o nome da categoria
                SqlParameter paramId = new SqlParameter("@id", SqlDbType.Int) { Value = id }; // Cria o parâmetro para o id da categoria
                 
                dbHelper.ExecuteQuery(selectQuery, paramNome, paramId); // Executa a query

                MessageBox.Show("Categoria editada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter as categorias: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         * Função para eliminar uma categoria
         * @param nomeCategoria
         */
        public static void EliminarCategoria(string nomeCategoria)
        {
            int idCategoria = ObterCategoriaId(nomeCategoria); // Obtem o id da categoria

            // Verifica se a categoria esta a ser utilizada
            if (VerificarUsoCategoria(idCategoria))
            {
                MessageBox.Show("Não é possível eliminar a categoria, pois existem produtos associados a ela.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Elimina a categoria
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper(); // Inicializa a classe DatabaseHelper

                string selectQuery = "DELETE FROM Categorias WHERE nome = @nome"; // Query para eliminar a categoria

                SqlParameter paramNome = new SqlParameter("@nome", SqlDbType.VarChar) { Value = nomeCategoria }; // Cria o parâmetro para o nome da categoria

                dbHelper.ExecuteQuery(selectQuery, paramNome); // Executa a query

                MessageBox.Show("Categoria eliminada com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter as categorias: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         * Função para verificar se a categoria está a ser usada
         * @param idCategoria
         */
        public static bool VerificarUsoCategoria (int idCategoria)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper(); // Inicializa a classe DatabaseHelper

                string selectQuery = "SELECT * FROM Produtos WHERE CodigoCategoria = @idCategoria"; // Query para verificar se a categoria está a ser usada

                SqlParameter paramIdCategoria = new SqlParameter("@idCategoria", SqlDbType.Int) { Value = idCategoria }; // Cria o parâmetro para o id da categoria

                DataTable resultado = dbHelper.GetDataTable(selectQuery, paramIdCategoria); // Executa a query

                if (resultado.Rows.Count > 0)
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar as vendas da categoria: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
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
                DatabaseHelper dbHelper = new DatabaseHelper(); // Inicializa a classe DatabaseHelper
                string selectQuery = "SELECT * FROM vendas WHERE CodigoProduto = @codigo"; // Query para verificar se o produto tem vendas associadas
                SqlParameter paramCodigo = new SqlParameter("@codigo", SqlDbType.VarChar) { Value = codigo }; // Cria o parâmetro para o código do produto

                DataTable resultado = dbHelper.GetDataTable(selectQuery, paramCodigo); // Executa a query

                if (resultado.Rows.Count > 0) // Se o resultado da query for maior que 0
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
         * Função para verificar o ID do Produto
         * @param codigo - Código do produto
         * @return bool - Retorna true se o produto não existir, false caso contrário
         */
        public static bool VerificarIdProduto(string codigo)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper(); // Inicializa a classe DatabaseHelper
                string selectQuery = "SELECT * FROM Produtos WHERE Codigo = @codigo"; // Query para verificar o ID do produto
                SqlParameter paramCodigo = new SqlParameter("@codigo", SqlDbType.VarChar) { Value = codigo }; // Cria o parâmetro para o código do produto

                DataTable resultado = dbHelper.GetDataTable(selectQuery, paramCodigo); // Executa a query

                if (resultado.Rows.Count > 0)
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
                DatabaseHelper dbHelper = new DatabaseHelper(); // Inicializa a classe DatabaseHelper

                string updateQuery = "UPDATE produtos SET Nome = @nome, Preco = @preco, CodigoCategoria = @categoria WHERE Codigo = @codigo"; // Query para adicionar o produto

                SqlParameter paramNome = new SqlParameter("@nome", SqlDbType.VarChar) { Value = nome }; // Cria o parâmetro para o nome do produto
                SqlParameter paramPreco = new SqlParameter("@preco", SqlDbType.Decimal) { Value = precoDecimal }; // Cria o parâmetro para o preço do produto
                SqlParameter paramCategoria = new SqlParameter("@categoria", SqlDbType.VarChar) { Value = Produtos.ObterCategoriaId(categoria) }; // Cria o parâmetro para a categoria do produto
                SqlParameter paramCodigo = new SqlParameter("@codigo", SqlDbType.VarChar) { Value = codigo }; // Cria o parâmetro para o código do produto

                dbHelper.ExecuteQuery(updateQuery, paramNome, paramPreco, paramCategoria, paramCodigo); // Executa a query

                MessageBox.Show("Produto alterado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar o produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         * Função para obter os produtos
         * @param filtro - Filtro para a query
         */
        public static DataTable ObterProdutos(string filtro = "")
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper(); // Inicializa a classe DatabaseHelper

                string updateQuery = "SELECT * FROM Produtos " + filtro; // Query para obter os produtos

                DataTable resultado = dbHelper.GetDataTable(updateQuery); // Executa a query

                if (resultado != null && resultado.Rows.Count > 0) // Se o resultado da query for diferente de nulo e tiver mais de 0 linhas
                    return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter os produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return null;
        }

        /* Função para obter o ID do produto
         * @param nome - Nome do produto
         */
        public static string ObterIdProduto(string nome)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper(); // Inicializa a classe DatabaseHelper

                string updateQuery = "SELECT * FROM Produtos WHERE Nome = @Nome"; // Query para obter o ID do produto
                SqlParameter paramNome = new SqlParameter("@Nome", SqlDbType.VarChar) { Value = nome }; // Cria o parâmetro para o nome do produto

                DataTable resultado = dbHelper.GetDataTable(updateQuery, paramNome); // Executa a query

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
