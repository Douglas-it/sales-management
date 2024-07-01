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
    public partial class FormVendas : Form
    {
        public FormVendas()
        {
            InitializeComponent();

            // Define os nomes internos das colunas
            string[] nomeColunas = {
                "idVenda",
                "idProduto",
                "nomeProduto",
                "quantidade",
                "precoUnitarioProduto",
                "valorVenda",
                "dataVenda",
                "codigoVendedor",
                "nomeVendedor",
                "zona"
            };

            // Define os nomes visiveis das colunas
            string[] nomeColunasVisivel = {
                "Id da Venda",
                "Código Produto",
                "Nome Produto",
                "Quantidade",
                "Preço Unitário Produto",
                "Valor Venda",
                "Data Venda",
                "Código Vendedor",
                "Nome Vendedor",
                "Zona"
            };

            // Define se as colunas são editáveis
            bool[] colunasReadOnly = { true, true, true, true, true, true, true, true };

            // Configura se os botões de editar e eliminar estão visíveis
            bool btnEditar = true;
            bool btnEliminar = true;

            // Cria a tabela
            OperacoesGerais.ConfigurarDataGridView(ListaVendas, nomeColunas, nomeColunasVisivel, colunasReadOnly, btnEditar, btnEliminar);

            // Carregar Dados da base de dados
            LoadData();
        }

        // Botão para Voltar ao Form Inicial
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormInicial FormInicial = new FormInicial();
            FormInicial.Show();

            this.Hide();
        }

        private void FormVendas_Load(object sender, EventArgs e)
        {
        }

        // Botão de sair da aplicação
        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Tem a certeza que deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
                Application.Exit();
        }

        // Função que carrega os dados da base de dados
        private void LoadData()
        {
            try
            {
                // Inicializar a classe DatabaseHelper
                DatabaseHelper dbHelper = new DatabaseHelper();

                // Query para selecionar o utilizador
                string selectQuery = @"
                    SELECT 
                        v.Id AS IdVenda,
                        p.Codigo AS CodigoProduto, 
                        v.CodigoVendedor AS CodigoVendedor, 
                        z.Abreviatura AS Zona,
                        v.DataVenda AS DataVenda, 
                        v.Quantidade AS Quantidade, 
                        p.Nome AS NomeProduto, 
                        v.ValorVenda AS ValorVenda, 
                        p.Preco AS PrecoUnitarioProduto, 
                        vend.Nome AS NomeVendedor 
                    FROM Vendas v 
                    INNER JOIN Produtos p ON v.CodigoProduto = p.Codigo 
                    INNER JOIN Vendedores vend ON v.CodigoVendedor = vend.Codigo
                    INNER JOIN Zonas z ON v.Zona = z.Id";

                // Obter o resultado da query
                DataTable resultado = dbHelper.GetDataTable(selectQuery);

                // Se o resultado da não for nulo
                if (resultado != null)
                    preencherTabela(resultado);
            }
            catch (Exception ex) // Apanhar exceções
            {
                MessageBox.Show("Erro ao tentar conectar a base de dados: " + ex.Message);
            }
        }

        private void preencherTabela(DataTable resultado)
        {
            // Limpar a lista dos comerciais
            ListaVendas.Rows.Clear();

            // Loop pelo resultado da e agrupa em linhas para a tabela
            foreach (DataRow row in resultado.Rows)
            {
                // Adiciona os dados na lista
                ListaVendas.Rows.Add(
                    row["IdVenda"].ToString(),
                    row["CodigoProduto"].ToString(),
                    row["NomeProduto"].ToString(),
                    row["Quantidade"].ToString(),
                    row["PrecoUnitarioProduto"].ToString() + "€",
                    row["ValorVenda"].ToString() + "€",
                    row["DataVenda"].ToString(),
                    row["CodigoVendedor"].ToString(),
                    row["NomeVendedor"].ToString(),
                    row["Zona"].ToString()
                );
            }
        }

        private void ListaVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a célula clicada é um botão ou não
            if (e.RowIndex >= 0)
            {
                string opcao = ListaVendas.Columns[e.ColumnIndex].Name;
                string codigoProduto = ListaVendas.Rows[e.RowIndex].Cells["idProduto"].Value.ToString();
                string zonaVenda = ListaVendas.Rows[e.RowIndex].Cells["zona"].Value.ToString();
                string dataVenda = ListaVendas.Rows[e.RowIndex].Cells["dataVenda"].Value.ToString();
                string quantidadeVenda = ListaVendas.Rows[e.RowIndex].Cells["quantidade"].Value.ToString();
                string IdVenda = ListaVendas.Rows[e.RowIndex].Cells["IdVenda"].Value.ToString();
                string codigoVendedor = ListaVendas.Rows[e.RowIndex].Cells["codigoVendedor"].Value.ToString();

                if (opcao == "Editar")
                {
                    FormEditarVenda formEditarVenda = new FormEditarVenda(codigoProduto, zonaVenda, dataVenda, quantidadeVenda, IdVenda, codigoVendedor);
                    formEditarVenda.ShowDialog();
                    LoadData();
                }
                else if (opcao == "Eliminar")
                {
                    DialogResult resultado = MessageBox.Show("Tem a certeza que deseja eliminar a venda?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        Vendas.EliminarVenda(codigoProduto);
                        LoadData();
                    }
                }
            }
        }

        // Botão de adicionar uma nova venda
        private void btnVenda_Click(object sender, EventArgs e)
        {
            FormVenda formVenda = new FormVenda();
            formVenda.ShowDialog();

            LoadData();
        }

        // Botão de pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = inputPesquisa.Text;

            if (OperacoesGerais.LerStringValida(pesquisa))
            {
                try
                {
                    // Inicializar a classe DatabaseHelper
                    DatabaseHelper dbHelper = new DatabaseHelper();

                    // Query para ~pesquisar a venda
                    string selectQuery = @"
                        SELECT 
                            v.Id AS IdVenda,
                            p.Codigo AS CodigoProduto, 
                            v.CodigoVendedor AS CodigoVendedor, 
                            z.Abreviatura AS Zona,
                            v.DataVenda AS DataVenda, 
                            v.Quantidade AS Quantidade, 
                            p.Nome AS NomeProduto, 
                            v.ValorVenda AS ValorVenda, 
                            p.Preco AS PrecoUnitarioProduto, 
                            vend.Nome AS NomeVendedor 
                        FROM Vendas v 
                        INNER JOIN Produtos p ON v.CodigoProduto = p.Codigo 
                        INNER JOIN Vendedores vend ON v.CodigoVendedor = vend.Codigo
                        INNER JOIN Zonas z ON v.Zona = z.Id
                        WHERE 
                            p.Codigo = @pesquisa OR 
                            v.CodigoVendedor = @pesquisa OR 
                            z.Abreviatura = @pesquisa OR 
                            p.Nome = @pesquisa OR
                            vend.Nome = @pesquisa";

                    // Parâmetros para a query
                    SqlParameter param1 = new SqlParameter("@pesquisa", SqlDbType.VarChar) { Value = pesquisa };

                    // Obter o resultado da query
                    DataTable resultado = dbHelper.GetDataTable(selectQuery, param1);

                    // Se o resultado da tabela não for nulo
                    if (resultado != null)
                        preencherTabela(resultado);
                }
                catch (Exception ex) // Apanhar exceções
                {
                    MessageBox.Show("Erro ao tentar conectar a base de dados: " + ex.Message);
                }
            }
            else
                MessageBox.Show("Por favor insira um nome para pesquisar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Botão de limpar a pesquisa
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            inputPesquisa.Text = "";

            LoadData();
        }
    }
}