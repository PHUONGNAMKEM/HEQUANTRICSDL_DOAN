using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang_DTO
    {
        private string MaKH;
        private string TenKH;
        private string DiaChi;
        private string SDT;
        private string MaKHOLD;
        public string MaKH_P { get => MaKH; set => MaKH = value; }
        public string TenKH_P { get => TenKH; set => TenKH = value; }
        public string DiaChi_P { get => DiaChi; set => DiaChi = value; }
        public string SDT_P { get => SDT; set => SDT = value; }
        public string MaKHOLD_P { get => MaKHOLD; set => MaKHOLD = value; }

        public KhachHang_DTO(string makh, string tenkh, string diachi, string sdt)
        {
            MaKH_P = makh;
            TenKH_P = tenkh;
            DiaChi_P = diachi;
            SDT_P = sdt;
        }
        public KhachHang_DTO(string makh_old, string makh, string tenkh, string diachi, string sdt)
        {
            MaKH_P = makh;
            TenKH_P = tenkh;
            DiaChi_P = diachi;
            SDT_P = sdt;
            MaKHOLD_P = makh_old;
        }


    }
}
