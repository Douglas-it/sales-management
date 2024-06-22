﻿using System;
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
        }

        private void btnEliminarConta_Click(object sender, EventArgs e)
        {
            HideTabs();
            ShowTab(tabEliminarConta);
            DataTable utilizadores = Users.ObterUtilizadores();
            
            foreach (DataRow row in utilizadores.Rows)
            {
                selectUsername.Items.Add(row["Utilizador"]);
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
    }
}