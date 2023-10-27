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
            ExibirClientesPorPacote();
            ExibirClientesPorRegiao();
        }


        private void dashboard_Load(object sender, EventArgs e)
        {
            
            ExibirTotalClientes();
            

        }

        private void ExibirClientesPorRegiao()
        {
            
            Analisando analisando = new Analisando();

            try
            {
                
                analisando.OpenConnection();

                
                var regiaoClientes = analisando.GetClientesPorRegiao();

                
                SeriesCollection seriesCollection = new SeriesCollection();

                foreach (var regiaoCliente in regiaoClientes)
                {
                    seriesCollection.Add(new ColumnSeries
                    {
                        Title = regiaoCliente.Regiao,
                        Values = new ChartValues<int> { regiaoCliente.ClienteCount },
                        DataLabels = true 
                    });
                }

                
                cartesianChart3.Series = seriesCollection;

                
                cartesianChart3.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Região",
                    
                    
                    Separator = new LiveCharts.Wpf.Separator(), 
                    FontSize = 14 
                });

                cartesianChart3.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Número de Clientes",
                    
                    Separator = new LiveCharts.Wpf.Separator(), 
                    FontSize = 14 
                });

            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                
                analisando.CloseConnection();
            }
        }


        private void ExibirClientesPorPacote()
        {
            
            Analisando analisando = new Analisando();

            try
            {
                
                analisando.OpenConnection();

                
                var pacoteClientes = analisando.GetClientesPorPacote();

                
                SeriesCollection seriesCollection = new SeriesCollection();

                foreach (var pacoteCliente in pacoteClientes)
                {
                    seriesCollection.Add(new ColumnSeries
                    {
                        Title = pacoteCliente.Pacote,
                        Values = new ChartValues<int> { pacoteCliente.ClienteCount },
                        DataLabels = true 
                    });
                }

                
                cartesianChart2.Series = seriesCollection;

                
                cartesianChart2.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Pacote",
                    Separator = new LiveCharts.Wpf.Separator(), 
                    FontSize = 14 
                });

                cartesianChart2.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Número de Clientes",
                    Separator = new LiveCharts.Wpf.Separator(), 
                    FontSize = 14 
                });
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                
                analisando.CloseConnection();
            }
        }



        private void ExibirClientesPorServico()
        {
            
            Analisando analisando = new Analisando();

            try
            {
                
                analisando.OpenConnection();

                
                var servicoClientes = analisando.GetClientesPorServico();

                
                SeriesCollection seriesCollection = new SeriesCollection();

                foreach (var servicoCliente in servicoClientes)
                {
                    seriesCollection.Add(new ColumnSeries
                    {
                        Title = servicoCliente.Servico,
                        Values = new ChartValues<int> { servicoCliente.ClienteCount },
                        DataLabels = true 
                    });
                }

                
                cartesianChart1.Series = seriesCollection;

                
                cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Serviço",
                    Separator = new LiveCharts.Wpf.Separator(), 
                    FontSize = 14 
                });

                cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Número de Clientes",
                    Separator = new LiveCharts.Wpf.Separator(), 
                    FontSize = 14 
                });
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                
                analisando.CloseConnection();
            }
        }





        private void ExibirTotalClientes()
        {
            
            Analisando analisando = new Analisando();

            try
            {
                
                analisando.OpenConnection();

                
                int totalClientes = analisando.GetTotalClientes();

                
                ctotal.Text = "" + totalClientes;
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                
                analisando.CloseConnection();
            }
        }


        private void ExibirTotalTarifas()
        {
            
            Analisando analisando = new Analisando();

            try
            {
                
                analisando.OpenConnection();

                
                decimal totalTarifas = analisando.GetTotalTarifas();

                
                string totalTarifasFormatado = totalTarifas.ToString("0.00") + " mzn";

                
                ttarifa.Text = totalTarifasFormatado;
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                
                analisando.CloseConnection();
            }


        }


        private void ExibirTicketMedio()
        {
            
            Analisando analisando = new Analisando();

            try
            {
                
                analisando.OpenConnection();

                
                decimal ticketMedio = analisando.GetTicketMedioTarifa();

                
                string ticketMedioFormatado = ticketMedio.ToString("0.00") + " mzn";

                
                tmedio.Text = ticketMedioFormatado;
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                
                analisando.CloseConnection();
            }
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            //checkbox
        }


    }
}
