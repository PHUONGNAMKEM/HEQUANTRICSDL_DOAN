using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhachHang_DAL
    {
        SqlCommand cmd;
        SqlDataReader read;
        string constr;
        string sql;
        public void Login(Login_DTO login)
        {
            constr = "Server=" + login.Servername + ";Database=" + login.Database + ";User Id=" + login.UserName + ";Password=" + login.Password + ";";
        }
        public List<KhachHang_DTO> display()
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            List<KhachHang_DTO> lst = new List<KhachHang_DTO>();
            sql = @"EXEC DISPLAY_KHACHHANG";
            cmd = new SqlCommand(sql, conn);
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                string makh = read[0].ToString();
                string tenkh = read[1].ToString();
                string diachi = read[2].ToString();
                string sdt = read[3].ToString();
                KhachHang_DTO kh = new KhachHang_DTO(makh, tenkh, diachi, sdt);
                lst.Add(kh);
            }
            conn.Close();
            return lst;
        }
        public bool them(KhachHang_DTO kh)
        {
            int kq;
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            sql = @"EXEC INSERT_KHACHHANG " + "N'" + kh.TenKH_P + "', N'" + kh.DiaChi_P + "', '" + kh.SDT_P + "'";
            cmd = new SqlCommand(sql, conn);
            kq = cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
            {
                return true;
            }
            return false;
        }
        public bool xoa(KhachHang_DTO kh)
        {
            int kq;
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            sql = @"EXEC DELETE_KHACHHANG '" + kh.MaKH_P + "'";
            cmd = new SqlCommand(sql, conn);
            kq = cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
            {
                return true;
            }
            return false;
        }
        public bool sua(KhachHang_DTO kh)
        {
            int kq;
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            sql = @"EXEC UPDATE_KHACHHANG '" + kh.MaKHOLD_P + "', N'" + kh.TenKH_P + "', N'" + kh.DiaChi_P + "', '" + kh.SDT_P + "'";
            cmd = new SqlCommand(sql, conn);
            kq = cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
            {
                return true;
            }
            return false;
        }
        public string rank(KhachHang_DTO kh)
        {
            SqlConnection conn = new SqlConnection(constr);
            float tongtien = 0;
            string rank;
            string maKhach = kh.MaKH_P; // Giả sử đây là mã khách hàng bạn muốn truyền vào

            // Mở kết nối đến SQL Server
            conn.Open();

            // Khởi tạo SqlCommand và đặt thủ tục cần gọi
            SqlCommand cmd = new SqlCommand("P_GETLOAIKH", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Khai báo tham số đầu vào @ma_khach
            SqlParameter inputMaKhach = new SqlParameter();
            inputMaKhach.ParameterName = "@ma_khach";
            inputMaKhach.SqlDbType = SqlDbType.NVarChar;
            inputMaKhach.Size = 50; // Đặt kích thước nếu cần
            inputMaKhach.Value = maKhach; // Gán giá trị cho tham số

            // Khai báo tham số OUTPUT tổng tiền trong C#
            SqlParameter outputmoney = new SqlParameter();
            outputmoney.ParameterName = "@tong_chi_tieu";
            outputmoney.SqlDbType = SqlDbType.Float;
            outputmoney.Direction = ParameterDirection.Output;

            // Khai báo tham số OUTPUT loại hàng trong C#
            SqlParameter outputrank = new SqlParameter();
            outputrank.ParameterName = "@rank";
            outputrank.SqlDbType = SqlDbType.NVarChar;
            outputrank.Size = 50; // Đặt kích thước nếu cần
            outputrank.Direction = ParameterDirection.Output;

            // Thêm tham số đầu vào và OUTPUT vào SqlCommand
            cmd.Parameters.Add(inputMaKhach); // Thêm tham số @ma_khach
            cmd.Parameters.Add(outputmoney);
            cmd.Parameters.Add(outputrank);

            // Thực thi thủ tục
            cmd.ExecuteNonQuery();

            // Lấy giá trị của tham số OUTPUT
            tongtien = Convert.ToSingle(cmd.Parameters["@tong_chi_tieu"].Value); // Sử dụng Convert.ToSingle()
            rank = (string)cmd.Parameters["@rank"].Value;

            return "Tổng tiền khách hàng đã mua: " + tongtien.ToString() + "\n" + "Hạng của khách hàng: " + rank;
        }
    }
}
