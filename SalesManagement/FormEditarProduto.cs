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
        public FormEditarProduto(string codigo, string nome, string preco, string nomeCategoria)
        {
            InitializeComponent();

            this.txtCodigo.Text = codigo;
            this.txtNome.Text = nome;
            this.txtPreco.Text = preco;

            Produtos.ObterCategorias(comboCategoria);

            this.comboCategoria.Text = nomeCategoria;
        }

        private void FormEditarProduto_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string nome = txtNome.Text;
            string preco = txtPreco.Text;
            decimal precoDecimal = Convert.ToDecimal(preco);
            string categoria = comboCategoria.Text;

            if (!Produtos.VerificarProduto(codigo))
            {
                MessageBox.Show("Não é possível editar o produto, pois o mesmo já foi vendido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
            try
            {

                DatabaseHelper dbHelper = new DatabaseHelper();

                string updateQuery = "UPDATE produtos SET Nome = @nome, Preco = @preco, CodigoCategoria = @categoria WHERE Codigo = @codigo";

                MessageBox.Show($"{Produtos.ObterIdCategoria(categoria)}");

                SqlParameter paramNome = new SqlParameter("@nome", SqlDbType.VarChar) { Value = nome };
                SqlParameter paramPreco = new SqlParameter("@preco", SqlDbType.Decimal) { Value = precoDecimal };
                SqlParameter paramCategoria = new SqlParameter("@categoria", SqlDbType.VarChar) { Value = Produtos.ObterIdCategoria(categoria) };
                SqlParameter paramCodigo = new SqlParameter("@codigo", SqlDbType.VarChar) { Value = codigo };

                dbHelper.ExecuteQuery(updateQuery, paramNome, paramPreco, paramCategoria, paramCodigo);

                MessageBox.Show("Produto alterado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void FormEditarProduto_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
