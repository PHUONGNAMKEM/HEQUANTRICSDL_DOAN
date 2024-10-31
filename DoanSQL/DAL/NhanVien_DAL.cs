using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVien_DAL
    {
        SqlCommand cmd;
        SqlDataReader read;
        string constr;
        string sql;
        public void Login(Login_DTO login)
        {
            constr = "Server=" + login.Servername + ";Database=" + login.Database + ";User Id=" + login.UserName + ";Password=" + login.Password + ";";
        }
        public List<NhanVien_DTO> display()
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            List<NhanVien_DTO> lst = new List<NhanVien_DTO>();
            sql = @"EXEC HIENTHI_NHANVIEN";
            cmd = new SqlCommand(sql, conn);
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                string manv = read[0].ToString();
                string tennv = read[1].ToString();
                string chucvu = read[2].ToString();
                string maql = read[3].ToString();
                NhanVien_DTO nv = new NhanVien_DTO(manv, tennv, chucvu, maql);
                lst.Add(nv);
            }
            conn.Close();
            return lst;
        }
        public bool them(NhanVien_DTO nv)
        {
            int kq;
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            sql = @"EXEC THEM_NHANVIEN N'" + nv.TenNV_P + "', N'" + nv.ChucVu_P + "', '" + nv.MaQL_P + "'";
            cmd = new SqlCommand(sql, conn);
            kq = cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
            {
                return true;
            }
            return false;
        }
        public bool xoa(NhanVien_DTO nv)
        {
            int kq;
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            //sql = @"EXEC DELETE_KHACHHANG '" + kh.MaKH_P + "'";
            sql = @"EXEC XOA_NHANVIEN '" + nv.MaNV_P + "'";
            cmd = new SqlCommand(sql, conn);
            kq = cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
            {
                return true;
            }
            return false;
        }
        public bool sua(NhanVien_DTO nv)
        {
            int kq;
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            string sql = @"EXEC SUA_NHANVIEN "+ "'N'" + nv.TenNV_P + "', N'" + nv.ChucVu_P + "', '" + nv.MaQL_P + "', '" + nv.MaNVOLD_P + "'";
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
