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

            // Obtem os Produtos
            DataTable obterProdutos = Produtos.ObterProdutos();

            // Carrega os produtos para o ComboBox
            foreach (DataRow row in obterProdutos.Rows)
                comboProduto.Items.Add(row["Nome"].ToString());

            // Obtem os Vendedores
            DataTable obterVendedores = Vendedores.ObterComerciais();

            // Carrega os vendedores para o ComboBox
            foreach (DataRow row in obterVendedores.Rows)
                comboVendedor.Items.Add(row["Nome"].ToString());

            // Obtem as Zonas
            DataTable obterZonas = OperacoesGerais.ObterZonas();

            // Carrega as zonas para o ComboBox
            foreach (DataRow row in obterZonas.Rows)
                comboZona.Items.Add(row["Abreviatura"].ToString());
        }

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

            Vendas.InserirVenda(codigoProduto, codigoVendedor, codigoZona, dataVenda, quantidade, valorTotal);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormVenda_FormClosed(object sender, FormClosedEventArgs e) { }
        private void FormVenda_Load_1(object sender, EventArgs e) { }
    }
}
