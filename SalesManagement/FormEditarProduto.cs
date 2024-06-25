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
        public FormEditarProduto(string codigo, string nome, string preco, string categoriaId)
        {
            InitializeComponent();
            this.txtCodigo.Text = codigo;
            this.txtNome.Text = nome;
            this.txtPreco.Text = preco;
            this.comboCategoria.SelectedValue = categoriaId;
        }

        private void FormEditarProduto_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

            if(!VerificarProduto(codigo))
            {
                MessageBox.Show("Não é possível editar o produto, pois o mesmo já foi vendido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lógica para Alterar o Produto

            

            
        }
    }
}
