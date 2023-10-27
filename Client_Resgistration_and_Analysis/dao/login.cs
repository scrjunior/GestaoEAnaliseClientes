using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoEAnaliseClientes.util;
using MySql.Data.MySqlClient;

namespace GestaoEAnaliseClientes.dao
{
    internal class login
    {
        private MySqlConnection connection;

        public login()
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

        public bool VerificarCredenciais(string usuario, string senha)
        {
            try
            {
                OpenConnection();

                string query = "SELECT COUNT(*) FROM login WHERE usuario = @usuario AND senha = @senha";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    int result = Convert.ToInt32(cmd.ExecuteScalar());

                    return result > 0;
                }
            }
            catch (MySqlException ex)
            {
                
                Console.WriteLine("Erro: " + ex.Message);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }


    }
}
