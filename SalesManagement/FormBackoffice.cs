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

            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar utilizador: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botão de mostrar a tab de alterar conta
        private void btnAlterarConta_Click(object sender, EventArgs e)
        {
            HideTabs(); // Esconde todas as tabs

            ShowTab(tabAlterarConta); // Mostra a tab de alterar conta

            try
            {
                // Lista os utilizadores
                Utilizadores.ObterUtilizadores(selecionarUtilizador);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar utilizadores: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o utilizador: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botão de mostrar a tab de eliminar conta
        private void btnEliminarConta_Click(object sender, EventArgs e)
        {
            HideTabs(); // Esconde todas as tabs

            ShowTab(tabEliminarConta); // Mostra a tab de eliminar conta

            try
            {
                // Lista os utilizadores
                Utilizadores.ObterUtilizadores(selectUsername);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar utilizadores: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
                !OperacoesGerais.LerStringValida(nome) || !OperacoesGerais.LerDecimalValido(comissao, 0, 100)
                )
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                inputCodigo.Text = "";
                inputNome.Text = "";
                inputComissao.Text = "";

                return;
            }

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
                if (result.Rows.Count == 0)
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
                !OperacoesGerais.LerDecimalValido(preco, 0, 1000)
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

            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();

                string insertQuery = "INSERT INTO Produtos (Codigo, Nome, CodigoCategoria, Preco) VALUES (@codigo, @nome, @CodigoCategoria, @preco)";

                SqlParameter paramNome = new SqlParameter("@nome", SqlDbType.VarChar) { Value = nome };
                SqlParameter paramCodigo = new SqlParameter("@codigo", SqlDbType.VarChar) { Value = codigo };
                SqlParameter paramPreco = new SqlParameter("@preco", SqlDbType.Float) { Value = preco };
                SqlParameter paramCategoria = new SqlParameter("@CodigoCategoria", SqlDbType.VarChar) { Value = Produtos.ObterIdCategoria(categoria) };

                dbHelper.ExecuteQuery(insertQuery, paramNome, paramCodigo, paramPreco, paramCategoria);

                MessageBox.Show("Produto adicionado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNomeProduto.Text = "";
                txtCodigoProduto.Text = "";
                txtPrecoProduto.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar adicionar o produto: " + ex.Message);
            }
        }


        private void tabAlterarConta_Click(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void tabCriarConta_Click(object sender, EventArgs e) { }

        private void selectUsername_SelectedIndexChanged(object sender, EventArgs e) { }

        private void tabCriarConta_Click_1(object sender, EventArgs e) { }
    }
}
