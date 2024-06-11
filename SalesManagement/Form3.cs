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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SalesManagement
{
    public partial class FormVendedores : System.Windows.Forms.Form
    {
        public FormVendedores()
        {
            InitializeComponent();

            // Propriedades da DataGridView
            ListaComerciais.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ListaComerciais.AllowUserToAddRows = false;

            // Adicionar colunas
            ListaComerciais.Columns.Add("ID", "ID");
            ListaComerciais.Columns.Add("Nome", "Nome");
            ListaComerciais.Columns.Add("Comissao", "Comissão");

            // Adição de botão de Editar
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "Editar";
            editButtonColumn.HeaderText = "Editar";
            editButtonColumn.Text = "Editar";
            editButtonColumn.UseColumnTextForButtonValue = true;
            ListaComerciais.Columns.Add(editButtonColumn);

            // Adição de botão de Eliminar
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "Eliminar";
            deleteButtonColumn.HeaderText = "Eliminar";
            deleteButtonColumn.Text = "Eliminar";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            ListaComerciais.Columns.Add(deleteButtonColumn);

            // Load data da base de dados
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Inicializar a classe DatabaseHelper
                DatabaseHelper dbHelper = new DatabaseHelper();

                // Query para selecionar o utilizador
                string selectQuery = "SELECT * FROM Vendedores";

                // Obter o resultado da query
                DataTable result = dbHelper.GetDataTable(selectQuery);

                // Se o resultado não for nulo
                if (result != null)
                {
                    // Loop pelo resultado e agrupa em linhas para a tabela
                    foreach (DataRow row in result.Rows)
                    {
                        ListaComerciais.Rows.Add(
                            row["Codigo"].ToString(),
                            row["Nome"].ToString(),
                            Convert.ToDecimal(row["Comissao"]).ToString("F2")
                            );
                    }
                }
                else
                    MessageBox.Show("Não existem vendedores na base de dados!");
            }
            catch (Exception ex) // Apanhar exceções
            {
                MessageBox.Show("Erro ao tentar conectar a base de dados: " + ex.Message);
            }
        }

        private void EditItem(int rowIndex)
        {
            var id = ListaComerciais.Rows[rowIndex].Cells["ID"].Value.ToString();
            MessageBox.Show($"Edit item with ID: {id}");
            // Your edit logic here
        }

        private void DeleteItem(int rowIndex)
        {
            var id = ListaComerciais.Rows[rowIndex].Cells["ID"].Value.ToString();
            MessageBox.Show($"Delete item with ID: {id}");
            // Your delete logic here
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormInicial FormInicial = new FormInicial();
            FormInicial.Show();

            this.Hide();
        }

        private void ListaComerciais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is a button cell
            if (e.RowIndex >= 0)
            {
                if (ListaComerciais.Columns[e.ColumnIndex].Name == "Editar")
                {
                    // Handle the Edit button click
                    EditItem(e.RowIndex);
                }
                else if (ListaComerciais.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    // Handle the Delete button click
                    DeleteItem(e.RowIndex);
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Tem a certeza que deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
                Application.Exit();
        }
    }
}
