using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace SalesManagement
{
    public class BackOffice
    {
        /*
         * Função para obter Vendas por Vendedor
         * @return DataTable
         */
        public static DataTable VendasPorVendedor()
        {
            DataTable resultado = new DataTable(); // Inicia um novo DataTable

            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper(); // Inicializa a classe DatabaseHelper

                // Query para consulta
                string selectQuery = @"
                    SELECT v.Nome AS Vendedor, SUM(vd.ValorVenda) AS TotalVendas 
                    FROM Vendedores v 
                    JOIN Vendas vd ON v.Codigo = vd.CodigoVendedor 
                    GROUP BY v.Nome 
                    ORDER BY TotalVendas DESC";

                // Obtem os resultados
                resultado = dbHelper.GetDataTable(selectQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar vendas: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Retorna os resultados
            return resultado;
        }

        /*
         * Função para obter Vendas por Produto
         * @return DataTable
         */
        public static DataTable VendasPorProduto()
        {
            DataTable resultado = new DataTable(); // Inicia um novo DataTable

            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper(); // Inicializa a classe DatabaseHelper

                // Query para consulta
                string selectQuery = @"
                    SELECT p.Nome AS Produto, SUM(vd.ValorVenda) AS TotalVendas 
                    FROM Produtos p 
                    JOIN Vendas vd ON p.Codigo = vd.CodigoProduto 
                    GROUP BY p.Nome 
                    ORDER BY TotalVendas DESC";

                // Obtem os resultados
                resultado = dbHelper.GetDataTable(selectQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar vendas: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Retorna os resultados
            return resultado;
        }

        /*
         * Função para obter as Vendas por Zona
         * @return DataTable
         */
        public static DataTable VendasPorZona()
        {
            DataTable resultado = new DataTable(); // Inicia um novo DataTable

            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper(); // Inicializa a classe DatabaseHelper

                // Query para consulta
                string selectQuery = "SELECT vd.Zona, SUM(vd.ValorVenda) AS TotalVendas FROM Vendas vd GROUP BY vd.Zona ORDER BY TotalVendas DESC";

                // Obtem os resultados
                resultado = dbHelper.GetDataTable(selectQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar vendas: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Retorna os resultados
            return resultado;
        }

        /*
         * Função para obter Vendas por Mês
         * @return DataTable
         */
        public static DataTable VendasPorMes()
        {
            DataTable resultado = new DataTable(); // Inicia um novo DataTable

            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper(); // Inicializa a classe DatabaseHelper

                // Query para consulta
                string selectQuery = @"
                    SELECT DATENAME(MONTH, vd.DataVenda) AS Mes, SUM(vd.ValorVenda) AS TotalVendas 
                    FROM Vendas vd 
                    GROUP BY DATENAME(MONTH, vd.DataVenda), MONTH(vd.DataVenda) 
                    ORDER BY MONTH(vd.DataVenda)";

                // Obtem os resultados
                resultado = dbHelper.GetDataTable(selectQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar vendas: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Retorna os resultados
            return resultado;
        }

        /*
         * Função para obter Vendas por Mês de cada Vendedor
         * @return DataTable
         */
        public static DataTable VendasPorMesVendedor()
        {
            DataTable resultado = new DataTable(); // Inicia um novo DataTable

            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper(); // Inicializa a classe DatabaseHelper

                // Query para consulta
                string selectQuery = @"
                    SELECT v.Nome AS Vendedor, DATENAME(MONTH, vd.DataVenda) AS Mes, SUM(vd.ValorVenda) AS TotalVendas 
                    FROM Vendedores v 
                    JOIN Vendas vd ON v.Codigo = vd.CodigoVendedor 
                    GROUP BY v.Nome, DATENAME(MONTH, vd.DataVenda), MONTH(vd.DataVenda) 
                    ORDER BY v.Nome, MONTH(vd.DataVenda)";

                // Obtem os resultados
                resultado = dbHelper.GetDataTable(selectQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar vendas: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Retorna os resultados
            return resultado;
        }

        /*
         * Função para obter Vendas por Mês de cada Produto
         * @return DataTable
         */
        public static DataTable VendasPorMesProduto()
        {
            DataTable resultado = new DataTable(); // Inicia um novo DataTable

            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper(); // Inicializa a classe DatabaseHelper

                // Query para consulta
                string selectQuery = @"
                    SELECT p.Nome AS Produto, DATENAME(MONTH, vd.DataVenda) AS Mes, SUM(vd.ValorVenda) AS TotalVendas 
                    FROM Produtos p JOIN Vendas vd ON p.Codigo = vd.CodigoProduto 
                    GROUP BY p.Nome, DATENAME(MONTH, vd.DataVenda), MONTH(vd.DataVenda) 
                    ORDER BY p.Nome, MONTH(vd.DataVenda)";

                // Obtem os resultados
                resultado = dbHelper.GetDataTable(selectQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar vendas: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Retorna os resultados
            return resultado;
        }

        /* Função para preencher um gráfico
         * @param Chart
         * @param DataTable
         * @param nomeCampoX - Nome do campo do eixo do X
         * @param nomeCampoY - nome do campo do eixo do Y 
         * 
         * Referencia: https://www.alura.com.br/artigos/listas-em-csharp
         */
        public static void PreencherGrafico(Chart chart, DataTable dataTable, string nomeCampoX, string nomeCampoY)
        {
            // Limpa séries e áreas existentes no Chart
            chart.Series.Clear();
            chart.ChartAreas.Clear();

            // Adiciona uma nova área de gráfico ao Chart
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            // Configura nomes dos eixos
            chartArea.AxisX.Title = nomeCampoX;
            chartArea.AxisY.Title = nomeCampoY;

            // Lista para manter o controlo de nomes de série já utilizados 
            List<string> listaNomesUsados = new List<string>();

            // Itera sobre cada linha do DataTable e adiciona uma série para cada vendedor
            foreach (DataRow row in dataTable.Rows)
            {
                // Aqui você precisa acessar os valores corretos do DataRow usando os nomes dos campos
                string label = row[nomeCampoX].ToString();
                string value = row[nomeCampoY].ToString();

                // Verifica se o nome já está sendo usado
                int suffix = 1;
                string labelOriginal = label;

                while (listaNomesUsados.Contains(label))
                {
                    label = $"{labelOriginal} ({suffix++})"; // Adiciona um número sequencial ao nome para evitar duplicados
                }

                // Adiciona o nome à lista de usados
                listaNomesUsados.Add(label);

                // Cria uma série para o valor atual
                Series series = new Series
                {
                    Name = label, // Nome da série é o valor do campo X (vendedor)
                    ChartType = SeriesChartType.Column
                };

                // Adiciona um ponto de dados para o valor atual
                series.Points.AddXY(label, value);

                // Adiciona a série ao gráfico
                chart.Series.Add(series);
            }

            chart.DataBind(); // Atualiza o gráfico
        }
    }
}
    