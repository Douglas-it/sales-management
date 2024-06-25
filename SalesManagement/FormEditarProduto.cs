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
        private void ObterCategorias()
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();
                string selectQuery = "SELECT * FROM categorias";
                DataTable result = dbHelper.GetDataTable(selectQuery);

                foreach (DataRow row in result.Rows)
                    this.comboCategoria.Items.Add(row["Nome"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter as categorias: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ObterIdCategoria(string nomeCategoria)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();
                string selectQuery = "SELECT * FROM categorias WHERE Nome = @nome";
                SqlParameter paramNome = new SqlParameter("@nome", SqlDbType.VarChar) { Value = nomeCategoria };

                DataTable result = dbHelper.GetDataTable(selectQuery, paramNome);

                return result.Rows[0]["Codigo"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter o nome da categoria: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }


        public FormEditarProduto(string codigo, string nome, string preco, string nomeCategoria)
        {
            InitializeComponent();

            this.txtCodigo.Text = codigo;
            this.txtNome.Text = nome;
            this.txtPreco.Text = preco;

            ObterCategorias();

            this.comboCategoria.Text = nomeCategoria;
        }

        private void FormEditarProduto_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private bool VerificarProduto(string codigo)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();
                string selectQuery = "SELECT * FROM vendas WHERE CodigoProduto = @codigo";
                SqlParameter paramCodigo = new SqlParameter("@codigo", SqlDbType.VarChar) { Value = codigo };

                DataTable result = dbHelper.GetDataTable(selectQuery, paramCodigo);

                if (result.Rows.Count > 0)
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar o produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string nome = txtNome.Text;
            string preco = txtPreco.Text;
            decimal precoDecimal = Convert.ToDecimal(preco);
            string categoria = comboCategoria.Text;

            if (!VerificarProduto(codigo))
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

                MessageBox.Show($"{ObterIdCategoria(categoria)}");

                SqlParameter paramNome = new SqlParameter("@nome", SqlDbType.VarChar) { Value = nome };
                SqlParameter paramPreco = new SqlParameter("@preco", SqlDbType.Decimal) { Value = precoDecimal };
                SqlParameter paramCategoria = new SqlParameter("@categoria", SqlDbType.VarChar) { Value = ObterIdCategoria(categoria) };
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
