using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mono.Data.Sqlite;

namespace Services
{
    public class DatabaseService
    {
        public SqliteConnection OpenConnection()
        {
            SqliteConnection connection = new SqliteConnection();
            connection.Open();
            return connection;
        }


    }
}
