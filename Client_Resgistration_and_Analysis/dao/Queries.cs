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

                
                string clientInsertQuery = "INSERT INTO clientes (`Nome`, `Apelido`, `Tipo de Cliente`, `Região`, `Endereço`) VALUES (@Nome, @Apelido, @ClienteTipo, @Região, @Endereço)";
                using (MySqlCommand clientInsertCmd = new MySqlCommand(clientInsertQuery, connection))
                {
                    clientInsertCmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                    clientInsertCmd.Parameters.AddWithValue("@Apelido", cliente.Apelido);
                    clientInsertCmd.Parameters.AddWithValue("@ClienteTipo", cliente.ClienteTipo);
                    clientInsertCmd.Parameters.AddWithValue("@Região", cliente.Região);
                    clientInsertCmd.Parameters.AddWithValue("@Endereço", cliente.Endereço);

                    
                    clientInsertCmd.ExecuteNonQuery();

                    
                    long clienteID = clientInsertCmd.LastInsertedId;

                    
                    long serviçoID = LookupServiçoIDByName(serviceName);
                    long pacoteID = LookupPacoteIDByName(packageName);

                    
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


        public void UpdateDataInTestando(long clienteID, Cliente updatedCliente, string serviceName, string packageName)
        {
            MySqlTransaction transaction = null;

            try
            {
                OpenConnection();

                
                transaction = connection.BeginTransaction();

                
                string clientUpdateQuery = "UPDATE clientes SET Nome = @Nome, Apelido = @Apelido, `Tipo de Cliente` = @ClienteTipo, Região = @Região, Endereço = @Endereço WHERE ClienteID = @ClienteID";
                using (MySqlCommand clientUpdateCmd = new MySqlCommand(clientUpdateQuery, connection))
                {
                    clientUpdateCmd.Parameters.AddWithValue("@Nome", updatedCliente.Nome);
                    clientUpdateCmd.Parameters.AddWithValue("@Apelido", updatedCliente.Apelido);
                    clientUpdateCmd.Parameters.AddWithValue("@ClienteTipo", updatedCliente.ClienteTipo);
                    clientUpdateCmd.Parameters.AddWithValue("@Região", updatedCliente.Região);
                    clientUpdateCmd.Parameters.AddWithValue("@Endereço", updatedCliente.Endereço);
                    clientUpdateCmd.Parameters.AddWithValue("@ClienteID", clienteID);

                    
                    clientUpdateCmd.ExecuteNonQuery();
                }

                
                string updateServiçosQuery = "UPDATE clienteserviços SET ServiçoID = @ServiçoID WHERE ClienteID = @ClienteID";
                using (MySqlCommand updateServiçosCmd = new MySqlCommand(updateServiçosQuery, connection))
                {
                    updateServiçosCmd.Parameters.AddWithValue("@ServiçoID", LookupServiçoIDByName(serviceName));
                    updateServiçosCmd.Parameters.AddWithValue("@ClienteID", clienteID);
                    updateServiçosCmd.ExecuteNonQuery();
                }

                string updatePacotesQuery = "UPDATE clientepacote SET PacoteID = @PacoteID WHERE ClienteID = @ClienteID";
                using (MySqlCommand updatePacotesCmd = new MySqlCommand(updatePacotesQuery, connection))
                {
                    updatePacotesCmd.Parameters.AddWithValue("@PacoteID", LookupPacoteIDByName(packageName));
                    updatePacotesCmd.Parameters.AddWithValue("@ClienteID", clienteID);
                    updatePacotesCmd.ExecuteNonQuery();
                }

                
                transaction.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show("Something went wrong while updating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                
                transaction?.Rollback();
            }
            finally
            {
                CloseConnection();
            }
        }


        
        private long LookupServiçoIDByName(string serviceName)
        {
            string query = "SELECT ServiçoID FROM serviços WHERE `Tipo de Serviço` = @ServiceName";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@ServiceName", serviceName);
                return Convert.ToInt64(cmd.ExecuteScalar());
            }
        }

        
        private long LookupPacoteIDByName(string packageName)
        {
            string query = "SELECT PacoteID FROM pacotes WHERE Pacote = @PackageName";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@PackageName", packageName);
                return Convert.ToInt64(cmd.ExecuteScalar());
            }
        }

        public long GetClienteIDByNome(string nome)
        {
            try
            {
                OpenConnection();

                string query = "SELECT ClienteID FROM clientes WHERE Nome = @Nome";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        
                        return Convert.ToInt64(result);
                    }
                    else
                    {
                        
                        
                        throw new Exception("Cliente not found by name: " + nome);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }


    }
}
