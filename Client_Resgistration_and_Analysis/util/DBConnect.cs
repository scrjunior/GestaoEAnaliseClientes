using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace GestaoEAnaliseClientes.util
{
    internal class DBConnect
    {
        private string server;
        private string user;
        private string password;
        private string database;

        public DBConnect(string server = "localhost", string user = "root",
                        string password = "Halix2020.", string database = "clientestm")
        {
            this.server = server;
            this.user = user;
            this.password = password;
            this.database = database;
        }

        public string GetConnectionString()
        {
            return $"Server={server};Database={database};Uid={user};Pwd={password};";
        }
    }
}

