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

            // Propriedades dataGridView
            ListaComerciais.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Resize automático das colunas
            ListaComerciais.AllowUserToAddRows = false; // Não permitir adicionar linhas

            // Adicionar colunas (nomes internos e visíveis)
            ListaComerciais.Columns.Add("ID", "Código");
            ListaComerciais.Columns.Add("nome", "Nome");
            ListaComerciais.Columns.Add("comissao", "Comissão");
            ListaComerciais.Columns.Add("totalVendasAnual", "Total de Vendas (Anual)");
            ListaComerciais.Columns.Add("totalVendasMes", "Total de Vendas (Mês Corrente)");
            ListaComerciais.Columns.Add("aReceberMensal", "A Receber (Mês)");
            ListaComerciais.Columns.Add("aReceberAnual", "Valor faturado (Anual)");

            // Adição de botão de Editar
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn(); // Criação de uma nova coluna de botão
            btnEditar.Name = "Editar"; // Nome da coluna
            btnEditar.HeaderText = "Editar"; // Cabeçalho da coluna
            btnEditar.Text = "Editar"; // Texto do botão
            btnEditar.UseColumnTextForButtonValue = true; // Usar o texto da coluna para o botão
            ListaComerciais.Columns.Add(btnEditar); // Adicionar a coluna à tabela

            // Adição de botão de Eliminar
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.Name = "Eliminar";
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            ListaComerciais.Columns.Add(btnEliminar);

            // Desativar a edição das células ID, totalVendas e aReceber
            foreach (DataGridViewColumn column in ListaComerciais.Columns)
                column.ReadOnly = true;

            // Carregar Dados da base de dados
            LoadData();

            if (!Globals.admin)
            {
                btnEliminar.Visible = false;
                btnEditar.Visible = false;
            }
        }

        // Função que carrega os dados da base de dados
        private void LoadData()
        {
            try
            {
                // Inicializar a classe DatabaseHelper
                DatabaseHelper dbHelper = new DatabaseHelper();

                // Query para selecionar o utilizador
                string selectQuery = "SELECT V.Codigo,V.Nome, V.Comissao, COALESCE(SUM(Vendas.ValorVenda), 0) as totalVendasAnual, COALESCE(SUM(CASE WHEN MONTH(Vendas.DataVenda) = MONTH(GETDATE()) THEN Vendas.ValorVenda ELSE 0 END), 0) as totalVendasMes FROM Vendedores V LEFT JOIN Vendas ON V.Codigo = Vendas.CodigoVendedor GROUP BY V.Codigo, V.Nome, V.Comissao";

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
            ListaComerciais.Rows.Clear();

            // Loop pelo resultado da e agrupa em linhas para a tabela
            foreach (DataRow row in resultado.Rows)
            {
                decimal totalVendasAnual = Convert.ToDecimal(row["totalVendasAnual"]);
                decimal totalVendasMes = Convert.ToDecimal(row["totalVendasMes"]);
                decimal comissao = Convert.ToDecimal(row["Comissao"]);
                string aReceberMes = "0";
                string aReceberAnual = "0";

                // Calcula o montante a receber de comissões das vendas que efetuou
                if (totalVendasMes != 0 && comissao != 0)
                {
                    decimal calculoComissaoMes = totalVendasMes * comissao / 100; // Calcula o valor da comissão a receber Mensal
                    aReceberMes = calculoComissaoMes.ToString("F2");

                    decimal calculoComissaoAno = totalVendasAnual * comissao / 100; // Calcula o valor da comissão a receber Anual
                    aReceberAnual = calculoComissaoAno.ToString("F2");
                }

                // Adiciona os dados na lista
                ListaComerciais.Rows.Add(
                    row["Codigo"].ToString(),
                    row["Nome"].ToString(),
                    Convert.ToDecimal(comissao) + "%",
                    Convert.ToDecimal(totalVendasAnual) + "€",
                    Convert.ToDecimal(totalVendasMes) + "€",
                    aReceberMes + "€",
                    aReceberAnual + "€"
                    );
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

                // Carrega os dados novamente para atualizar a lista
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar apagar o comercial: " + ex.Message);
            }
        }

        private void EditItem(int rowIndex)
        {
            string id = ListaComerciais.Rows[rowIndex].Cells["id"].Value.ToString();
            string nome = ListaComerciais.Rows[rowIndex].Cells["nome"].Value.ToString();
            string comissao = ListaComerciais.Rows[rowIndex].Cells["comissao"].Value.ToString().Replace("%", "");

            FormEditarVendedores formEditarVendedores = new FormEditarVendedores(id, nome, comissao);
            formEditarVendedores.ShowDialog();

            LoadData();
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
            // Verifica se a célula clicada é um botão ou não
            if (e.RowIndex >= 0)
            {
                string opcao = ListaComerciais.Columns[e.ColumnIndex].Name;

                if (opcao == "Editar")
                    EditItem(e.RowIndex); // Controla o botão de Editar
                else if (opcao == "Eliminar")
                    DeleteItem(e.RowIndex); // Controla o botão de Eliminar
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Tem a certeza que deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
                Application.Exit();
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
                    string selectQuery = "SELECT V.Codigo,V.Nome, V.Comissao, COALESCE(SUM(Vendas.ValorVenda), 0) as totalVendasAnual, COALESCE(SUM(CASE WHEN MONTH(Vendas.DataVenda) = MONTH(GETDATE()) THEN Vendas.ValorVenda ELSE 0 END), 0) as totalVendasMes FROM Vendedores V LEFT JOIN Vendas ON V.Codigo = Vendas.CodigoVendedor WHERE V.Nome LIKE @pesquisa OR V.Codigo LIKE @pesquisa GROUP BY V.Codigo, V.Nome, V.Comissao\r\n";

                    // Parâmetros para a query
                    SqlParameter param1 = new SqlParameter("@pesquisa", SqlDbType.VarChar) { Value = "%" + pesquisa + "%" };

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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            inputPesquisa.Text = "";
            ListaComerciais.Rows.Clear();

            LoadData();
        }

        private void FormVendedores_Load(object sender, EventArgs e)
        {

        }
    }
}
