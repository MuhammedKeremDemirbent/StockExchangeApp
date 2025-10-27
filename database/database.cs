using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StockExchangeApp.database
{
    internal class database
    {
        private string baglantibilgileri = "server=localhost;port=3306;database=exchange_app;uid=root;pwd=Beyazpano123;";
        
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(baglantibilgileri);
        }

    }
}
