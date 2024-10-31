using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Microsoft.SqlServer.Server;

namespace DAL
{
    public class Logout_DAL
    {
        public SqlConnection conn;
        public string connString;
        public void Xoa_phiendangnhap(Logout_DTO logout)
        {
            connString = "Server=" + logout.Servername + ";Database=" + logout.Database + ";User Id=" + logout.UserName + ";Password=" + logout.Password + ";";
            // Đảm bảo kết nối mở trước khi thực hiện lệnh
            conn = new SqlConnection(connString);
            conn.Open();

            //string query = "DELETE FROM UserSessions WHERE UserID = @UserID";
            string query = "EXEC DELETE_ALL_USERNAME_IN_USERSESSIONS '" + logout.UserName + "'";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UserID", logout.UserName);
                cmd.ExecuteNonQuery();
            }
        }
        public bool timer_logout_Tick(Logout_DTO logout)
        {
            connString = "Server=" + logout.Servername + ";Database=" + logout.Database + ";User Id=" + logout.UserName + ";Password=" + logout.Password + ";";
            conn = new SqlConnection(connString);
            conn.Open();
            //string query = "SELECT * FROM UserSessions WITH (NOLOCK) WHERE UserID = @UserID";
            string query = "SELECT * FROM dbo.GET_USER_ID('" + logout.UserName + "')"; //SỬ DỤNG HÀM Ở ĐÂY!
            using (SqlDataAdapter sda = new SqlDataAdapter(query, conn))
            {
                sda.SelectCommand.Parameters.AddWithValue("@UserID", logout.UserName);
                DataTable dTable = new DataTable();
                sda.Fill(dTable);
                if (dTable.Rows.Count == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
