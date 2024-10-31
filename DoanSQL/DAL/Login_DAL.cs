using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class Login_DAL
    {

        SqlConnection Conn;

        public bool login(Login_DTO login)
        {
            int kq;
            //string connString = "Server=" +txtservername.Text + ";Database=" + txtdatabase.Text + ";User Id=" + User + ";Password=" + Password + ";";
            string connString = "Server=" + login.Servername + ";Database=" + login.Database + ";User Id=" + login.UserName + ";Password=" + login.Password + ";";

            using (Conn = new SqlConnection(connString))
            {
                Conn.Open();
                //string insertSessionQuery = "INSERT INTO UserSessions (UserID) VALUES (@UserID)";
                string insertSessionQuery = "EXEC UserSessions_insert '" + login.UserName + "'";
                using (SqlCommand insertCmd = new SqlCommand(insertSessionQuery, Conn))
                {
                    insertCmd.Parameters.AddWithValue("@UserID", login.UserName);
                    kq=insertCmd.ExecuteNonQuery();
                }
                Conn.Close();
            }
            if (kq > 0)
            {
                return true;
            }
            else return false;
        }
    }
}
