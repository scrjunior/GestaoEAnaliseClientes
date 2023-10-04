using GestaoEAnaliseClientes.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void dashboard_Load(object sender, EventArgs e)
        {
            // Atualizar automaticamente o número total de clientes ao carregar o formulário
            ExibirTotalClientes();
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


        private void label2_Click(object sender, EventArgs e)
        {

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

        
        


        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
