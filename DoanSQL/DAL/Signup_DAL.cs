using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class Signup_DAL
    {
        SqlConnection connection;
        public void signup(Signup_DTO signup)
        {
            int kq;
            string connectionString = @"Data Source=LAPTOP-H6IDD6F8\SQLEXPRESS;Initial Catalog=DEAN5;Integrated Security=True;Encrypt=False";//Kết nối sql server lưu ý mỗi máy có Source=LAPTOP-H6IDD6F8\SQLEXPRESS khác nhau nên cần xem Source của mình là gì cũng như tên đề án đúng ko
            //string database = "DEAN5";
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //string query = "CREATE_USER" + "";
                //string query = "CREATE LOGIN " + "[" + signup.UserName + "]" + " WITH PASSWORD = '" + signup.Password + "'" + ";USE " + database + ";" + "CREATE USER " + "[" + signup.UserName + "]" + " FOR LOGIN " + "[" + signup.UserName + "]" + ";" + "GRANT SELECT, INSERT, UPDATE, DELETE, EXECUTE TO" + "[" + signup.UserName + "]" + ";";//Ghi câu lệnh giống sql để đưa vào sql chạy
                string query = "EXEC PHANQUYEN_DANGKY '" + signup.UserName + "', '" + signup.Password + "'";
                SqlCommand command = new SqlCommand(query, connection);//Tạo một đối tượng SqlCommand để chứa và thực thi câu lệnh SQL query trong kết nối connection.
                //command.CommandType = CommandType.StoredProcedure;

                ////Thêm tham số @USERNAME và @PASSWORD cho thủ tục CREATE_USER
                //command.Parameters.AddWithValue("@USERNAME", signup.UserName);
                //command.Parameters.AddWithValue("@PASSWORD", signup.Password);
                //command.Parameters.AddWithValue("@DATABASE", database);

                //SqlParameter returnValue = new SqlParameter();
                //returnValue.Direction = ParameterDirection.ReturnValue;
                //command.Parameters.Add(returnValue);

                //command.ExecuteNonQuery();
                //kq = (int)returnValue.Value; // Lấy giá trị trả về từ stored procedure
                kq= command.ExecuteNonQuery();
                connection.Close();

            }
       

        }
    }
}
