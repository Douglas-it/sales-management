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

            bool eliminado = Vendedores.EditarComercial(id, nome, comissaoEmDecimal);

            if (eliminado)
            {
                MessageBox.Show("O comercial foi atualizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
