using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDon_DTO
    {
        private string MaHD;
        private string MaHG;
        private string SoLuong;
        private string GiaBan;
        private string MaHD_Tam;
        private string MaHG_Tam;

        public string MaHD_P { get => MaHD; set => MaHD = value; }
        public string MaHG_P { get => MaHG; set => MaHG = value; }
        public string SoLuong_P { get => SoLuong; set => SoLuong = value; }
        public string GiaBan_P { get => GiaBan; set => GiaBan = value; }
        public string MaHD_Tam_P { get => MaHD_Tam; set => MaHD_Tam = value; }
        public string MaHG_Tam_P { get => MaHG_Tam; set => MaHG_Tam = value; }

        public ChiTietHoaDon_DTO(string mahd, string mahg, string soluong, string giaban)
        {
            MaHD_P = mahd;
            MaHG_P = mahg;
            SoLuong_P = soluong;
            GiaBan_P = giaban;
        }
        public ChiTietHoaDon_DTO(string mahd, string mahg, string soluong, string giaban, string mahd_tam, string mahg_tam)
        {
            MaHD_P = mahd;
            MaHG_P = mahg;
            SoLuong_P = soluong;
            GiaBan_P = giaban;
            MaHD_Tam_P    = mahd_tam;
            MaHG_Tam_P = mahg_tam;
        }
    }
}
