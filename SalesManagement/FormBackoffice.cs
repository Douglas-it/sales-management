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
using System.Windows.Forms.DataVisualization.Charting;

namespace SalesManagement
{
    public partial class FormBackoffice : Form
    {
        /*
         *  Esconde todas as tabs ou uma tab especifica
         *  @param TabPage tabPage
         */
        private void HideTabs(TabPage tabPage = null)
        {
            foreach (TabPage tab in tabControl.TabPages)
                tabControl.TabPages.Remove(tab);
        }

        /*
         *  Mostra uma tab especifica
         *  @param TabPage tabPage
         */
        private void ShowTab(TabPage tabPage)
        {
            if (!tabControl.TabPages.Contains(tabPage))
                tabControl.TabPages.Add(tabPage);
        }

        public FormBackoffice()
        {
            InitializeComponent();
            HideTabs();
        }

        // Botão de sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide(); // Esconde o form atual

            // Mostra o form inicial
            FormInicial formInicial = new FormInicial();
            formInicial.Show();
        }

        // Botão de Logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Limpa as variáveis globais
            Globals.admin = false;
            Globals.idUtilizador = null;
            Globals.nomeUtilizador = null;

            this.Hide(); // Esconde o form atual

            // Mostra o form de login
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        // Botão de mostrar a tab de criar conta
        private void button1_Click(object sender, EventArgs e)
        {
            HideTabs(); // Esconde todas as tabs
            ShowTab(tabCriarConta); // Mostra a tab de criar conta
            Cargos.ListarCargos(cargos); // Lista os cargos
        }

        // Botão de criar um novo utilizador
        private void btnNovoUtilizador_Click(object sender, EventArgs e)
        {
            string utilizador = txtUtilizador.Text;
            string password = txtPassword.Text;
            string repeatPassword = txtRepeatPassword.Text;
            string cargo = cargos.Text;

            // Verifica se os campos estão preenchidos corretamente
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

            // Verifica se as palavras-passe coincidem
            if (password != repeatPassword)
            {
                MessageBox.Show("As palavras-passe não coincidem!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica se o utilizador já existe
            if (Utilizadores.VerificarUtilizador(utilizador))
            {
                MessageBox.Show("O nome de utilizador escolhido já existe!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUtilizador.Text = "";
                return;
            }

            // Obtem o id do cargo através do nome
            string cargoId = Cargos.ObterCargoId(cargo);

            // Regista o utilizador
            Utilizadores.RegistarUtilizador(utilizador, password, cargoId);

            // Marcar a flag para alterar a senha
            if (checkSim.Checked)
                Utilizadores.AdicionarFlagSenha(utilizador);

            MessageBox.Show("Utilizador criado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Botão de mostrar a tab de alterar conta
        private void btnAlterarConta_Click(object sender, EventArgs e)
        {
            HideTabs(); // Esconde todas as tabs
            ShowTab(tabAlterarConta); // Mostra a tab de alterar conta
            Utilizadores.ObterUtilizadores(selecionarUtilizador); // Lista os utilizadores
        }

        // Botão de modificar os dados de um utilizador
        private void btnModificarConta_Click(object sender, EventArgs e)
        {
            string userId = txtUserId.Text;
            string utilizador = txtNomeUser.Text;
            string cargo = Cargos.ObterCargoId(comboCargos.Text);

            // Verifica se os campos estão preenchidos corretamente
            if (!OperacoesGerais.LerStringValida(utilizador))
            {
                MessageBox.Show("Preencha todos os campos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica se o utilizador deve alterar a senha
            if (checkYes.Checked)
                Utilizadores.AdicionarFlagSenha(userId);

            // Altera os dados do utilizador
            Utilizadores.AlterarUtilizador(userId, utilizador, cargo);

            // Esconde os campos para alterar os dados
            txtNomeUser.Visible = false;
            labelUser.Visible = false;
            comboCargos.Visible = false;
            labelCargo.Visible = false;
            labelSenha.Visible = false;
            checkYes.Visible = false;
            btnModificarConta.Visible = false;

            // Lista os utilizadores
            Utilizadores.ObterUtilizadores(selecionarUtilizador);

            MessageBox.Show("Os dados foram atualizados com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Botão de mostrar a tab de eliminar conta
        private void btnEliminarConta_Click(object sender, EventArgs e)
        {
            HideTabs(); // Esconde todas as tabs
            ShowTab(tabEliminarConta); // Mostra a tab de eliminar conta
            Utilizadores.ObterUtilizadores(selectUsername); // Lista os utilizadores
        }

        // Botão de eliminar um utilizador
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string utilizador = selectUsername.Text;

            // Verifica se o utilizador é válido
            if (!OperacoesGerais.LerStringValida(utilizador))
            {
                MessageBox.Show("O utilizador não é válido");
                return;
            }

            // Verifica se o utilizador a eliminar é o mesmo que esta com a sessão iniciada.
            if (utilizador == Globals.nomeUtilizador)
            {
                MessageBox.Show("Não é possível eliminar o utilizador que esta a utilizar.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Elimina o utilizador
            Utilizadores.EliminarUtilizador(utilizador);

            // Atualiza a lista de utilizadores
            Utilizadores.ObterUtilizadores(selectUsername);
        }

        // Botão de obter os dados de um utilizador
        private void btnObterDados_Click(object sender, EventArgs e)
        {
            string utilizador = selecionarUtilizador.Text;

            // Verifica se o utilizador é válido
            if (utilizador == null || utilizador.ToString() == "")
            {
                MessageBox.Show("Selecione um utilizador.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mostra os campos para alterar os dados
            txtNomeUser.Visible = true;
            labelUser.Visible = true;
            comboCargos.Visible = true;
            labelCargo.Visible = true;
            labelSenha.Visible = true;
            checkYes.Visible = true;
            btnModificarConta.Visible = true;

            // Retorna as informações do utilizador
            foreach (DataRow row in Utilizadores.ObterInformacaoUtilizador(utilizador).Rows)
            {
                txtNomeUser.Text = row["Utilizador"].ToString();

                // Lista os cargos
                Cargos.ListarCargos(comboCargos);

                // Obtem o nome do cargo com base no ID
                string cargoNome = Cargos.ObterCargoNome(row["Cargo"].ToString());

                comboCargos.Text = cargoNome;

                txtUserId.Text = row["id"].ToString();
            }
        }

        private void btnAdicionarVendedor_Click(object sender, EventArgs e)
        {
            HideTabs(); // Esconde todas as tabs
            ShowTab(tabAdicionarVendedor); // Mostra a tab de adicionar vendedor
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Definição de Variáveis
            string codigo = inputCodigo.Text;
            string nome = inputNome.Text;
            string comissao = inputComissao.Text;

            if (
                !OperacoesGerais.LerStringValida(codigo) ||
                !OperacoesGerais.LerStringValida(nome) ||
                !OperacoesGerais.LerDecimalValido(comissao, 0, 100)
                )
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                inputCodigo.Text = "";
                inputNome.Text = "";
                inputComissao.Text = "";

                return;
            }

            Vendedores.InserirComercial(codigo, nome, comissao);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            HideTabs();
            ShowTab(tabAdicionarProduto);

            Produtos.ObterCategorias(comboCategoriasProduto);
        }

        private void btnAdicionarArtigo_Click(object sender, EventArgs e)
        {
            string nome = txtNomeProduto.Text;
            string codigo = txtCodigoProduto.Text;
            string preco = txtPrecoProduto.Text;
            string categoria = comboCategoriasProduto.Text;

            if (
                !OperacoesGerais.LerStringValida(nome) ||
                !OperacoesGerais.LerStringValida(codigo) ||
                !OperacoesGerais.LerDecimalValido(preco, 0)
                )
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Produtos.VerificarIdProduto(codigo))
            {
                MessageBox.Show("Já existe um produto com esse código!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BackOffice.InserirProduto(nome, codigo, preco, categoria);

            txtCodigoProduto.Text = "";
            txtNomeProduto.Text = "";
            txtPrecoProduto.Text = "";
        }



        private void button2_Click(object sender, EventArgs e)
        {
            HideTabs();
            ShowTab(tabEstatisticas);

            // Preenche os gráficos com informação
            Estatisticas.PreencherGrafico(VendasPorVendedor, Estatisticas.VendasPorVendedor(), "Vendedor", "TotalVendas");
            Estatisticas.PreencherGrafico(VendasPorProduto, Estatisticas.VendasPorProduto(), "Produto", "TotalVendas");
            Estatisticas.PreencherGrafico(VendasPorZona, Estatisticas.VendasPorZona(), "Zona", "TotalVendas");
            Estatisticas.PreencherGrafico(VendasPorMes, Estatisticas.VendasPorMes(), "Mes", "TotalVendas");
            Estatisticas.PreencherGrafico(VendasPorMesVendedor, Estatisticas.VendasPorMesVendedor(), "Vendedor", "TotalVendas");
            Estatisticas.PreencherGrafico(vendasPorMesProduto, Estatisticas.VendasPorMesProduto(), "Produto", "TotalVendas");
        }
    }
}