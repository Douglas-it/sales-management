using System;
using System.Diagnostics.Eventing.Reader;
namespace SalesManagement
{
    public class OperacoesGerais
    {
        /*
         * Função para configurar um DataGridView
         * 
         * @param dataGridView: DataGridView a ser configurado
         * @param nomeColunas: nomes internos das colunas
         * @param nomeColunasVisivel: nomes visíveis das colunas
         * @param colunasReadOnly: array de booleanos para definir se as colunas são editáveis
         * @param botaoEditar: booleano para definir se é adicionado um botão de editar
         * @param botaoEliminar: booleano para definir se é adicionado um botão de eliminar
         */
        public static void ConfigurarDataGridView
            (
                DataGridView dataGridView, 
                string[] nomeColunas, 
                string[] nomeColunasVisivel, 
                bool[] colunasReadOnly, 
                bool botaoEditar, 
                bool botaoEliminar
            )
        {
            // Limpar colunas existentes
            dataGridView.Columns.Clear();

            // Propriedades dataGridView
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Resize automático das colunas
            dataGridView.AllowUserToAddRows = false; // Não permitir adicionar linhas
            dataGridView.AllowUserToDeleteRows = false; // Não permitir eliminar linhas

            // Adicionar colunas (nomes internos e visíveis)
            for (int i = 0; i < nomeColunas.Length; i++)
                dataGridView.Columns.Add(nomeColunas[i], nomeColunasVisivel[i]);

            // Desativar a edição das células
            for (int i = 0; i < colunasReadOnly.Length; i++)
                dataGridView.Columns[i].ReadOnly = colunasReadOnly[i];

            // Adição de botão de Editar
            if (botaoEditar && Globals.admin)
            {
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn(); // Criação de uma nova coluna de botão
                btnEditar.Name = "Editar"; // Nome da coluna
                btnEditar.HeaderText = "Editar"; // Cabeçalho da coluna
                btnEditar.Text = "Editar"; // Texto do botão
                btnEditar.UseColumnTextForButtonValue = true; // Usar o texto da coluna para o botão
                dataGridView.Columns.Add(btnEditar); // Adicionar a coluna à tabela
            }

            // Adição de botão de Eliminar
            if (botaoEliminar && Globals.admin)
            {
                DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                btnEliminar.Name = "Eliminar";
                btnEliminar.HeaderText = "Eliminar";
                btnEliminar.Text = "Eliminar";
                btnEliminar.UseColumnTextForButtonValue = true;
                dataGridView.Columns.Add(btnEliminar);
            }
        }

        /*
         * Função para ler uma string não vazia
         * @param valor: string a ser verificada
         * @return bool: true se a string não for vazia, false caso contrário
         */
        public static bool LerStringValida(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
                return false;

            return true;
        }

        /*
         * Função para ler um inteiro válido dentro do intervalo especificado
         * @param entrada: string a ser verificada
         * @param valorMinimo: valor mínimo do intervalo
         * @param valorMaximo: valor máximo do intervalo
         * @return bool: true se a string for um inteiro válido dentro do intervalo especificado, false caso contrário
         */
        public static bool LerInteiroValido(string entrada, int valorMinimo = int.MinValue, int valorMaximo = int.MaxValue)
        {
            int saida;
            bool valido = int.TryParse(entrada, out saida) && saida >= valorMinimo && saida <= valorMaximo;
            return valido;
        }

        /*
         * Função para ler um número decimal válido dentro do intervalo especificado
         * @param entrada: string a ser verificada
         * @param valorMinimo: valor mínimo do intervalo
         * @param valorMaximo: valor máximo do intervalo
         * @return bool: true se a string for um número decimal válido dentro do intervalo especificado, false caso contrário
         */
        public static bool LerDecimalValido(string entrada, float valorMinimo = float.MinValue, float valorMaximo = float.MaxValue)
        {
            float saida;
            bool valido = float.TryParse(entrada, out saida) && saida >= valorMinimo && saida <= valorMaximo;
            return valido;
        }
    }
}