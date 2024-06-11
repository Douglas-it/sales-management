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
            ListaComerciais.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Resize automático das colunas
            ListaComerciais.AllowUserToAddRows = false; // Não permitir adicionar linhas

            // Adicionar colunas (nomes internos e visíveis)
            ListaComerciais.Columns.Add("ID", "Código");
            ListaComerciais.Columns.Add("nome", "nome");
            ListaComerciais.Columns.Add("comissao", "Comissão");
            ListaComerciais.Columns.Add("totalVendas", "Total de Vendas");
            ListaComerciais.Columns.Add("aReceber", "A Receber");

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

            // Carregar Dados da base de dados
            LoadData();
        }

        // Função que carrega os dados da base de dados
        private void LoadData()
        {
            try
            {
                // Inicializar a classe DatabaseHelper
                DatabaseHelper dbHelper = new DatabaseHelper();

                // Query para selecionar o utilizador
                string selectQuery = "SELECT V.Codigo, V.Nome, V.Comissao, COALESCE(SUM(Vendas.ValorVenda), 0) as totalVendas FROM Vendedores V LEFT JOIN Vendas ON V.Codigo = Vendas.CodigoVendedor GROUP BY V.Codigo, V.Nome, V.Comissao";

                // Obter o resultado da query
                DataTable result = dbHelper.GetDataTable(selectQuery);

                // Se o resultado não for nulo
                if (result != null)
                {
                    // Limpar a lista dos comerciais
                    ListaComerciais.Rows.Clear();

                    // Loop pelo resultado e agrupa em linhas para a tabela
                    foreach (DataRow row in result.Rows)
                    {
                        decimal totalVendas = Convert.ToDecimal(row["totalVendas"]);
                        decimal comissao = Convert.ToDecimal(row["Comissao"]);
                        string aReceber = "0";

                        // Calcula o montante a receber de comissões das vendas que efetuou
                        if (totalVendas != 0 && comissao != 0)
                        {
                            decimal calculoComissao = totalVendas * comissao / 100; // Calcula o valor da comissão a receber 
                            aReceber = calculoComissao.ToString("F2");
                        }

                        // Adiciona os dados na lista
                        ListaComerciais.Rows.Add(
                            row["Codigo"].ToString(),
                            row["Nome"].ToString(),
                            comissao.ToString("F2"),
                            totalVendas.ToString("F2"),
                            aReceber
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


        private void ApagarComercial(string id)
        {
            try
            {
                // Inicializar a classe DatabaseHelper
                DatabaseHelper dbHelper = new DatabaseHelper();

                // Query para selecionar o utilizador
                string selectQuery = "DELETE FROM Vendedores WHERE codigo = @codigoComercial";

                // Parâmetros para a query
                SqlParameter param1 = new SqlParameter("@codigoComercial", SqlDbType.VarChar) { Value = id };

                // Obter o resultado da query
                dbHelper.ExecuteQuery(selectQuery, param1);

                MessageBox.Show("O comercial foi eliminado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpar a lista dos comerciais
                ListaComerciais.Rows.Clear();

                // Load data de novo
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar apagar o comercial: " + ex.Message);
            }
        }

        private void EditarComercial(string id, string nome, string comissao)
        {
            try
            {
                // Inicializar a classe DatabaseHelper
                DatabaseHelper dbHelper = new DatabaseHelper();

                // Query para selecionar o utilizador
                string selectQuery = "UPDATE Vendedores SET nome = @nomeComercial, comissao = @comissaoComercial WHERE codigo = @codigoComercial";

                // Parâmetros para a query
                SqlParameter param1 = new SqlParameter("@nomeComercial", SqlDbType.VarChar) { Value = nome };
                SqlParameter param2 = new SqlParameter("@comissaoComercial", SqlDbType.Decimal) { Value = comissao };
                SqlParameter param3 = new SqlParameter("@codigoComercial", SqlDbType.VarChar) { Value = id };

                // Obter o resultado da query
                dbHelper.ExecuteQuery(selectQuery, param1, param2, param3);

                MessageBox.Show("O comercial foi atualizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpar a lista dos comerciais
                ListaComerciais.Rows.Clear();

                // Load data de novo
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar atualizar o comercial: " + ex.Message);
            }
        }

        private void EditItem(int rowIndex)
        {
            DialogResult = MessageBox.Show($"Tem a certeza que deseja alterar?", "Alterar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (DialogResult == DialogResult.Yes)
            {
                string id = ListaComerciais.Rows[rowIndex].Cells["ID"].Value.ToString();
                string nome = ListaComerciais.Rows[rowIndex].Cells["nome"].Value.ToString();
                string comissao = ListaComerciais.Rows[rowIndex].Cells["comissao"].Value.ToString();

                EditarComercial(id, nome, comissao);
            }
        }

        private void DeleteItem(int rowIndex)
        {
            string id = ListaComerciais.Rows[rowIndex].Cells["ID"].Value.ToString();
            DialogResult = MessageBox.Show($"Tem a certeza que deseja eliminar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (DialogResult == DialogResult.Yes)
            {
                ApagarComercial(id);
            }
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

        private void btnNovoComercial_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = inputPesquisa.Text;

            if (OperacoesGerais.LerStringValida(pesquisa))
            {
                try
                {
                    // Inicializar a classe DatabaseHelper
                    DatabaseHelper dbHelper = new DatabaseHelper();

                    // Query para selecionar o utilizador
                    string selectQuery = "SELECT V.Codigo, V.Nome, V.Comissao, COALESCE(SUM(Vendas.ValorVenda), 0) as totalVendas FROM Vendedores V LEFT JOIN Vendas ON V.Codigo = Vendas.CodigoVendedor WHERE V.Nome LIKE @pesquisa OR V.Codigo LIKE @pesquisa GROUP BY V.Codigo, V.Nome, V.Comissao";

                    // Parâmetros para a query
                    SqlParameter param1 = new SqlParameter("@pesquisa", SqlDbType.VarChar) { Value = "%" + pesquisa + "%" };

                    // Obter o resultado da query
                    DataTable result = dbHelper.GetDataTable(selectQuery, param1);

                    // Se o resultado não for nulo
                    if (result != null)
                    {
                        // Limpar a lista dos comerciais
                        ListaComerciais.Rows.Clear();

                        // Loop pelo resultado e agrupa em linhas para a tabela
                        foreach (DataRow row in result.Rows)
                        {
                            decimal totalVendas = Convert.ToDecimal(row["totalVendas"]);
                            decimal comissao = Convert.ToDecimal(row["Comissao"]);
                            string aReceber = "0";

                            // Calcula o montante a receber de comissões das vendas que efetuou
                            if (totalVendas != 0 && comissao != 0)
                            {
                                decimal calculoComissao = totalVendas * comissao / 100; // Calcula o valor da comissão a receber 
                                aReceber = calculoComissao.ToString("F2");
                            }

                            // Adiciona os dados na lista
                            ListaComerciais.Rows.Add(
                                row["Codigo"].ToString(),
                                row["Nome"].ToString(),
                                comissao.ToString("F2"),
                                totalVendas.ToString("F2"),
                                aReceber
                            );
                        }
                    }
                }
                catch (Exception ex) // Apanhar exceções
                {
                    MessageBox.Show("Erro ao tentar conectar a base de dados: " + ex.Message);
                }
            }
            else
                MessageBox.Show("Por favor insira um nome para pesquisar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            inputPesquisa.Text = "";
            ListaComerciais.Rows.Clear();

            LoadData();

        }
    }
}
