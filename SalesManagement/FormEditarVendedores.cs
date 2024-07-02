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

            // Verifica se os campos estão preenchidos de forma correta
            if (!OperacoesGerais.LerStringValida(nome) || !OperacoesGerais.LerStringValida(comissao))
            {
                MessageBox.Show("Por favor, introduza os dados corretos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Converte a comissão para decimal
            decimal comissaoEmDecimal = Convert.ToDecimal(comissao);

            // Edita o comercial
            bool editado = Vendedores.EditarComercial(id, nome, comissaoEmDecimal);

            // Verifica se o comercial foi editado com sucesso
            if (editado)
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
