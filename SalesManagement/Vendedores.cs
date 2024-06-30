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
        /*
         * Função para inserir um novo Comercial
         * @param string codigo
         * @param string nome
         * @param string comissao
         */
        public static void InserirComercial(string codigo, string nome, string comissao)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();

                // Query para verificar se o vendedor existe com base no código inserido pelo utilizador
                string selectQuery = "SELECT * FROM Vendedores WHERE Codigo = @Codigo";

                // Parâmetros para a Query
                SqlParameter selectParam = new SqlParameter("@Codigo", SqlDbType.VarChar) { Value = codigo };

                // Executa a query e retorna o resultado
                DataTable result = dbHelper.GetDataTable(selectQuery, selectParam);

                // Se não existerem rows ==> Adiciona o novo Comercial
                if (result != null && result.Rows.Count == 0)
                {
                    string insertQuery = "INSERT INTO Vendedores (Codigo, Nome, Comissao) VALUES (@Codigo, @Nome, @Comissao)";

                    SqlParameter insertParam1 = new SqlParameter("@Codigo", SqlDbType.VarChar) { Value = codigo };
                    SqlParameter insertParam2 = new SqlParameter("@Nome", SqlDbType.VarChar) { Value = nome };
                    SqlParameter insertParam3 = new SqlParameter("@Comissao", SqlDbType.Float) { Value = comissao };

                    dbHelper.ExecuteQuery(insertQuery, insertParam1, insertParam2, insertParam3);

                    MessageBox.Show("Comercial adicionado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Já existe um comercial com esse código!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar conectar a base de dados: " + ex.Message);
            }
        }

        /*
         * Função para eliminar um comercial
         * @param string id
         */
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

        /* 
         * Função que edita um Comercial
         * @param string id
         * @param string nome
         * @param decimal comissao
         */
        public static bool EditarComercial(string id, string nome, decimal comissao)
        {
            try
            {
                // Inicializar a classe DatabaseHelper
                DatabaseHelper dbHelper = new DatabaseHelper();

                // Query para selecionar o utilizador
                string selectQuery = "UPDATE Vendedores SET nome = @nomeComercial, comissao = @comissaoComercial WHERE codigo = @codigoComercial";

                // Parâmetros para a query
                SqlParameter param1 = new SqlParameter("@nomeComercial", SqlDbType.VarChar) { Value = nome };
                SqlParameter param2 = new SqlParameter("@comissaoComercial", SqlDbType.Decimal) { Value = comissao };
                SqlParameter param3 = new SqlParameter("@codigoComercial", SqlDbType.VarChar) { Value = id };

                // Obter o resultado da query
                dbHelper.ExecuteQuery(selectQuery, param1, param2, param3);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar atualizar o comercial: " + ex.Message);
            }
            return false;
        }

        public static DataTable ObterComerciais(string filtro = "")
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();

                string selectQuery = "SELECT * FROM Vendedores" + filtro;

                DataTable resultado = dbHelper.GetDataTable(selectQuery);

                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar conectar a base de dados: " + ex.Message);

            }

            return null;
        }

        public static int ObterIdComercial(string nome)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();

                string selectQuery = "SELECT Codigo FROM Vendedores WHERE Nome = @Nome";

                SqlParameter paramNome = new SqlParameter("@Nome", SqlDbType.VarChar) { Value = nome };

                DataTable resultado = dbHelper.GetDataTable(selectQuery, paramNome);

                return Convert.ToInt32(resultado.Rows[0]["Codigo"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter o ID do Comercial: " + ex.Message);
                return -1;
            }
        }
    }
}
