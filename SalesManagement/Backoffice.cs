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

                // Se o resultado da não for nulo ou igual a zero
                if (resultado != null || resultado.Rows.Count == 0)
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
                DataTable resultado = dbHelper.GetDataTable(selectQuery, paramProduto);

                // Se o resultado da não for nulo
                if (resultado != null)
                    return resultado.Rows[0]["CargoId"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar cargos: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        private string ObterCargoNome(string id)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();

                string selectQuery = "SELECT CargoNome FROM UtilizadoresCargos WHERE CargoId = @id";

                SqlParameter paramProduto = new SqlParameter("@id", SqlDbType.VarChar) { Value = id };

                // obter o resultado da query
                DataTable resultado = dbHelper.GetDataTable(selectQuery, paramProduto);

                // Se o resultado da não for nulo
                if (resultado != null)
                    return resultado.Rows[0]["CargoNome"].ToString();
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

        private void btnAlterarConta_Click(object sender, EventArgs e)
        {
            HideTabs();
            ShowTab(tabAlterarConta);
            try
            {
                Users.ObterUtilizadores(selecionarUtilizador);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar utilizadores: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarConta_Click(object sender, EventArgs e)
        {
            HideTabs();
            ShowTab(tabEliminarConta);
            try
            {
                Users.ObterUtilizadores(selectUsername);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar utilizadores: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnNovoUtilizador_Click(object sender, EventArgs e)
        {
            string utilizador = txtUtilizador.Text;
            string password = txtPassword.Text;
            string repeatPassword = txtRepeatPassword.Text;
            string cargo = cargos.Text;

            if (
                !OperacoesGerais.LerStringValida(utilizador) ||
                !OperacoesGerais.LerStringValida(password) ||
                !OperacoesGerais.LerStringValida(repeatPassword) ||
                !OperacoesGerais.LerStringValida(cargo)
                )
            {
                MessageBox.Show("Preencha todos os campos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != repeatPassword)
            {
                MessageBox.Show("As palavras-passe não coincidem!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (Users.VerificarUtilizador(utilizador))
                {
                    MessageBox.Show("O nome de utilizador escolhido já existe!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUtilizador.Text = "";
                    return;
                }

                string cargoId = ObterCargoId(cargo);

                Users.RegistarUtilizador(utilizador, password, cargoId);
                MessageBox.Show("Utilizador criado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar utilizador: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabAlterarConta_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabCriarConta_Click(object sender, EventArgs e)
        {

        }

        private void selectUsername_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string utilizador = selectUsername.Text;

            if (!OperacoesGerais.LerStringValida(utilizador))
            {
                MessageBox.Show("O utilizador não é válido");
                return;
            }

            try
            {
                Users.EliminarUtilizador(utilizador);

                MessageBox.Show($"O utilizador {utilizador} foi eliminado com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Users.ObterUtilizadores(selectUsername);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar utilizadores: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabCriarConta_Click_1(object sender, EventArgs e)
        {

        }

        private void btnObterDados_Click(object sender, EventArgs e)
        {
            string utilizador = selecionarUtilizador.Text;

            if (utilizador == null || utilizador.ToString() == "")
            {
                MessageBox.Show("Selecione um utilizador.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtNomeUser.Visible = true;
            labelUser.Visible = true;
            comboCargos.Visible = true;
            labelCargo.Visible = true;
            labelSenha.Visible = true;
            checkYes.Visible = true;
            btnModificarConta.Visible = true;

            try
            {
                // Retorna as informações do utilizador
                foreach (DataRow row in Users.ObterInformacaoUtilizador(utilizador).Rows)
                {
                    txtNomeUser.Text = row["Utilizador"].ToString();

                    ListarCargos(comboCargos);

                    string cargoNome = ObterCargoNome(row["Cargo"].ToString());

                    comboCargos.Text = cargoNome;

                    txtUserId.Text = row["id"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar a informação: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarConta_Click(object sender, EventArgs e)
        {
            string userId = txtUserId.Text;
            string utilizador = txtNomeUser.Text;
            string cargo = ObterCargoId(comboCargos.Text);

            if (!OperacoesGerais.LerStringValida(utilizador))
            {
                MessageBox.Show("Preencha todos os campos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (checkYes.Checked)
                    Users.AlterarSenha(userId);

                Users.AlterarUtilizador(userId, utilizador, cargo);
                MessageBox.Show("Os dados foram atualizados com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o utilizador: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
