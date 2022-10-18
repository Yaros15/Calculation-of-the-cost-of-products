using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTask4
{
    class DBEngine
    {
        private static string connect = "server=localhost;port=3306;username=root;password=root;database=progress;";

        MySqlConnection connection = new MySqlConnection(connect);

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
                Console.WriteLine("База готова к работе");
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                Console.WriteLine("База завершила работу");
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
