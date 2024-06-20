using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class Backoffice : Form
    {
        // Função que recebe um argumento para esconder todas as tabs ou uma tab especifica
        private void HideTabs(TabPage tabPage = null)
        {
            foreach (TabPage tab in tabControl.TabPages)
                tabControl.TabPages.Remove(tab);
        }

        private void ShowTab(TabPage tabPage)
        {
            if (!tabControl.TabPages.Contains(tabPage))
                tabControl.TabPages.Add(tabPage);
        }

        private void ListarCargos(ComboBox cargos)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();

                string selectQuery = "SELECT * FROM UtilizadoresCargos";

                // obter o resultado da query
                DataTable resultado = dbHelper.GetDataTable(selectQuery);

                // Garante que não existe cargos a serem mostrados
                cargos.Items.Clear();

                // Se o resultado da não for nulo
                if (resultado != null)
                    foreach (DataRow row in resultado.Rows)
                        cargos.Items.Add(row["CargoNome"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar cargos: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ObterCargoId(string nome)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();

                string selectQuery = "SELECT CargoId FROM UtilizadoresCargos WHERE CargoNome = @nome";

                SqlParameter paramProduto = new SqlParameter("@nome", SqlDbType.VarChar) { Value = nome };

                // obter o resultado da query
                DataTable resultado = dbHelper.GetDataTable(selectQuery);

                // Garante que não existe cargos a serem mostrados
                cargos.Items.Clear();

                // Se o resultado da não for nulo
                if (resultado != null)
                    return resultado.Rows[0]["CargoId"].ToString();
                else
                    return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar cargos: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public Backoffice()
        {
            InitializeComponent();
            HideTabs();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormInicial formInicial = new FormInicial();
            formInicial.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Globals.admin = false;

            this.Hide();

            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HideTabs();
            ShowTab(tabCriarConta);
            ListarCargos(cargos);
        }

        private void tabAlterarConta_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterarConta_Click(object sender, EventArgs e)
        {
            HideTabs();
            ShowTab(tabAlterarConta);
        }

        private void btnEliminarConta_Click(object sender, EventArgs e)
        {
            HideTabs();
            ShowTab(tabEliminarConta);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabCriarConta_Click(object sender, EventArgs e)
        {

        }

        private void btnNovoUtilizador_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(txtUtilizador.Text) || 
                string.IsNullOrEmpty(txtPassword.Text) || 
                string.IsNullOrEmpty(txtRepeatPassword.Text) || 
                string.IsNullOrEmpty(cargos.Text)
                )
            {
                MessageBox.Show("Preencha todos os campos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtPassword.Text != txtRepeatPassword.Text)
            {
                MessageBox.Show("As palavras-passe não coincidem!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"{ObterCargoId(cargos.Text)}");
            /*
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();

                string insertQuery = "INSERT INTO Utilizadores (Utilizador, Senha, Cargo) VALUES (@nome, @password, @cargo)";

                SqlParameter paramNome = new SqlParameter("@nome", SqlDbType.VarChar) { Value = txtUtilizador.Text };
                SqlParameter paramPassword = new SqlParameter("@password", SqlDbType.VarChar) { Value = txtPassword.Text };
                SqlParameter paramCargo = new SqlParameter("@cargo", SqlDbType.Int) { Value = ObterCargoId(cargos.Text) };

                dbHelper.ExecuteQuery(insertQuery, paramNome, paramPassword, paramCargo);

                MessageBox.Show("Utilizador criado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar utilizador: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } */
        }
    }
}
