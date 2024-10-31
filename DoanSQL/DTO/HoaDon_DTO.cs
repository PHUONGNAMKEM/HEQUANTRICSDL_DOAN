using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon_DTO
    {
        private string MAHD;
        private string NGAYLAP;
        private string TRANGTHAI;
        private string MAKH;
        private string MANV;

        public string MAHD_P { get => MAHD; set => MAHD = value; }
        public string NGAYLAP_P { get => NGAYLAP; set => NGAYLAP = value; }
        public string TRANGTHAI_P { get => TRANGTHAI; set => TRANGTHAI = value; }
        public string MAKH_P { get => MAKH; set => MAKH = value; }
        public string MANV_P { get => MANV; set => MANV = value; }
        public HoaDon_DTO(string mahd, string ngaylap, string trangthai, string makh, string manv)
        {
            MAHD_P = mahd;
            NGAYLAP_P = ngaylap;
            TRANGTHAI_P = trangthai;
            MAKH_P = makh;
            MANV_P = manv;
        }
    }
}
