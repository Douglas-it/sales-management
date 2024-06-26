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
    public partial class FormEditarVendedores : Form
    {
        private void EditarComercial(string id, string nome, decimal comissao)
        {
            try
            {
                // Inicializar a classe DatabaseHelper
                DatabaseHelper dbHelper = new DatabaseHelper();

                // Query para selecionar o utilizador
                string selectQuery = "UPDATE Vendedores SET nome = @nomeComercial, comissao = @comissaoComercial WHERE codigo = @codigoComercial";

                // Parâmetros para a query
                SqlParameter param1 = new SqlParameter("@nomeComercial", SqlDbType.VarChar) { Value = nome };
                SqlParameter param2 = new SqlParameter("@comissaoComercial", SqlDbType.Decimal) { Value = comissao };
                SqlParameter param3 = new SqlParameter("@codigoComercial", SqlDbType.VarChar) { Value = id };

                // Obter o resultado da query
                dbHelper.ExecuteQuery(selectQuery, param1, param2, param3);

                MessageBox.Show("O comercial foi atualizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar atualizar o comercial: " + ex.Message);
            }
        }

        public FormEditarVendedores(string id, string nome, string comissao)
        {
            InitializeComponent();

            this.txtCodigo.Text = id;
            this.txtNome.Text = nome;
            this.txtComissao.Text = comissao;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string id = txtCodigo.Text;
            string nome = txtNome.Text;
            string comissao = txtComissao.Text;

            if (!OperacoesGerais.LerStringValida(nome) || !OperacoesGerais.LerStringValida(comissao))
            {
                MessageBox.Show("Por favor, introduza os dados corretos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal comissaoEmDecimal = Convert.ToDecimal(comissao);

            EditarComercial(id, nome, comissaoEmDecimal);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
