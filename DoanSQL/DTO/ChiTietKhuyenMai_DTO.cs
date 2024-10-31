using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietKhuyenMai_DTO
    {
        private string MaHD;
        private string MaKM;
        private string MaHG;
        private string MaHD_TAM;
        private string MaKM_TAM;
        public string MaHD_P { get => MaHD; set => MaHD = value; }
        public string MaKM_P { get => MaKM; set => MaKM = value; }
        public string MaHG_P { get => MaHG; set => MaHG = value; }
        public string MaHD_TAM_P { get => MaHD_TAM; set => MaHD_TAM = value; }
        public string MaKM_TAM_P{ get => MaKM_TAM; set => MaKM_TAM = value; }

        public ChiTietKhuyenMai_DTO(string mahd, string makm, string mahg)
        {
            MaHD_P = mahd;
            MaKM_P = makm;
            MaHG_P = mahg;
        }
        public ChiTietKhuyenMai_DTO(string mahd, string makm, string mahg, string mahd_tam, string makm_tam)
        {
            MaHD_P = mahd;
            MaKM_P = makm;
            MaHG_P = mahg;
            MaHD_TAM_P= mahd_tam;
            MaKM_TAM_P  = makm_tam;
        }
    }
}
