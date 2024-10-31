using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DEAN_SQL
{
    class DatabaseConnection
    {
        public static SqlConnection con;
        public static void InitializeConnection(string connectionString)
        {
            if (con != null)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Dispose();
            }
            con = new SqlConnection(connectionString);
        }

        public static void OpenConnection()
        {
            if (con == null)
                throw new InvalidOperationException("Connection is not initialized.");

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public static void CloseConnection()
        {
            if (con != null && con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

    }
}
