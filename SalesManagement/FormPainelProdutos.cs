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
    public partial class FormProdutos : System.Windows.Forms.Form
    {
        public FormProdutos()
        {
            InitializeComponent();
           // Propriedades Dara GridView
           ListaProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Resize Autómatico das colunas
           ListaProdutos.AllowUserToAddRows = false; // Não Permitir add Linhas

            // Adicionar colunas (nomes internos visiveis)
            ListaProdutos.Columns.Add("Codigo", "Código Do Produto");
            ListaProdutos.Columns.Add("Nome", "Nome Do Produto");
            ListaProdutos.Columns.Add("codigocategoria", "Categoria Do Produto");
            ListaProdutos.Columns.Add("Preco", "Preço Do Produto ");


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
                string selectQuerry = "SELECT Produtos.Codigo, Produtos.Nome, Produtos.Preco, Categorias.Nome AS NomeCategoria FROM Produtos INNER JOIN Categorias ON Produtos.CodigoCategoria = Categorias.Codigo";

                // obter o resultado da query
                DataTable resultado = dbHelper.GetDataTable(selectQuerry);

                // Se o resultado da não for nulo
                if (resultado != null)
                    preencherTabela(resultado);

            }
            catch (Exception ex) // apanhar exceções
            {
                MessageBox.Show("Erro ao tentar conectar a base de dados");
            }
        }

        private void preencherTabela(DataTable resultado)
        { 
            // limpar a lista dos Produtos 
            ListaProdutos.Rows.Clear();

            // Loop pelo resultado da e agrupa em linhas para a tabela 
            foreach (DataRow row in resultado) 
            {
                // Adiciona os dados a lista 
                ListaProdutos.Rows.Add(
                    row["Codigo"].ToString();#


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormInicial FormInicial = new FormInicial();
            FormInicial.Show();

            this.Hide();
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Tem a certeza que deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
                Application.Exit();
        }

        private void inputPesquisa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
