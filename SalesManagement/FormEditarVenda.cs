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
    public partial class FormEditarVenda : Form
    {
        private string privateIdVenda;

        public FormEditarVenda(string codigoProduto, string zonaVenda, string dataVenda, string quantidadeVenda, string IdVenda, string codigoVendedor)
        {
            InitializeComponent();

            privateIdVenda = IdVenda;

            DataTable obterProdutos = Produtos.ObterProdutos();

            foreach (DataRow row in obterProdutos.Rows)
            {
                comboProdutos.Items.Add(row["Nome"].ToString());

                if (row["Codigo"].ToString() == codigoProduto)
                {
                    comboProdutos.Text = row["Nome"].ToString();
                    txtPrecoUnitario.Text = row["Preco"].ToString();

                    // Convert the dataVendaStr to a DateTime object
                    if (DateTime.TryParse(dataVenda, out DateTime specificDate))
                    {
                        // Set the specific date to the MonthCalendar control
                        dataVendaCalendario.SelectionStart = specificDate;
                        dataVendaCalendario.SelectionEnd = specificDate;
                    }
                }
            }

            DataTable obterVendedores = Vendedores.ObterComerciais();

            foreach (DataRow row in obterVendedores.Rows)
            {
                comboVendedores.Items.Add(row["Nome"].ToString());

                if (row["Codigo"].ToString() == codigoVendedor)
                {
                    comboVendedores.Text = row["Nome"].ToString();
                }
            }

            DataTable obterZonas = OperacoesGerais.ObterZonas();

            foreach (DataRow row in obterZonas.Rows)
            {
                comboZonas.Items.Add(row["Abreviatura"].ToString());

                if (row["Id"].ToString() == zonaVenda)
                {
                    comboZonas.Text = row["Abreviatura"].ToString();
                }
            }

            comboZonas.Text = zonaVenda;
            txtQuantidade.Text = quantidadeVenda;

            decimal valorVenda = Convert.ToDecimal(txtQuantidade.Text) * Convert.ToDecimal(txtPrecoUnitario.Text);

            txtValorTotal.Text = valorVenda.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string vendedor = comboVendedores.Text;
            string produto = comboProdutos.Text;
            string zona = comboZonas.Text;
            string dataVenda = dataVendaCalendario.SelectionStart.ToString("yyyy-MM-dd");
            string quantidade = txtQuantidade.Text;
            string valorVenda = txtValorTotal.Text;
            string precoUnitario = txtPrecoUnitario.Text;

            if (!OperacoesGerais.LerInteiroValido(quantidade, 0))
            {
                MessageBox.Show("Por favor insira uma quantidade válida.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obter o ID do Vendedor
            int codigoVendedor = Vendedores.ObterIdComercial(vendedor);
            string codigoProduto = Produtos.ObterIdProduto(produto);
            int codigoZona = OperacoesGerais.ObterZonaId(zona);

            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();

                string updateQuery = @"
                    UPDATE Vendas 
                    SET 
                        CodigoProduto = @CodigoProduto, 
                        CodigoVendedor = @CodigoVendedor, 
                        Zona = @Zona, 
                        DataVenda = @DataVenda, 
                        Quantidade = @Quantidade, 
                        ValorVenda = @ValorVenda 
                    WHERE Id = @IdVenda";

                SqlParameter paramCodigoProduto = new SqlParameter("@CodigoProduto", SqlDbType.VarChar) { Value = codigoProduto };
                SqlParameter paramCodigoVendedor = new SqlParameter("@CodigoVendedor", SqlDbType.VarChar) { Value = codigoVendedor };
                SqlParameter paramZona = new SqlParameter("@Zona", SqlDbType.VarChar) { Value = codigoZona };
                SqlParameter paramDataVenda = new SqlParameter("@DataVenda", SqlDbType.Date) { Value = dataVenda };
                SqlParameter paramQuantidade = new SqlParameter("@Quantidade", SqlDbType.Int) { Value = quantidade };
                SqlParameter paramValorVenda = new SqlParameter("@ValorVenda", SqlDbType.Decimal) { Value = valorVenda };
                SqlParameter paramIdVenda = new SqlParameter("@IdVenda", SqlDbType.Int) { Value = Convert.ToInt32(privateIdVenda) };

                dbHelper.ExecuteQuery(updateQuery, paramCodigoProduto, paramCodigoVendedor, paramZona, paramDataVenda, paramQuantidade, paramValorVenda, paramIdVenda);

                MessageBox.Show("O produto foi alterado com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar alterar a venda: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (OperacoesGerais.LerInteiroValido(txtQuantidade.Text, 0))
            {
                decimal valorVenda = Convert.ToDecimal(txtQuantidade.Text) * Convert.ToDecimal(txtPrecoUnitario.Text);

                txtValorTotal.Text = valorVenda.ToString();
            }
            else
                txtValorTotal.Text = "0";
        }
    }
}
