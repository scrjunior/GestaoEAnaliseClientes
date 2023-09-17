using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Data;
using GestaoEAnaliseClientes.util;
using GestaoEAnaliseClientes.model;


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
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public DataTable GetTestDataFromTestando()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT `Nome`, `Apelido`, `Cliente Tipo` FROM testando;\r\n";

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
                // Handle exceptions here, e.g., log or display an error message.
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return dataTable;
        }

        public void InsertDataIntoTestando(Cliente cliente)
        {
            string query = "INSERT INTO testando (`Nome`, `Apelido`, `Cliente Tipo`) VALUES (@Nome, @apelido, @clietipo)";

            try
            {
                OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@apelido", cliente.Apelido);
                    cmd.Parameters.AddWithValue("@clietipo", cliente.ClienteTipo);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions here, e.g., log or display an error message.
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
