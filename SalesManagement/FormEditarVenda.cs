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
        private string privateIdVenda; // Id da Venda que está a ser editada

        public FormEditarVenda(string codigoProduto, string zonaVenda, string dataVenda, string quantidadeVenda, string IdVenda, string codigoVendedor)
        {
            InitializeComponent();

            privateIdVenda = IdVenda; // Associa o Id da Venda à variável privada

            //Obtem os produtos da base de dados
            DataTable obterProdutos = Produtos.ObterProdutos();

            // Percorre os produtos e adiciona-os ao combobox
            foreach (DataRow row in obterProdutos.Rows)
            {
                comboProdutos.Items.Add(row["Nome"].ToString());

                // Verifica se o código do produto é igual ao código do produto passado como argumento
                if (row["Codigo"].ToString() == codigoProduto)
                {
                    // Se for igual, associa o nome do produto ao combobox
                    comboProdutos.Text = row["Nome"].ToString();

                    // Associa o preço do produto ao textbox
                    txtPrecoUnitario.Text = row["Preco"].ToString();

                    // Converte a dataVenda para um DateTime objeto
                    if (DateTime.TryParse(dataVenda, out DateTime dataDaVenda))
                    {
                        // Associa a data ao calendário
                        dataVendaCalendario.SelectionStart = dataDaVenda;
                        dataVendaCalendario.SelectionEnd = dataDaVenda;
                    }
                }
            }

            // Obtem os vendedores da base de dados
            DataTable obterVendedores = Vendedores.ObterComerciais();

            // Percorre os vendedores e adiciona-os ao combobox
            foreach (DataRow row in obterVendedores.Rows)
            {
                comboVendedores.Items.Add(row["Nome"].ToString());

                // Verifica se o código do vendedor é igual ao código do vendedor passado como argumento
                if (row["Codigo"].ToString() == codigoVendedor)
                    // Se for igual, associa o nome do vendedor ao combobox
                    comboVendedores.Text = row["Nome"].ToString();
            }

            // Obtem as zonas da base de dados
            DataTable obterZonas = OperacoesGerais.ObterZonas();

            // Percorre as zonas e adiciona-as ao combobox
            foreach (DataRow row in obterZonas.Rows)
            {
                comboZonas.Items.Add(row["Abreviatura"].ToString());

                // Verifica se o código da zona é igual ao código da zona passado como argumento
                if (row["Id"].ToString() == zonaVenda)
                    // Se for igual, associa a abreviatura da zona ao combobox
                    comboZonas.Text = row["Abreviatura"].ToString();
            }

            comboZonas.Text = zonaVenda;
            txtQuantidade.Text = quantidadeVenda;

            decimal valorVenda = Convert.ToDecimal(txtQuantidade.Text) * Convert.ToDecimal(txtPrecoUnitario.Text);

            txtValorTotal.Text = valorVenda.ToString();
        }

        // Botão de Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Botão de Guardar a alteração da Venda
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string vendedor = comboVendedores.Text;
            string produto = comboProdutos.Text;
            string zona = comboZonas.Text;
            string dataVenda = dataVendaCalendario.SelectionStart.ToString("yyyy-MM-dd");
            string quantidade = txtQuantidade.Text;
            string valorVenda = txtValorTotal.Text;
            string precoUnitario = txtPrecoUnitario.Text;

            // Verifica se os campos são válida
            if (
                OperacoesGerais.LerInteiroValido(quantidade, 0) ||
                OperacoesGerais.LerStringValida(vendedor) ||
                OperacoesGerais.LerStringValida(zona) ||
                OperacoesGerais.LerStringValida(produto) ||
                OperacoesGerais.LerInteiroValido(precoUnitario) ||
                OperacoesGerais.LerInteiroValido(valorVenda)
                )
            {
                int codigoVendedor = Vendedores.ObterIdComercial(vendedor);
                string codigoProduto = Produtos.ObterIdProduto(produto);
                int codigoZona = OperacoesGerais.ObterZonaId(zona);
                int idVenda = Convert.ToInt32(privateIdVenda);

                // Altera a venda na base de dados
                Vendas.EditarVenda(codigoProduto, codigoVendedor, codigoZona, dataVenda, quantidade, valorVenda, idVenda);

                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor Preencha os campos corretamente.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        // Atualizar o Valor Total da Venda com base na quantidade
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
