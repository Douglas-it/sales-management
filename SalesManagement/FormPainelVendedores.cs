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

            // Define os nomes internos das colunas
            string[] nomeColunas = {
                "ID",
                "nome",
                "comissao",
                "totalVendasAnual",
                "totalVendasMes",
                "aReceberMensal",
                "aReceberAnual"
            };

            // Define os nomes visiveis das colunas
            string[] nomeColunasVisivel = {
                "Código",
                "Nome",
                "Comissão",
                "Total de Vendas (Anual)",
                "Total de Vendas (Mês Corrente)",
                "A Receber (Mês)",
                "Valor faturado (Anual)"
            };

            // Define se as colunas são editáveis
            bool[] colunasReadOnly = { true, true, true, true, true, true, true };

            // Configura se os botões de editar e eliminar estão visíveis
            bool botaoEditar = true;
            bool botaoEliminar = true;

            // Cria a tabela
            OperacoesGerais.ConfigurarDataGridView(ListaComerciais, nomeColunas, nomeColunasVisivel, colunasReadOnly, botaoEditar, botaoEliminar);

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
                string selectQuery = @"
                    SELECT 
                        V.Codigo, V.Nome, V.Comissao, 
                        COALESCE(SUM(Vendas.ValorVenda), 0) AS totalVendasAnual, 
                        SUM(CASE WHEN MONTH(Vendas.DataVenda) = MONTH(GETDATE()) THEN Vendas.ValorVenda ELSE 0 END) AS totalVendasMes 
                    FROM Vendedores V 
                    LEFT JOIN Vendas ON V.Codigo = Vendas.CodigoVendedor 
                    GROUP BY V.Codigo, V.Nome, V.Comissao";

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

                string id = ListaComerciais.Rows[e.RowIndex].Cells["id"].Value.ToString();
                string nome = ListaComerciais.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                string comissao = ListaComerciais.Rows[e.RowIndex].Cells["comissao"].Value.ToString().Replace("%", "");

                if (opcao == "Editar")
                {
                    FormEditarVendedores formEditarVendedores = new FormEditarVendedores(id, nome, comissao);
                    formEditarVendedores.ShowDialog(); // Mostra o form de Editar Vendedores

                    LoadData(); // Carrega os dados novamente para atualizar a lista
                }
                else if (opcao == "Eliminar")
                {
                    DialogResult = MessageBox.Show($"Tem a certeza que deseja eliminar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (DialogResult == DialogResult.Yes)
                    {
                        if (Vendedores.VerificarVendas(id))
                        {
                            MessageBox.Show("Não é possível eliminar o comercial, pois existem vendas associadas ao mesmo!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        Vendedores.ApagarComercial(id); // Apaga o comercial da base de dados
                        LoadData(); // Carrega os dados novamente para atualizar a lista
                    }
                }
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
                    string selectQuery = @"
                        SELECT 
                            V.Codigo, V.Nome, V.Comissao, 
                            COALESCE(SUM(Vendas.ValorVenda), 0) AS totalVendasAnual, 
                            SUM(CASE WHEN MONTH(Vendas.DataVenda) = MONTH(GETDATE()) THEN Vendas.ValorVenda ELSE 0 END) AS totalVendasMes 
                        FROM Vendedores V 
                        LEFT JOIN Vendas ON V.Codigo = Vendas.CodigoVendedor 
                        WHERE V.Nome LIKE @pesquisa OR V.Codigo LIKE @pesquisa
                        GROUP BY V.Codigo, V.Nome, V.Comissao";
                    
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

            LoadData();
        }

        private void FormVendedores_Load(object sender, EventArgs e) { }
        private void inputPesquisa_TextChanged(object sender, EventArgs e) { }
    }
}
