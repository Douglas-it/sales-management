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
            // Propriedades Dara GridView
            ListaProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Resize Autómatico das colunas
            ListaProdutos.AllowUserToAddRows = false; // Não Permitir add Linhas

            // Adicionar colunas (nomes internos visiveis)
            ListaProdutos.Columns.Add("Codigo", "Código");
            ListaProdutos.Columns.Add("Nome", "Nome");
            ListaProdutos.Columns.Add("Preco", "Preço");
            ListaProdutos.Columns.Add("codigocategoria", "Categoria");


            // Adição de botão de Editar
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn(); // Criação de uma nova coluna de botão
            btnEditar.Name = "Editar"; // Nome da coluna
            btnEditar.HeaderText = "Editar"; // Cabeçalho da coluna
            btnEditar.Text = "Editar"; // Texto do botão
            btnEditar.UseColumnTextForButtonValue = true; // Usar o texto da coluna para o botão
            ListaProdutos.Columns.Add(btnEditar); // Adicionar a coluna à tabela

            // Adição de botão de Eliminar
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.Name = "Eliminar";
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            ListaProdutos.Columns.Add(btnEliminar);

            // Desativar a edição do codigo do produto
            ListaProdutos.Columns["Codigo"].ReadOnly = true;


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

        private void ApagarProduto(string Codigo)
        {
            try
            {
                // inicializar a classe DatabaseHelper
                DatabaseHelper dbHelper = new DatabaseHelper();

                //  Querry para selecionar o Produto 
                string DeleteQuery = "DELETE FROM Produtos WHERE Codigo = @codigoProduto";

                // Parâmetros para a query
                SqlParameter paramProduto = new SqlParameter("@codigoProduto", SqlDbType.VarChar) { Value = Codigo };

                // Obter o resultado da query
                dbHelper.ExecuteQuery(DeleteQuery, paramProduto);

                MessageBox.Show("O Produto foi eliminado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Carrega os dados novamente para atualizar a lista
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar apagar o produto: " + ex.Message);
            }
        }

        private void EditarProduto(string Codigo, string Nome, decimal Preco, int codigocategoria)
        {
            try
            {
                // inicializar a classe DatabaseHelper
                DatabaseHelper dbHelper = new DatabaseHelper();

                // Query para atualizar o produto
                string updateQuery = "UPDATE Produtos SET Nome = @nomeProduto, Preco = @precoProduto, CodigoCategoria = @codigoCategoria WHERE Codigo = @codigoProduto";

                // Parâmetros para a query
                SqlParameter param1 = new SqlParameter("@nomeProduto", SqlDbType.VarChar)
                {
                    Value = Nome
                };

                SqlParameter param2 = new SqlParameter("@precoProduto", SqlDbType.Decimal)
                {
                    Value = Preco
                };

                SqlParameter param3 = new SqlParameter("@codigoCategoria", SqlDbType.Int)
                {
                    Value = codigocategoria
                };

                SqlParameter param4 = new SqlParameter("@codigoProduto", SqlDbType.VarChar)
                {
                    Value = Codigo
                };

                // Funcionamento  da query
                dbHelper.ExecuteQuery(updateQuery, param1, param2, param3, param4);

                MessageBox.Show("o produto foi atualizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // carregar os dados para atualizar a lista 
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar atualizar o produto:" + ex.Message);
            }

        }

        private void DeleteItem(int rowIndex)
        {
            string Codigo = ListaProdutos.Rows[rowIndex].Cells["Codigo"].Value.ToString();
            DialogResult = MessageBox.Show($"Tem a certeza que deseja eliminar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (DialogResult == DialogResult.Yes)
            {
                ApagarProduto("Codigo");
            }
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {

        }

        private void inputPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            FormInicial FormInicial = new FormInicial();
            FormInicial.Show();

            this.Hide();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
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
            // Inserir Lógica de Pesquisar Produtos @Douglas
        }
    }
}
