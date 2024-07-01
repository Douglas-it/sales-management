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
    public partial class FormVenda : Form
    {
        public FormVenda()
        {
            InitializeComponent();

            // Carregar os produtos
            DataTable obterProdutos = Produtos.ObterProdutos();

            foreach (DataRow row in obterProdutos.Rows)
            {
                comboProduto.Items.Add(row["Nome"].ToString());
            }

            // Carregar os vendedores
            DataTable obterVendedores = Vendedores.ObterComerciais();

            foreach (DataRow row in obterVendedores.Rows)
            {
                comboVendedor.Items.Add(row["Nome"].ToString());
            }

            // Carregar as zonas
            DataTable obterZonas = OperacoesGerais.ObterZonas();

            foreach (DataRow row in obterZonas.Rows)
            {
                comboZona.Items.Add(row["Abreviatura"].ToString());
            }
        }

        private void FormVenda_Load_1(object sender, EventArgs e) { }

        private void comboProduto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string filtro = @"WHERE Nome = '" + comboProduto.Text + "'";

            DataTable resultado = Produtos.ObterProdutos(filtro);

            txtPreco.Text = resultado.Rows[0]["Preco"].ToString();
            txtTotalVenda.Text = resultado.Rows[0]["Preco"].ToString();
            txtQuantidade.Text = "1";
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (OperacoesGerais.LerInteiroValido(txtQuantidade.Text, 1))
            {
                decimal valorTotal = Convert.ToDecimal(txtPreco.Text) * Convert.ToDecimal(txtQuantidade.Text);
                txtTotalVenda.Text = valorTotal.ToString();
            }
            else
                txtTotalVenda.Text = "0";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string produto = comboProduto.Text;
            string vendedor = comboVendedor.Text;
            string zona = comboZona.Text;
            string dataVenda = dataVendaCalendario.SelectionStart.ToString("yyyy-MM-dd");
            string quantidade = txtQuantidade.Text;
            string valorTotal = txtTotalVenda.Text;

            string codigoProduto = Produtos.ObterIdProduto(comboProduto.Text);
            int codigoVendedor = Vendedores.ObterIdComercial(vendedor);
            int codigoZona = OperacoesGerais.ObterZonaId(comboZona.Text);

            if (!OperacoesGerais.LerInteiroValido(quantidade, 1))
            {
                MessageBox.Show("Quantidade inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();

                string insertQuery = @"
                    INSERT INTO Vendas (CodigoVendedor, Zona, DataVenda, Quantidade, CodigoProduto, ValorVenda) VALUES 
                    (@codigoVendedor, @codigoZona, @dataVenda, @quantidade, @codigoProduto, @valorTotal)";

                SqlParameter paramCodigoProduto = new SqlParameter("@codigoProduto", SqlDbType.VarChar) { Value = codigoProduto };
                SqlParameter paramCodigoVendedor = new SqlParameter("@codigoVendedor", SqlDbType.Int) { Value = codigoVendedor };
                SqlParameter paramCodigoZona = new SqlParameter("@codigoZona", SqlDbType.Int) { Value = codigoZona };
                SqlParameter paramDataVenda = new SqlParameter("@dataVenda", SqlDbType.Date) { Value = dataVenda };
                SqlParameter paramQuantidade = new SqlParameter("@quantidade", SqlDbType.Int) { Value = quantidade };
                SqlParameter paramValorTotal = new SqlParameter("@valorTotal", SqlDbType.Decimal) { Value = valorTotal };

                dbHelper.ExecuteQuery(insertQuery, paramCodigoProduto, paramCodigoVendedor, paramCodigoZona, paramDataVenda, paramQuantidade, paramValorTotal);

                MessageBox.Show("Venda inserida com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar inserir a venda: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormVenda_FormClosed(object sender, FormClosedEventArgs e) { }
    }
}
