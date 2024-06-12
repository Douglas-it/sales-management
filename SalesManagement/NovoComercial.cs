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
    public partial class NovoComercial : Form
    {
        public NovoComercial()
        {
            InitializeComponent();
        }

        private void NovoComercial_Load(object sender, EventArgs e)
        {

        }

        // Botão de Voltar
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Botão de Adicionar o Comercial
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Definição de Variáveis
            string codigo = inputCodigo.Text;
            string nome = inputNome.Text;
            string comissao = inputComissao.Text;

            // Verifica se os inputs são válidos
            if (OperacoesGerais.LerStringValida(codigo) && OperacoesGerais.LerStringValida(nome) && OperacoesGerais.LerDecimalValido(comissao, 0, 100))
            {
                try
                {
                    DatabaseHelper dbHelper = new DatabaseHelper();

                    // Query para verificar se o vendedor existe com base no código inserido pelo utilizador
                    string selectQuery = "SELECT * FROM Vendedores WHERE Codigo = @Codigo";

                    // Parâmetros para a Query
                    SqlParameter selectParam = new SqlParameter("@Codigo", SqlDbType.VarChar) { Value = codigo };

                    // Executa a query e retorna o resultado
                    DataTable result = dbHelper.GetDataTable(selectQuery, selectParam);

                    // Se não existerem rows ==> Adiciona o novo Comercial
                    if (result.Rows.Count == 0)
                    {
                        string insertQuery = "INSERT INTO Vendedores (Codigo, Nome, Comissao) VALUES (@Codigo, @Nome, @Comissao)";

                        SqlParameter insertParam1 = new SqlParameter("@Codigo", SqlDbType.VarChar) { Value = codigo };
                        SqlParameter insertParam2 = new SqlParameter("@Nome", SqlDbType.VarChar) { Value = nome };
                        SqlParameter insertParam3 = new SqlParameter("@Comissao", SqlDbType.Float) { Value = comissao };

                        dbHelper.ExecuteQuery(insertQuery, insertParam1, insertParam2, insertParam3);

                        MessageBox.Show("Comercial adicionado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Coloca o DialogResult = OK para poder atualizar a lista
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                        MessageBox.Show("Já existe um comercial com esse código!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao tentar conectar a base de dados: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                inputCodigo.Text = "";
                inputNome.Text = "";
                inputComissao.Text = "";
            }
                
        }
    }
}
