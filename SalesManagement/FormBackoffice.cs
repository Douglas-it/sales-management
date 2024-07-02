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

            // Limpa a lista de categorias
            comboCategoriasProduto.Items.Clear();

            // Lista as categorias existentes
            foreach (DataRow row in Produtos.ObterCategorias().Rows)
            {
                comboCategoriasProduto.Items.Add(row["nome"].ToString());
            }
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
            Estatisticas.PreencherGrafico(VendasPorCategoria, Estatisticas.VendasPorCategoriaProduto(), "Categoria", "TotalVendas");
            Estatisticas.PreencherGrafico(VendasPor7Dias, Estatisticas.VendasPorDia(), "DataVenda", "TotalVendas");

            // Tabela de Vendas por Mês e Vendedor
            // Define os nomes internos das colunas
            string[] nomeColunas = { "mes", "vendedor", "totalVendas" };

            // Define os nomes visiveis das colunas
            string[] nomeColunasVisivel = { "Mês", "Vendedor", "Valor de Vendas" };

            // Define se as colunas são editáveis
            bool[] colunasReadOnly = { true, true, true };

            // Configura se os botões de editar e eliminar estão visíveis
            bool botaoEditar = false;
            bool botaoEliminar = false;

            // Cria a tabela
            OperacoesGerais.ConfigurarDataGridView(dataGridViewMesVendedor, nomeColunas, nomeColunasVisivel, colunasReadOnly, botaoEditar, botaoEliminar);

            // Carregar Dados da base de dados
            DataTable resultado = Estatisticas.VendasPorMesVendedor();
            preencherTabelaMesVendedor(resultado);

            // Tabela de Vendas por Mês e Produto
            // Define os nomes internos das colunas
            string[] nomeColunas2 = { "mes", "produto", "totalVendas" };
            string[] nomeColunasVisivel2 = { "Mês", "Produto", "Valor de Vendas" };

            // Cria a tabela
            OperacoesGerais.ConfigurarDataGridView(dataGridViewMesProduto, nomeColunas2, nomeColunasVisivel2, colunasReadOnly, botaoEditar, botaoEliminar);
            DataTable resultado2 = Estatisticas.VendasPorMesProduto();
            preencherTabelaMesProduto(resultado2);
        }

        private void preencherTabelaMesVendedor(DataTable resultado)
        {
            // Loop pelo resultado da e agrupa em linhas para a tabela
            foreach (DataRow row in resultado.Rows)
            {
                // Adiciona os dados na lista
                dataGridViewMesVendedor.Rows.Add(
                    row["Mes"].ToString(),
                    row["Vendedor"].ToString(),
                    row["TotalVendas"].ToString() + "€"
                    );
            }
        }

        private void preencherTabelaMesProduto(DataTable resultado)
        {
            // Loop pelo resultado da e agrupa em linhas para a tabela
            foreach (DataRow row in resultado.Rows)
            {
                // Adiciona os dados na lista
                dataGridViewMesProduto.Rows.Add(
                    row["Mes"].ToString(),
                    row["Produto"].ToString(),
                    row["TotalVendas"].ToString() + "€"
                    );
            }
        }

        private void btnEstatisticas2_Click(object sender, EventArgs e)
        {
            HideTabs();
            ShowTab(tabEstatisticas2);
        }

        private void btnEstatisticas1_Click(object sender, EventArgs e)
        {
            HideTabs();
            ShowTab(tabEstatisticas);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            HideTabs();
            ShowTab(tabAdicionarCategorias);

            // Limpa as categorias do combobox
            cmbCategorias.Items.Clear();

            // Adiciona as categorias existentes no combobox
            foreach (DataRow row in Produtos.ObterCategorias().Rows)
                cmbCategorias.Items.Add(row["nome"].ToString());
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarCategoria_Click(object sender, EventArgs e)
        {
            string nomeCategoria = txtNomeCategoria.Text;

            // Verifica se o nome da categoria é válido
            if (!OperacoesGerais.LerStringValida(nomeCategoria))
            {
                MessageBox.Show("Por favor, preencha o nome da categoria.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Filtro para verificar se a categoria já existe
            string filtro = "WHERE nome = '" + nomeCategoria + "'";

            // Loop na lista de categorias
            foreach (DataRow row in Produtos.ObterCategorias(filtro).Rows)
            {
                // se a categoria já existe
                if (row["nome"] == nomeCategoria)
                {
                    MessageBox.Show("Já existe uma categoria com esse nome.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            try
            {
                // Cria a categoria
                Produtos.CriarCategoria(nomeCategoria);
                MessageBox.Show("Categoria criada com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpa as categorias existentes no Combobox
                cmbCategorias.Items.Clear();

                // Atualiza a combobox de categorias
                foreach (DataRow row in Produtos.ObterCategorias().Rows)
                    cmbCategorias.Items.Add(row["nome"].ToString());

                txtNomeCategoria.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar a categoria: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtNomeCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluirCategoria_Click(object sender, EventArgs e)
        {
            string nomeCategoria = cmbCategorias.Text;

            if (!OperacoesGerais.LerStringValida(nomeCategoria))
            {
                MessageBox.Show("Por favor, selecione uma categoria.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Produtos.EliminarCategoria(nomeCategoria);

                // Limpa as categorias existentes no Combobox
                cmbCategorias.Items.Clear();

                // Atualiza a combobox de categorias
                foreach (DataRow row in Produtos.ObterCategorias().Rows)
                    cmbCategorias.Items.Add(row["nome"].ToString());

                cmbCategorias.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao eliminar a categoria: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            if (!OperacoesGerais.LerStringValida(cmbCategorias.Text))
            {
                MessageBox.Show("Por favor, selecione uma categoria.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            labelEscolhaCategoria.Visible = true;
            labelAtencao.Visible = true;
            txtMessage.Visible = true;
            btnGuardarAltCat.Visible = true;
            txtEditarCategoria.Visible = true;
        }

        private void btnGuardarAltCat_Click(object sender, EventArgs e)
        {
            string novoNomeCategoria = txtEditarCategoria.Text;
            int idCategoria = Convert.ToInt32(Produtos.ObterIdCategoria(cmbCategorias.Text));

            if (!OperacoesGerais.LerStringValida(novoNomeCategoria))
            {
                MessageBox.Show("Por favor, preencha o nome da categoria.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Produtos.EditarCategoria(novoNomeCategoria, idCategoria);

                // Limpa as categorias existentes no Combobox
                cmbCategorias.Items.Clear();

                // Atualiza a combobox de categorias
                foreach (DataRow row in Produtos.ObterCategorias().Rows)
                    cmbCategorias.Items.Add(row["nome"].ToString());

                cmbCategorias.Text = "";
                txtEditarCategoria.Text = "";
                txtEditarCategoria.Visible = false;
                btnGuardarAltCat.Visible = false;
                labelEscolhaCategoria.Visible = false;
                labelAtencao.Visible = false;
                txtMessage.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar a categoria: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}