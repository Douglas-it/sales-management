using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            bool[] colunasReadOnly = { true, true, true, true, true, true, true };

            // Configura se os botões de editar e eliminar estão visíveis
            bool btnEditar = true;
            bool btnEliminar = true;

            // Cria a tabela
            OperacoesGerais.ConfigurarDataGridView(ListaVendas, nomeColunas, nomeColunasVisivel, colunasReadOnly, btnEditar, btnEliminar);

            // Carregar Dados da base de dados
            LoadData();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormInicial FormInicial = new FormInicial();
            FormInicial.Show();

            this.Hide();
        }

        private void FormVendas_Load(object sender, EventArgs e)
        {
        }

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
                    SELECT p.Codigo AS CodigoProduto, v.CodigoVendedor AS CodigoVendedor, v.Zona AS Zona, 
                    v.DataVenda AS DataVenda, v.Quantidade AS Quantidade, p.Nome AS NomeProduto, v.ValorVenda AS ValorVenda, 
                    p.Preco AS PrecoUnitarioProduto, vend.Nome AS NomeVendedor 
                    FROM Vendas v 
                    INNER JOIN Produtos p ON v.CodigoProduto = p.Codigo 
                    INNER JOIN Vendedores vend ON v.CodigoVendedor = vend.Codigo;";

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

                if (opcao == "Editar")
                {
                    MessageBox.Show("Editar");
                }
                else if (opcao == "Eliminar")
                {
                    Vendas.EliminarVenda(codigoProduto);
                }
            }
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            FormVenda frm = new FormVenda();
            frm.Show();
        }
    }
}
