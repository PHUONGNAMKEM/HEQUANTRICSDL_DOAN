using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class BanHang_DTO
    {
        private string MaHang;
        private string MaHD;
        private string TenHang;
        private string DVT;
        private string MaLoai;
        private float DoanhThu;
        private float DonGia;
        private string Hinh;
        private string MaHang_OLD;
        private int SL;
        private float GiaBan;
        private string MaKM;

        public string MaHang_P { get => MaHang; set => MaHang = value; }
        public string TenHang_P { get => TenHang; set => TenHang = value; }
        public string DVT_P { get => DVT; set => DVT = value; }
        public string MaLoai_P { get => MaLoai; set => MaLoai = value; }
        public float DoanhThu_P { get => DoanhThu; set => DoanhThu = value; }
        public string MaHang_OLD_P { get => MaHang_OLD; set => MaHang_OLD = value; }
        public float DonGia_P { get => DonGia; set => DonGia = value; }
        public string Hinh_P { get => Hinh; set => Hinh = value; }
        public string MaHD_P { get => MaHD; set => MaHD = value; }
        public int SL_P { get => SL; set => SL = value; }
        public float GiaBan_P { get => GiaBan; set => GiaBan = value; }
        public string MaKM_P { get => MaKM; set => MaKM = value; }
        public BanHang_DTO(string tenhang, float dongia, string makm, int sl)
        {
            TenHang_P= tenhang;
            DonGia_P= dongia;
            MaKM_P= makm;
            SL_P = sl;
        }
    }
}
