using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhuyenMai_DTO
    {
        private string MaKM;
        private string TenKM;
        private string GiamGia;
        private string DieuKien;
        private string MoTa;

        public string MaKM_P { get => MaKM; set => MaKM = value; }
        public string TenKM_P { get => TenKM; set => TenKM = value; }

        public string DieuKien_P { get => DieuKien; set => DieuKien = value; }
        public string MoTa_P { get => MoTa; set => MoTa = value; }
        public string GiamGia_P { get => GiamGia; set => GiamGia = value; }

        public KhuyenMai_DTO(string makm, string tenkm, string giamgia, string dieukien, string mota) 
        {
            MaKM_P = makm;
            TenKM_P = tenkm;
            GiamGia_P = giamgia;
            DieuKien_P = dieukien;
            MoTa_P = mota;
        }
    }
}
