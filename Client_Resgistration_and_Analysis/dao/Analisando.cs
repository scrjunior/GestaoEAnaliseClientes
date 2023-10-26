using GestaoEAnaliseClientes.model;
using GestaoEAnaliseClientes.util;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEAnaliseClientes.dao
{
    internal class Analisando
    {

        private MySqlConnection connection;

        public Analisando()
        {
            DBConnect db = new DBConnect();
            string connectionString = db.GetConnectionString();
            connection = new MySqlConnection(connectionString);
        }

        public class ServicoCliente
        {
            public string Servico { get; set; }
            public int ClienteCount { get; set; }
            public string Regiao { get; set; }
        }

        public void OpenConnection()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public int GetTotalClientes()
        {
            int totalClientes = 0;
            string query = "SELECT COUNT(*) FROM clientes";

            try
            {
                OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        totalClientes = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return totalClientes;
        }

        public decimal GetTotalTarifas()
        {
            decimal totalTarifas = 0;
            string query = "SELECT SUM(p.Tarifa) " +
                           "FROM clientes c " +
                           "LEFT JOIN clientepacote cp ON c.ClienteID = cp.ClienteID " +
                           "LEFT JOIN pacotes p ON cp.PacoteID = p.PacoteID";

            try
            {
                OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        totalTarifas = Convert.ToDecimal(result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return totalTarifas;
        }

        public decimal GetTicketMedioTarifa()
        {
            decimal ticketMedio = 0;
            int totalClientes = GetTotalClientes();
            decimal totalTarifas = GetTotalTarifas();

            if (totalClientes > 0)
            {
                ticketMedio = totalTarifas / totalClientes;
            }

            return ticketMedio;
        }


        public List<ServicoCliente> GetClientesPorServico()
        {
            List<ServicoCliente> servicoClientes = new List<ServicoCliente>();

            string query = "SELECT s.`Tipo de Serviço` AS Servico, COUNT(cs.ClienteServiçoID) AS ClienteCount " +
                           "FROM serviços s " +
                           "LEFT JOIN clienteserviços cs ON s.ServiçoID = cs.ServiçoID " +
                           "GROUP BY s.ServiçoID";

            try
            {
                OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ServicoCliente servicoCliente = new ServicoCliente
                        {
                            Servico = reader["Servico"].ToString(),
                            ClienteCount = Convert.ToInt32(reader["ClienteCount"])
                        };
                        servicoClientes.Add(servicoCliente);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return servicoClientes;
        }

        public class PacoteCliente
        {
            public string Pacote { get; set; }
            public int ClienteCount { get; set; }
        }


        public List<PacoteCliente> GetClientesPorPacote()
        {
            List<PacoteCliente> pacoteClientes = new List<PacoteCliente>();

            string query = "SELECT p.Pacote AS Pacote, COUNT(cp.ClientePacoteID) AS ClienteCount " +
                           "FROM pacotes p " +
                           "LEFT JOIN clientepacote cp ON p.PacoteID = cp.PacoteID " +
                           "GROUP BY p.PacoteID";

            try
            {
                OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PacoteCliente pacoteCliente = new PacoteCliente
                        {
                            Pacote = reader["Pacote"].ToString(),
                            ClienteCount = Convert.ToInt32(reader["ClienteCount"])
                        };
                        pacoteClientes.Add(pacoteCliente);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return pacoteClientes;
        }

        public List<ServicoCliente> GetClientesPorRegiao()
        {
            List<ServicoCliente> regiaoClientes = new List<ServicoCliente>();

            string query = "SELECT c.Região AS Região, COUNT(c.ClienteID) AS ClienteCount " +
                           "FROM clientes c " +
                           "GROUP BY c.Região";

            try
            {
                OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ServicoCliente regiaoCliente = new ServicoCliente
                        {
                            Regiao = reader["Região"].ToString(),
                            ClienteCount = Convert.ToInt32(reader["ClienteCount"])
                        };
                        regiaoClientes.Add(regiaoCliente);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return regiaoClientes;
        }


    }
}
