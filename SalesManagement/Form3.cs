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
            listComerciais.View = View.Details;

            // Cabeçalho da List View dos Comerciais
            listComerciais.Columns.Add("ID", 50);
            listComerciais.Columns.Add("Nome", 100);
            listComerciais.Columns.Add("Comissão", 150);

            try
            {
                // Inicializar a classe DatabaseHelper
                DatabaseHelper dbHelper = new DatabaseHelper();

                // Query para selecionar o utilizador
                string selectQuery = "SELECT * FROM Vendedores";

                // Obter o resultado da query
                DataTable result = dbHelper.GetDataTable(selectQuery);

                if (result != null)
                {
                    foreach (DataRow row in result.Rows)
                    {
                        ListViewItem item = new ListViewItem(row["Codigo"].ToString());
                        item.SubItems.Add(row["Nome"].ToString());

                        // Convert Comissao para string
                        decimal comissao = Convert.ToDecimal(row["Comissao"]);
                        item.SubItems.Add(comissao.ToString("F2")); // "F2" 2 casas decimais

                        // Adicionar item à ListView
                        listComerciais.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Não existem vendedores na base de dados!");
                }

            }
            catch (Exception ex) // Apanhar exceções
            {
                MessageBox.Show("Erro ao tentar conectar a base de dados: " + ex.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormInicial FormInicial = new FormInicial();
            FormInicial.Show();

            this.Hide();
        }

        private void listComerciais_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
