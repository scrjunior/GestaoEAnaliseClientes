using GestaoEAnaliseClientes.model;
using GestaoEAnaliseClientes.util;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace GestaoEAnaliseClientes.dao
{
    internal class Queries
    {
        private MySqlConnection connection;

        public Queries()
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



        public void InsertDataIntoTestando(Cliente cliente, string serviceName, string packageName)
        {
            try
            {
                OpenConnection();

                // Step 1: Insert client data into the 'clientes' table
                string clientInsertQuery = "INSERT INTO clientes (`Nome`, `Apelido`, `clienteTipo`, `Região`, `Endereço`) VALUES (@Nome, @Apelido, @ClienteTipo, @Região, @Endereço)";
                using (MySqlCommand clientInsertCmd = new MySqlCommand(clientInsertQuery, connection))
                {
                    clientInsertCmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                    clientInsertCmd.Parameters.AddWithValue("@Apelido", cliente.Apelido);
                    clientInsertCmd.Parameters.AddWithValue("@ClienteTipo", cliente.ClienteTipo);
                    clientInsertCmd.Parameters.AddWithValue("@Região", cliente.Região);
                    clientInsertCmd.Parameters.AddWithValue("@Endereço", cliente.Endereço);

                    // Execute the client insertion query
                    clientInsertCmd.ExecuteNonQuery();

                    // Get the generated ClienteID
                    long clienteID = clientInsertCmd.LastInsertedId;

                    // Step 2: Lookup ServiçoID and PacoteID by name
                    long serviçoID = LookupServiçoIDByName(serviceName);
                    long pacoteID = LookupPacoteIDByName(packageName);

                    // Step 3: Insert associations into the 'clienteserviços' and 'clientepacote' tables
                    string serviçoInsertQuery = "INSERT INTO clienteserviços (ClienteID, ServiçoID) VALUES (@ClienteID, @ServiçoID)";
                    using (MySqlCommand serviçoInsertCmd = new MySqlCommand(serviçoInsertQuery, connection))
                    {
                        serviçoInsertCmd.Parameters.AddWithValue("@ClienteID", clienteID);
                        serviçoInsertCmd.Parameters.AddWithValue("@ServiçoID", serviçoID);
                        serviçoInsertCmd.ExecuteNonQuery();
                    }

                    string pacoteInsertQuery = "INSERT INTO clientepacote (ClienteID, PacoteID) VALUES (@ClienteID, @PacoteID)";
                    using (MySqlCommand pacoteInsertCmd = new MySqlCommand(pacoteInsertQuery, connection))
                    {
                        pacoteInsertCmd.Parameters.AddWithValue("@ClienteID", clienteID);
                        pacoteInsertCmd.Parameters.AddWithValue("@PacoteID", pacoteID);
                        pacoteInsertCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show("Alguma coisa não tá batendo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }


        // Helper function to look up ServiçoID by name
        private long LookupServiçoIDByName(string serviceName)
        {
            string query = "SELECT ServiçoID FROM serviços WHERE `Tipo de Serviço` = @ServiceName";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@ServiceName", serviceName);
                return Convert.ToInt64(cmd.ExecuteScalar());
            }
        }

        // Helper function to look up PacoteID by name
        private long LookupPacoteIDByName(string packageName)
        {
            string query = "SELECT PacoteID FROM pacotes WHERE Pacote = @PackageName";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@PackageName", packageName);
                return Convert.ToInt64(cmd.ExecuteScalar());
            }
        }
    }
}
