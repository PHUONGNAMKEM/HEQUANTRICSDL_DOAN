using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhuyenMai_DAL
    {
        SqlCommand cmd;
        SqlDataReader read;
        string constr;
        string sql;
        public void Login(Login_DTO login)
        {
            constr = "Server=" + login.Servername + ";Database=" + login.Database + ";User Id=" + login.UserName + ";Password=" + login.Password + ";";
        }
        public List<KhuyenMai_DTO> display()
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            List<KhuyenMai_DTO> lst = new List<KhuyenMai_DTO>();
            sql = @"EXEC DISPLAY_KHUYENMAI";
            cmd = new SqlCommand(sql, conn);
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                string makm = read[0].ToString();
                string tenkm = read[1].ToString();
                string dieukien = read[2].ToString();
                string giamgia = read[3].ToString();
                string mota = read[4].ToString();
                KhuyenMai_DTO km = new KhuyenMai_DTO(makm, tenkm, dieukien, giamgia, mota);
                lst.Add(km);
            }
            conn.Close();
            return lst;
        }
        public bool them(KhuyenMai_DTO km)
        {
            int kq;
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            sql = @"EXEC INSERT_KHUYENMAI N'" + km.TenKM_P + "','" + km.DieuKien_P + "', '" + km.GiamGia_P + "', N'"+km.MoTa_P+"'";
            cmd = new SqlCommand(sql, conn);
            kq = cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
            {
                return true;
            }
            return false;
        }
        public bool xoa(KhuyenMai_DTO km)
        {
            int kq;
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            //sql = @"EXEC DELETE_KHACHHANG '" + kh.MaKH_P + "'";
            sql = @"EXEC DELETE_KHUYENMAI '" + km.MaKM_P + "'";
            cmd = new SqlCommand(sql, conn);
            kq = cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
            {
                return true;
            }
            return false;
        }
        public bool sua(KhuyenMai_DTO km)
        {
            int kq;
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            string sql = @"EXEC UPDATE_KHUYENMAI " + "N'" + km.MaKM_P + "', N'" + km.TenKM_P + "', '" + km.DieuKien_P + "', '" + km.GiamGia_P + "', '"+km.MoTa_P+"'";
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
