using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace TicTacToe.Data
{
    public class DbContext
    {
        // select
        public static DataTable Select(string cmdText, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand selectCmd = new SqlCommand(cmdText, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(selectCmd);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }


        // NonQuery
        // insert , update , delete
        public static int ExecuteNonQuery(string cmdText, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(cmdText, connection);

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
    }
}

