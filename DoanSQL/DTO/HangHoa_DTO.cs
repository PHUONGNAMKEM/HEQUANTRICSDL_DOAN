using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HangHoa_DTO
    {
        private string MaHang;
        private string TenHang;
        private string DVT;
        private string MaLoai;
        private float DoanhThu;
        private float DonGia;
        private string Hinh;
        private string MaHang_OLD;

        public string MaHang_P { get => MaHang; set => MaHang = value; }
        public string TenHang_P { get => TenHang; set => TenHang = value; }
        public string DVT_P { get => DVT; set => DVT = value; }
        public string MaLoai_P { get => MaLoai; set => MaLoai = value; }
        public float DoanhThu_P { get => DoanhThu; set => DoanhThu = value; }
        public string MaHang_OLD_P { get => MaHang_OLD; set => MaHang_OLD = value; }
        public float DonGia_P { get => DonGia; set => DonGia = value; }
        public string Hinh_P { get => Hinh; set => Hinh = value; }

        public HangHoa_DTO(string maHang, string tenHang, string dVT, string maLoai, float dongia, string hinh)
        {
            MaHang_P = maHang;
            TenHang_P = tenHang;
            DVT_P = dVT;
            MaLoai_P = maLoai;
            DonGia_P = dongia;
            Hinh_P = hinh;
        }
        public HangHoa_DTO(string maHang, string tenHang, string dVT, string maLoai, float dongia, string hinh, float doanhthu)
        {
            MaHang_P = maHang;
            TenHang_P = tenHang;
            DVT_P = dVT;
            MaLoai_P = maLoai;
            DoanhThu_P = doanhthu;
            Hinh_P = hinh;
            DonGia_P = dongia;
        }
        public HangHoa_DTO(string mahangold, string maHang, string tenHang, string dVT, string maLoai, float dongia, string hinh)
        {
            MaHang_OLD_P = mahangold;
            MaHang_P = maHang;
            TenHang_P = tenHang;
            DVT_P = dVT;
            MaLoai_P = maLoai;
            DonGia_P = dongia;
            Hinh_P = hinh;
        }

    }
}
