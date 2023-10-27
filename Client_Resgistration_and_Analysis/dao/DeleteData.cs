using GestaoEAnaliseClientes.util;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;


namespace GestaoEAnaliseClientes.dao
{
    internal class DeleteData
    {
        private MySqlConnection connection;

        public DeleteData()
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

        public bool DeleteClientByName(string clientName)
        {
            try
            {
                OpenConnection();

                
                string deleteQuery = "DELETE FROM clientes WHERE Nome = @ClientName";
                using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@ClientName", clientName);
                    cmd.ExecuteNonQuery();
                }

                
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show("Failed to delete the client.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
            finally
            {
                CloseConnection();
            }
        }


    }
}
