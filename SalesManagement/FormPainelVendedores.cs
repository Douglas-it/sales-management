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
            ListaComerciais.Columns.Add("totalVendas", "Total de Vendas");
            ListaComerciais.Columns.Add("aReceber", "A Receber");

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

            // Desativar a edição das células totalVendas e aReceber
            ListaComerciais.Columns["totalVendas"].ReadOnly = true;
            ListaComerciais.Columns["aReceber"].ReadOnly = true;

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
                    Convert.ToDecimal(comissao) + "%",
                    Convert.ToDecimal(totalVendas) + "€",
                    aReceber + "€"
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

        private void EditarComercial(string id, string nome, decimal comissao)
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

                // Carrega os dados novamente para atualizar a lista
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
                string comissao = ListaComerciais.Rows[rowIndex].Cells["comissao"].Value.ToString().Replace("%", "");

                if (OperacoesGerais.LerDecimalValido(comissao, 0, 100))
                {
                    decimal comissaoSemSimbolo = Convert.ToDecimal(comissao);
                    EditarComercial(id, nome, comissaoSemSimbolo);
                }
                else
                    MessageBox.Show("Por favor insira uma comissão válida!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnNovoComercial_Click(object sender, EventArgs e)
        {
            FormNovoComercial novoComercial = new FormNovoComercial();
            DialogResult = novoComercial.ShowDialog();

            if (DialogResult == DialogResult.OK)
                LoadData();
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
    }
}
