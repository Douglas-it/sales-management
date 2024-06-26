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
    public partial class FormEditarProduto : Form
    {
        // Inicializa o FormEditarProduto
        // Recebe dados do produto a ser editado
        public FormEditarProduto(string codigo, string nome, string preco, string nomeCategoria)
        {
            InitializeComponent();

            this.txtCodigo.Text = codigo; // Preenche o campo de código do Produto
            this.txtNome.Text = nome; // Preenche o campo de nome do Produto
            this.txtPreco.Text = preco; // Preenche o campo de preço do Produto

            Produtos.ObterCategorias(comboCategoria); // Preenche o combobox de categorias

            this.comboCategoria.Text = nomeCategoria; // Atribui a categoria do produto ao combobox
        }

        // Botão para guardar as alterações
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtém os valores dos campos
            string codigo = txtCodigo.Text;
            string nome = txtNome.Text;
            string preco = txtPreco.Text;
            decimal precoDecimal = Convert.ToDecimal(preco);
            string categoria = comboCategoria.Text;

            // Verifica se o produto já foi vendido
            if (!Produtos.VerificarProduto(codigo))
            {
                MessageBox.Show("Não é possível editar o produto, pois o mesmo já foi vendido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica se os campos estão preenchidos de forma correta
            if (
                !OperacoesGerais.LerStringValida(codigo) ||
                !OperacoesGerais.LerStringValida(nome) ||
                !OperacoesGerais.LerStringValida(preco)
                )
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lógica para Alterar o Produto
            Produtos.AdicionarProduto(codigo, nome, precoDecimal, categoria);

            this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditarProduto_FormClosed(object sender, FormClosedEventArgs e) { }
        private void FormEditarProduto_Load(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
    }
}
