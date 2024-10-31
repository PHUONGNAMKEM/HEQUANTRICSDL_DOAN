using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ChiTietHoaDon_DAL
    {
        SqlCommand cmd;
        SqlDataReader read;
        string constr;
        string sql;
        public void Login(Login_DTO login)
        {
            constr = "Server=" + login.Servername + ";Database=" + login.Database + ";User Id=" + login.UserName + ";Password=" + login.Password + ";";
        }
        public List<ChiTietHoaDon_DTO> display()
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            List<ChiTietHoaDon_DTO> lst = new List<ChiTietHoaDon_DTO>();
            sql = @"EXEC HIENTHI_CHITIETHOADON";
            cmd = new SqlCommand(sql, conn);
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                string mahd = read[0].ToString();
                string mahg = read[1].ToString();
                string soluong = read[2].ToString();
                string giaban = read[3].ToString();
                ChiTietHoaDon_DTO hd = new ChiTietHoaDon_DTO(mahd, mahg, soluong, giaban);
                lst.Add(hd);
            }
            conn.Close();
            return lst;
        }
        public string them(ChiTietHoaDon_DTO hd)
        {
            try
            {
                int kq;
                SqlConnection conn = new SqlConnection(constr);
                conn.Open();
                sql = @"EXEC THEM_CHITIETHOADON '" + hd.MaHD_P + "', '" + hd.MaHG_P + "', " + hd.SoLuong_P + ", " + hd.GiaBan_P + "";
                cmd = new SqlCommand(sql, conn);
                kq = cmd.ExecuteNonQuery();
                conn.Close();
                if (kq > 0)
                {
                    return "true";
                }
                return "false";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }     
        }
        public bool xoa(ChiTietHoaDon_DTO hd)
        {
            int kq;
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            //sql = @"EXEC DELETE_KHACHHANG '" + kh.MaKH_P + "'";
            sql = @"EXEC XOA_CHITIETHOADON '" + hd.MaHD_P+ "', '" + hd.MaHG_P + "'";
            cmd = new SqlCommand(sql, conn);
            kq = cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
            {
                return true;
            }
            return false;
        }
        public string sua(ChiTietHoaDon_DTO hd)
        {
            try
            {
                int kq;
                SqlConnection conn = new SqlConnection(constr);
                conn.Open();
                string sql = @"EXEC SUA_CHITIETHOADON '" + hd.MaHD_P + "', '" + hd.MaHG_P + "'," + hd.SoLuong_P + "," + hd.GiaBan_P + ", '" + hd.MaHD_Tam_P + "', '" + hd.MaHG_Tam_P + "'";
                cmd = new SqlCommand(sql, conn);
                kq = cmd.ExecuteNonQuery();
                conn.Close();
                if (kq > 0)
                {
                    return "true";
                }
                return "false";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
         
        }
        public List<HangHoa_DTO> getall_mahang()
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            List<HangHoa_DTO> lst = new List<HangHoa_DTO>();
            sql = @"EXEC DISPLAY_HANGHOA ";
            cmd = new SqlCommand(sql, conn);
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                string mahg = read[0].ToString();
                string tenhg = read[1].ToString();
                string dvt = read[2].ToString();
                string maloai = read[3].ToString();
                float dongia = float.Parse(read[4].ToString());
                string hinh = read[5].ToString();
                HangHoa_DTO hh = new HangHoa_DTO(mahg, tenhg, dvt, maloai, dongia, hinh);
                lst.Add(hh);
            }
            conn.Close();
            return lst;
        }
        public List<HoaDon_DTO> getall_mahoadon()
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
    }
}
