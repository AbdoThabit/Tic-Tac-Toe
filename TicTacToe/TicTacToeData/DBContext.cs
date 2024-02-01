using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace TicTacToe.Data
{
    public class DBContext
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
        public static bool isExited(String cmdString, String connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(cmdString, connection);
            connection.Open();
            object result = cmd.ExecuteScalar();
            connection.Close();
            if (result != null) return true;
            else return false;

        }
        public static int SelectSclaer(string cmdText, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(cmdText, connection);

            connection.Open();
            object result = command.ExecuteScalar();
            connection.Close();
            return Convert.ToInt32(result);
        }
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

