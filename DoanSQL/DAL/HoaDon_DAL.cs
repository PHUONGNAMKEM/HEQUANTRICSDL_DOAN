using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class HoaDon_DAL
    {
        SqlCommand cmd;
        SqlDataReader read;
        string constr;
        string sql;
        public void Login(Login_DTO login)
        {
            constr = "Server=" + login.Servername + ";Database=" + login.Database + ";User Id=" + login.UserName + ";Password=" + login.Password + ";";
        }
        public List<HoaDon_DTO> display()
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            List<HoaDon_DTO> lst = new List<HoaDon_DTO>();
            sql = @"EXEC HIENTHI_HOADON";
            cmd = new SqlCommand(sql, conn);
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                string mahd = read[0].ToString();
                string ngaylap = read[1].ToString();
                string trangthai = read[2].ToString();
                string makh = read[3].ToString();
                string manv = read[4].ToString();
                HoaDon_DTO hd = new HoaDon_DTO(mahd, ngaylap, trangthai, makh, manv);
                lst.Add(hd);
            }
            conn.Close();
            return lst;
        }
        public bool them(HoaDon_DTO hd)
        {
            int kq;
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            if(hd.MAKH_P=="")
            {
                sql = @"EXEC THEM_HOADON " + "'" + hd.NGAYLAP_P + "', N'" + hd.TRANGTHAI_P + "', NULL, '" + hd.MANV_P + "'";

            }
            else
            {
                sql = @"EXEC THEM_HOADON " + "'" + hd.NGAYLAP_P + "', N'" + hd.TRANGTHAI_P + "', '" + hd.MAKH_P + "', '" + hd.MANV_P + "'";

            }
            cmd = new SqlCommand(sql, conn);
            kq = cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
            {
                return true;
            }
            return false;
        }
        public bool xoa(HoaDon_DTO hd)
        {
            int kq;
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            sql = @"EXEC XOA_HOADON '" + hd.MAHD_P + "'";
            cmd = new SqlCommand(sql, conn);
            kq = cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
            {
                return true;
            }
            return false;
        }
        public bool sua(HoaDon_DTO hd)
        {
            int kq;
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            string sql = @"EXEC SUA_HOADON " + "'" + hd.NGAYLAP_P + "', N'" + hd.TRANGTHAI_P + "', '" + hd.MAKH_P + "', '" + hd.MANV_P + "', '"+hd.MAHD_P+"'";
            cmd = new SqlCommand(sql, conn);
            kq = cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
            {
                return true;
            }
            return false;
        }
        public List<KhuyenMai_DTO> getall_makm()
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            List<KhuyenMai_DTO> lst = new List<KhuyenMai_DTO>();
            sql = @"select * from KHUYENMAI";
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
        public List<NhanVien_DTO> getall_manv()
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            List<NhanVien_DTO> lst = new List<NhanVien_DTO>();
            sql = @"select * from NHANVIEN";
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
        public List<KhachHang_DTO> getall_makh()
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            List<KhachHang_DTO> lst = new List<KhachHang_DTO>();
            sql = @"select * from KHACHHANG";
            cmd = new SqlCommand(sql, conn);
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                string makh = read[0].ToString();
                string tenkh = read[1].ToString();
                string diachi = read[2].ToString();
                string sodt = read[3].ToString();
                KhachHang_DTO kh = new KhachHang_DTO(makh, tenkh, diachi, sodt);
                lst.Add(kh);
            }
            conn.Close();
            return lst;
        }
    }
}
