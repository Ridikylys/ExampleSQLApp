using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSQLApp
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("server=f0486325.xsph.ru;port=3306;username=f0486325_binance-bot;password=Avifors1921680120;database=f0486325_binance-bot");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
