using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Runtime.CompilerServices;

namespace SalesManagement
{
    public class Utilizadores
    {
        /* 
         * Função para verificar se o utilizador existe
         * @param utilizador - Nome do utilizador
         * @return bool - Retorna true se o utilizador existir, false caso contrário
         */
        public static bool VerificarUtilizador(string utilizador)
        {
            DatabaseHelper dbHelper = new DatabaseHelper();

            string insertQuery = "SELECT Utilizador FROM Utilizadores WHERE Utilizador=@nome";

            SqlParameter paramNome = new SqlParameter("@nome", SqlDbType.VarChar) { Value = utilizador };

            DataTable resultado = dbHelper.GetDataTable(insertQuery, paramNome);

            return resultado != null && resultado.Rows.Count > 0; // Garante que não existem rows na base de dados
        }

        /*
         * Função para registar um utilizador
         * @param utilizador - Nome do utilizador
         * @param password - Password do utilizador
         * @param cargo - Cargo do utilizador
         */
        public static void RegistarUtilizador(string utilizador, string password, string cargo)
        {
            DatabaseHelper dbHelper = new DatabaseHelper();

            string insertQuery = "INSERT INTO Utilizadores (Utilizador, Senha, Cargo, flag) VALUES (@nome, @password, @cargo, 0)";

            SqlParameter paramNome = new SqlParameter("@nome", SqlDbType.VarChar) { Value = utilizador };
            SqlParameter paramPassword = new SqlParameter("@password", SqlDbType.VarChar) { Value = password };
            SqlParameter paramCargo = new SqlParameter("@cargo", SqlDbType.Int) { Value = cargo };

            dbHelper.ExecuteQuery(insertQuery, paramNome, paramPassword, paramCargo);
        }

        /*
         * Função para eliminar um utilizador
         * @param utilizador - Nome do utilizador
         */
        public static void EliminarUtilizador(string utilizador)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();

                string deleteQuery = "DELETE FROM Utilizadores WHERE Utilizador=@nome";

                SqlParameter paramNome = new SqlParameter("@nome", SqlDbType.VarChar) { Value = utilizador };

                dbHelper.ExecuteQuery(deleteQuery, paramNome);

                MessageBox.Show($"O utilizador {utilizador} foi eliminado com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao listar utilizadores: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         * Função para obter os utilizadores
         * @param nome - ComboBox onde os utilizadores serão adicionados
         */
        public static void ObterUtilizadores(ComboBox nome)
        {
            // Limpa o ComboBox 
            nome.Items.Clear();

            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();

                string selectQuery = "SELECT * FROM Utilizadores";

                DataTable resultado = dbHelper.GetDataTable(selectQuery);

                // Verifica se o resultado for nulo ou vazio
                if (resultado == null)
                {
                    MessageBox.Show("Não existem utilizadores na base de dados. Por favor adicione um utilizador primeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Adicionar os nomes dos utilizadores ao ComboBox
                foreach (DataRow row in resultado.Rows)
                    nome.Items.Add(row["Utilizador"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar utilizadores: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /*
         * Função para obter as informações de um utilizador
         * @param utilizador - Nome do utilizador
         * @return DataTable - Retorna as informações do utilizador
         */
        public static DataTable ObterInformacaoUtilizador(string utilizador)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();

                string selectQuery = "SELECT * FROM Utilizadores WHERE Utilizador = @utilizador";

                SqlParameter paramUtilizador = new SqlParameter("@utilizador", SqlDbType.VarChar) { Value = utilizador };

                DataTable resultado = dbHelper.GetDataTable(selectQuery, paramUtilizador);

                // Retorna as informações do utilizador
                return resultado;
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar utilizadores: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        /*
         * Função para alterar o utilizador
         * @param id - ID do utilizador
         * @param utilizador - Nome do utilizador
         * @param cargo - Cargo do utilizador
         */
        public static void AlterarUtilizador (string id, string utilizador, string cargo)
        {
            DatabaseHelper dbHelper = new DatabaseHelper();

            string updateQuery = "UPDATE Utilizadores SET Utilizador = @utilizador, cargo = @cargo WHERE id = @id";

            SqlParameter paramUtilizador = new SqlParameter("@utilizador", SqlDbType.VarChar) { Value = utilizador };
            SqlParameter paramCargo = new SqlParameter("@cargo", SqlDbType.Int) { Value = cargo };
            SqlParameter paramId = new SqlParameter("@id", SqlDbType.Int) { Value = id };

            dbHelper.ExecuteQuery(updateQuery, paramUtilizador, paramCargo, paramId);

        }

        /*
         * Função para alterar a senha do utilizador
         * @param id - ID do utilizador
         */
        public static void AdicionarFlagSenha(string id)
        {
            DatabaseHelper dbHelper = new DatabaseHelper();

            string updateQuery = "UPDATE Utilizadores SET flag = 1 WHERE id = @id";

            SqlParameter paramId = new SqlParameter("@id", SqlDbType.Int) { Value = id };

            dbHelper.ExecuteQuery(updateQuery, paramId);
        }

        /*
         * Função para alterar a senha do utilizador
         * @param senha - Nova senha do utilizador
         */
        public static void AlterarSenha(string senha, string id)
        {
            try
            {
                // Inicializa a classe DatabaseHelper
                DatabaseHelper dbHelper = new DatabaseHelper();

                // Query para atualizar a senha do utilizador
                string updateQuery = "UPDATE Utilizadores SET Senha=@password, flag=0 WHERE ID=@id";

                // Parâmetros para a query
                SqlParameter paramPassword = new SqlParameter("@password", SqlDbType.VarChar) { Value = senha };
                SqlParameter paramId = new SqlParameter("@id", SqlDbType.Int) { Value = Convert.ToInt32(id) };

                // Executa a query
                dbHelper.ExecuteQuery(updateQuery, paramPassword, paramId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao alterar a senha - {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         * Função para realizar o login
         * 
         * @param username - Nome do utilizador
         * @param password - Password do utilizador
         */
        public static bool Login(string username, string password)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper(); // Inicializar a classe DatabaseHelper

                string selectQuery = "SELECT * FROM Utilizadores WHERE Utilizador = @Username AND Senha= @Password"; // Query para selecionar o utilizador

                // Parâmetros para a query
                SqlParameter param1 = new SqlParameter("@Username", SqlDbType.VarChar) { Value = username };
                SqlParameter param2 = new SqlParameter("@Password", SqlDbType.VarChar) { Value = password };

                DataTable result = dbHelper.GetDataTable(selectQuery, param1, param2); // Obter o resultado da query

                // Se o resultado tiver 1 linha, então o utilizador existe
                if (result.Rows.Count == 1)
                {
                    // Guardar o ID e o Nome do Utilizador
                    Globals.idUtilizador = result.Rows[0]["Id"].ToString();
                    Globals.nomeUtilizador = result.Rows[0]["Utilizador"].ToString();

                    int cargo = Convert.ToInt32(result.Rows[0]["Cargo"]);// Obtém o Cargo do Utilizador

                    int flag = Convert.ToInt32(result.Rows[0]["flag"]);// Obtém a flag do utilizador

                    // Verifica se o utilizador é Admin ou não
                    if (cargo == 1)
                        Globals.admin = true;

                    if (flag == 1)
                    {
                        FormLoginAlterarSenha FormLoginAlterarSenha = new FormLoginAlterarSenha();
                        FormLoginAlterarSenha.ShowDialog();
                        return true;
                    }
                    else
                    {
                        FormInicial FormInicial = new FormInicial(); // Inicializar novo form
                        FormInicial.Show(); // Mostra Novo Form
                        return true;
                    }
                }
                else
                {
                    MessageBox.Show("Credenciais inválidas!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex) // Apanhar exceções
            {
                MessageBox.Show("Erro ao tentar conectar a base de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            return false;
        }
    }
}
