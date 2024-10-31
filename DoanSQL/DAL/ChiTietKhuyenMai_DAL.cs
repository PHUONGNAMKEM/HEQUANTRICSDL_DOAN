using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietKhuyenMai_DAL
    {
        SqlCommand cmd;
        SqlDataReader read;
        string constr;
        string sql;
        public void Login(Login_DTO login)
        {
            constr = "Server=" + login.Servername + ";Database=" + login.Database + ";User Id=" + login.UserName + ";Password=" + login.Password + ";";
        }
        public List<ChiTietKhuyenMai_DTO> display()
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            List<ChiTietKhuyenMai_DTO> lst = new List<ChiTietKhuyenMai_DTO>();
            sql = @"EXEC DISPLAY_CHITIETKHUYENMAI";
            cmd = new SqlCommand(sql, conn);
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                string mahd = read[0].ToString();
                string makm = read[1].ToString();
                string mahg = read[2].ToString();
                ChiTietKhuyenMai_DTO km = new ChiTietKhuyenMai_DTO(mahd, makm, mahg);
                lst.Add(km);
            }
            conn.Close();
            return lst;
        }
        public bool them(ChiTietKhuyenMai_DTO km)
        {
            int kq;
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            sql = @"EXEC INSERT_CHITIETKHUYENMAI '" + km.MaHD_P+ "','" + km.MaKM_P + "', '" + km.MaHG_P + "'";
            cmd = new SqlCommand(sql, conn);
            kq = cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
            {
                return true;
            }
            return false;
        }
        public bool xoa(ChiTietKhuyenMai_DTO km)
        {
            int kq;
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            //sql = @"EXEC DELETE_KHACHHANG '" + kh.MaKH_P + "'";
            sql = @"EXEC DELETE_CHITIETKHUYENMAI '" + km.MaHD_P + "', '"+km.MaKM_P+"'";
            cmd = new SqlCommand(sql, conn);
            kq = cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
            {
                return true;
            }
            return false;
        }
        public bool sua(ChiTietKhuyenMai_DTO km)
        {
            int kq;
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            string sql = @"EXEC UPDATE_CHITIETKHUYENMAI " + "'" + km.MaHD_P + "', N'" + km.MaKM_P + "', '" + km.MaHG_P + "', '" + km.MaHD_TAM_P + "', '" + km.MaKM_TAM_P + "'";
            cmd = new SqlCommand(sql, conn);
            kq = cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
            {
                return true;
            }
            return false;
        }
    }
}
