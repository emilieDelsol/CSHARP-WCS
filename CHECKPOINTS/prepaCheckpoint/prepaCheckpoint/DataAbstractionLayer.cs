using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace prepaCheckpoint
{
    static class DataAbstractionLayer
    {
        private static SqlConnection _connection = new SqlConnection();

        public static void Open(SqlConnectionStringBuilder stringBuilder)
        {
            _connection.ConnectionString = stringBuilder.ConnectionString;
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public static SqlConnection GetConnection()
        {
            return _connection;
        }
        public static IEnumerable<Drink> SelectAllDrinks()
        {
            SqlCommand command = _connection.CreateCommand();
        }
    }
}