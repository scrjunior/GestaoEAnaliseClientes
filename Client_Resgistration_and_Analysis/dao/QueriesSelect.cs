using GestaoEAnaliseClientes.model;
using GestaoEAnaliseClientes.util;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace GestaoEAnaliseClientes.dao
{
    internal class QueriesSelect
    {
        private MySqlConnection connection;

        public QueriesSelect()
        {
            DBConnect db = new DBConnect();
            string connectionString = db.GetConnectionString();
            connection = new MySqlConnection(connectionString);
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

        public DataTable GetTestDataFromTestando()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT c.Nome, c.Apelido, c.`Tipo de Cliente`, c.Região, c.Endereço, s.`Tipo de Serviço`, p.Pacote, p.Tarifa, `Data de Cadastro` " +
                    "FROM clientes c " +
                    "LEFT JOIN clienteserviços cs ON c.ClienteID = cs.ClienteID " +
                    "LEFT JOIN serviços s ON cs.ServiçoID = s.ServiçoID " +
                    "LEFT JOIN clientepacote cp ON c.ClienteID = cp.ClienteID " +
                    "LEFT JOIN pacotes p ON cp.PacoteID = p.PacoteID";

            try
            {
                OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
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

            return dataTable;
        }





    }
}
