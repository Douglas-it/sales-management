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
            string filtro = " WHERE Codigo = '" + codigo + "'"; // Filtro para verificar se o comercial já existe

            try
            {
                DataTable resultado = ObterComerciais(filtro); // Obter os comerciais (com o filtro)

                DatabaseHelper dbHelper = new DatabaseHelper(); // Inicializar a classe DatabaseHelper

                // Se não existerem rows ==> Adiciona o novo Comercial
                if (resultado != null && resultado.Rows.Count == 0)
                {
                    // Query para inserir o novo Comercial
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

        /* 
         * Função para obter os comerciais
         * @param string filtro
         */
        public static DataTable ObterComerciais(string filtro = "")
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper(); // Inicializar a classe DatabaseHelper

                string selectQuery = "SELECT * FROM Vendedores" + filtro; // Query para selecionar todos os comerciais

                DataTable resultado = dbHelper.GetDataTable(selectQuery); // Obter o resultado da query

                return resultado; // Retornar o resultado
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar conectar a base de dados: " + ex.Message);

            }

            return null;
        }

        /* 
         * Função para obter o ID do comercial
         * @param string nome
         */
        public static int ObterIdComercial(string nome)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper(); // Inicializar a classe DatabaseHelper

                string selectQuery = "SELECT Codigo FROM Vendedores WHERE Nome = @Nome"; // Query para selecionar o ID do vendedor

                SqlParameter paramNome = new SqlParameter("@Nome", SqlDbType.VarChar) { Value = nome }; // Parâmetros para a query

                DataTable resultado = dbHelper.GetDataTable(selectQuery, paramNome); // Obter o resultado da query

                return Convert.ToInt32(resultado.Rows[0]["Codigo"]); // Retornar o ID do vendedor
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter o ID do vendedor: " + ex.Message);
                return -1;
            }
        }

        /* 
         * Função para verificar se o comercial tem vendas
         * @param string id
         */
        public static bool VerificarVendas (string id)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper(); // Inicializar a classe DatabaseHelper

                string selectQuery = "SELECT * FROM Vendas WHERE CodigoVendedor = @id"; // Query para verificar se o vendedor tem vendas

                SqlParameter paramId = new SqlParameter("@id", SqlDbType.VarChar) { Value = id }; // Parâmetros para a query

                DataTable resultado = dbHelper.GetDataTable(selectQuery, paramId); // Obter o resultado da query

                if (resultado.Rows.Count > 0) // Se o resultado da query for maior que 0
                    return true; // Retorna verdadeiro
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar se o vendedor tinha vendas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false; // Retorna falso
        }
    }
}
