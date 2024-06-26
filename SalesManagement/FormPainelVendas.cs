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

            // Propriedades dataGridView
            ListaVendas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Resize automático das colunas
            ListaVendas.AllowUserToAddRows = false; // Não permitir adicionar linhas

            // Adicionar colunas (nomes internos e visíveis)
            ListaVendas.Columns.Add("ID", "Código");
            ListaVendas.Columns.Add("Produto", "Código Vendedor");
            ListaVendas.Columns.Add("Categoria", "Zona");
            ListaVendas.Columns.Add("Preço", "Data Venda");
            ListaVendas.Columns.Add("Quantidade", "Quantidade");
            ListaVendas.Columns.Add("Preço", "Preço");
            ListaVendas.Columns.Add("Quantidade", "Valor Venda");

            // Adição de botão de Editar
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn(); // Criação de uma nova coluna de botão
            btnEditar.Name = "Editar"; // Nome da coluna
            btnEditar.HeaderText = "Editar"; // Cabeçalho da coluna
            btnEditar.Text = "Editar"; // Texto do botão
            btnEditar.UseColumnTextForButtonValue = true; // Usar o texto da coluna para o botão
            ListaVendas.Columns.Add(btnEditar); // Adicionar a coluna à tabela

            // Adição de botão de Eliminar
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.Name = "Eliminar";
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            ListaVendas.Columns.Add(btnEliminar);

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
                string selectQuery = "SELECT * FROM vendas";

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
                    row["Id"].ToString(),
                    row["CodigoVendedor"].ToString(),
                    row["Zona"].ToString(),
                    row["DataVenda"].ToString(),
                    row["Quantidade"].ToString(),
                    row["CodigoProduto"].ToString(),
                    row["ValorVenda"].ToString()
                                                       );
            }
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            FormVenda frm = new FormVenda();
            frm.Show();
        }
    }
}
