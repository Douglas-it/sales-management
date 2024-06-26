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
    public partial class FormProdutos : System.Windows.Forms.Form
    {
        public FormProdutos()
        {
            InitializeComponent();

            // Define os nomes internos das colunas
            string[] nomeColunas = { 
                "Codigo",
                "Nome",
                "Preco",
                "codigocategoria"
            };

            // Define os nomes visiveis das colunas
            string[] nomeColunasVisivel =
            {
                "Código",
                "Nome",
                "Preço",
                "Categoria"
            };

            // Define se as colunas são editáveis
            bool[] colunasReadOnly = { true, true, true, true };

            // Configura se os botões de editar e eliminar estão visíveis
            bool btnEditar = true;
            bool btnEliminar = true;

            // Cria a tabela
            OperacoesGerais.ConfigurarDataGridView(ListaProdutos, nomeColunas, nomeColunasVisivel, colunasReadOnly, btnEditar, btnEliminar);

            // Carregar Dados da base de dados
            LoadData();
        }

        // Função que carrega os dados da base de dados 
        private void LoadData()
        {
            try
            {
                // inicializar a classe DatabaseHelper
                DatabaseHelper dbHelper = new DatabaseHelper();

                // Querry para selecionar o Produto
                string selectQuery = "SELECT Produtos.Codigo, Produtos.Nome, Produtos.Preco, Categorias.Nome AS NomeCategoria FROM Produtos INNER JOIN Categorias ON Produtos.CodigoCategoria = Categorias.Codigo";

                // obter o resultado da query
                DataTable resultado = dbHelper.GetDataTable(selectQuery);

                // Se o resultado da não for nulo
                if (resultado != null)
                    preencherTabela(resultado);

            }
            catch (Exception ex) // apanhar exceções
            {
                MessageBox.Show("Erro ao tentar conectar a base de dados: " + ex.Message);
            }
        }

        private void preencherTabela(DataTable resultado)
        {
            // limpar a lista dos Produtos 
            ListaProdutos.Rows.Clear();

            // Loop pelo resultado da e agrupa em linhas para a tabela 
            foreach (DataRow row in resultado.Rows)
            {
                // Adiciona os dados a lista 
                ListaProdutos.Rows.Add(
                    row["Codigo"].ToString(),
                    row["Nome"].ToString(),
                    Convert.ToDecimal(row["Preco"]) + "€",
                    row["NomeCategoria"].ToString()
                    );
            }
        }

        private void ListaProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a célula clicada é um botão ou não
            if (e.RowIndex >= 0)
            {
                string opcao = ListaProdutos.Columns[e.ColumnIndex].Name;

                if (opcao == "Editar")
                    BotaoEditarProduto(e.RowIndex); // Controla o botão de Editar
                else if (opcao == "Eliminar")
                    BotaoApagarProduto(e.RowIndex); // Controla o botão de Eliminar
            }
        }

        private void BotaoApagarProduto(int rowIndex)
        {
            string codigo = ListaProdutos.Rows[rowIndex].Cells["Codigo"].Value.ToString();

            if (!Produtos.VerificarProduto(codigo))
            {
                MessageBox.Show("Não é possível eliminar o produto, pois o mesmo já foi vendido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = MessageBox.Show($"Tem a certeza que deseja eliminar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (DialogResult == DialogResult.Yes)
            {
                try
                {
                    DatabaseHelper dbHelper = new DatabaseHelper(); // inicializar a classe DatabaseHelper

                    string DeleteQuery = "DELETE FROM Produtos WHERE Codigo = @codigoProduto"; // Query para eliminar o Produto

                    SqlParameter paramProduto = new SqlParameter("@codigoProduto", SqlDbType.VarChar) { Value = codigo }; // Paramêtros para a query

                    dbHelper.ExecuteQuery(DeleteQuery, paramProduto); // Executa a query

                    MessageBox.Show("O Produto foi eliminado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);  
                    
                    //Carrega os dados novamente para atualizar a lista
                    LoadData();
                } 
                catch (Exception ex)
                {                     
                    MessageBox.Show("Erro ao tentar apagar o produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BotaoEditarProduto(int rowIndex)
        {
            string codigo = ListaProdutos.Rows[rowIndex].Cells["Codigo"].Value.ToString();
            string nome = ListaProdutos.Rows[rowIndex].Cells["Nome"].Value.ToString();
            string preco = ListaProdutos.Rows[rowIndex].Cells["Preco"].Value.ToString().Replace("€", "");
            string categoria = ListaProdutos.Rows[rowIndex].Cells["codigocategoria"].Value.ToString();

            FormEditarProduto FormEditarProduto = new FormEditarProduto(codigo, nome, preco, categoria);
            FormEditarProduto.ShowDialog();

            LoadData();
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {

        }

        private void inputPesquisa_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormInicial FormInicial = new FormInicial();
            FormInicial.Show();

            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Tem a certeza que deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
                Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            inputPesquisa.Text = "";
            ListaProdutos.Rows.Clear();

            LoadData();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = inputPesquisa.Text;
            if (OperacoesGerais.LerStringValida(pesquisa))
            {
                try
                {
                    // inicializar a classe DatabaseHelper
                    DatabaseHelper dbHelper = new DatabaseHelper();

                    // Query para selecionar o Produto
                    string selectQuery = "SELECT Produtos.Codigo, Produtos.Nome, Produtos.Preco, Categorias.Nome AS NomeCategoria FROM Produtos INNER JOIN Categorias ON Produtos.CodigoCategoria = Categorias.Codigo WHERE Produtos.Nome LIKE @pesquisa OR Categorias.Nome LIKE @pesquisa";

                    // Parâmetros para a query
                    SqlParameter paramPesquisa = new SqlParameter("@pesquisa", SqlDbType.VarChar) { Value = "%" + pesquisa + "%" };

                    // Obter o resultado da query
                    DataTable resultado = dbHelper.GetDataTable(selectQuery, paramPesquisa);

                    // Se o resultado da não for nulo
                    if (resultado != null)
                        preencherTabela(resultado);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao tentar conectar a base de dados: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor insira um valor válido para a pesquisa!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
