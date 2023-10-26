using GestaoEAnaliseClientes.dao;
using GestaoEAnaliseClientes.model;
using LiveCharts;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Windows.Forms;
using SeriesCollection = LiveCharts.SeriesCollection;
using LiveCharts.Wpf;
using System.Windows.Forms.DataVisualization.Charting;
using Series = System.Windows.Forms.DataVisualization.Charting.Series;

namespace GestaoEAnaliseClientes
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
            ExibirTotalClientes();
            ExibirTotalTarifas();
            ExibirTicketMedio();
            ExibirClientesPorServico();
        }


        private void dashboard_Load(object sender, EventArgs e)
        {
            // Atualizar automaticamente o número total de clientes ao carregar o formulário
            ExibirTotalClientes();
            

        }




        private void ExibirClientesPorServico()
        {
            // Create an instance of the Analisando class
            Analisando analisando = new Analisando();

            try
            {
                // Open the database connection
                analisando.OpenConnection();

                // Get the number of clients per service
                var servicoClientes = analisando.GetClientesPorServico();

                // Create data series for the chart
                SeriesCollection seriesCollection = new SeriesCollection();

                foreach (var servicoCliente in servicoClientes)
                {
                    seriesCollection.Add(new ColumnSeries
                    {
                        Title = servicoCliente.Servico,
                        Values = new ChartValues<int> { servicoCliente.ClienteCount },
                        DataLabels = true // Habilita a exibição de rótulos
                    });
                }

                // Create the chart with the data series
                cartesianChart1.Series = seriesCollection;

                // Optionally, configure the appearance of the chart
                cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Serviço"
                });

                cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Número de Clientes"
                });
            }
            catch (Exception ex)
            {
                // Handle exceptions, if necessary
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // Ensure that the connection is closed
                analisando.CloseConnection();
            }
        }





        private void ExibirTotalClientes()
        {
            // Criar uma instância da classe Analisando
            Analisando analisando = new Analisando();

            try
            {
                // Abrir a conexão com o banco de dados
                analisando.OpenConnection();

                // Obter o número total de clientes
                int totalClientes = analisando.GetTotalClientes();

                // Atualizar a label "ctotal" com o número total de clientes
                ctotal.Text = "" + totalClientes;
            }
            catch (Exception ex)
            {
                // Lidar com exceções, se necessário
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // Certificar-se de fechar a conexão
                analisando.CloseConnection();
            }
        }


        private void ExibirTotalTarifas()
        {
            // Criar uma instância da classe Analisando
            Analisando analisando = new Analisando();

            try
            {
                // Abrir a conexão com o banco de dados
                analisando.OpenConnection();

                // Obter a soma das tarifas
                decimal totalTarifas = analisando.GetTotalTarifas();

                // Formatar o total das tarifas para incluir "MZN"
                string totalTarifasFormatado = totalTarifas.ToString("0.00") + " mzn";

                // Atualizar a label ou outro controle com o total de tarifas formatado
                ttarifa.Text = totalTarifasFormatado;
            }
            catch (Exception ex)
            {
                // Lidar com exceções, se necessário
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // Certificar-se de fechar a conexão
                analisando.CloseConnection();
            }


        }


        private void ExibirTicketMedio()
        {
            // Criar uma instância da classe Analisando
            Analisando analisando = new Analisando();

            try
            {
                // Abrir a conexão com o banco de dados
                analisando.OpenConnection();

                // Obter o ticket médio das tarifas
                decimal ticketMedio = analisando.GetTicketMedioTarifa();

                // Formatar o ticket médio para exibir apenas dois dígitos após o ponto decimal
                string ticketMedioFormatado = ticketMedio.ToString("0.00") + " mzn";

                // Atualizar a label ou outro controle com o ticket médio formatado
                tmedio.Text = ticketMedioFormatado;
            }
            catch (Exception ex)
            {
                // Lidar com exceções, se necessário
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // Certificar-se de fechar a conexão
                analisando.CloseConnection();
            }
        }



        
    }
}
