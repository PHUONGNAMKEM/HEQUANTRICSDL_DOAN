using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        private string MaNV;
        private string TenNV;
        private string ChucVu;
        private string MaQL;
        private string MaNVOLD;

        public string MaNV_P { get => MaNV; set => MaNV = value; }
        public string TenNV_P { get => TenNV; set => TenNV = value; }
        public string ChucVu_P { get => ChucVu; set => ChucVu = value; }
        public string MaQL_P { get => MaQL; set => MaQL = value; }
        public string MaNVOLD_P { get => MaNVOLD; set => MaNVOLD = value; }

        public NhanVien_DTO(string manv, string tennv, string chucvu, string maql)
        {
            MaNV_P = manv;
            TenNV_P = tennv;
            ChucVu_P = chucvu;
            MaQL_P = maql;
        }
        public NhanVien_DTO(string manvold, string manv, string tennv, string chucvu, string maql)
        {
            MaNVOLD_P = manvold;
            MaNV_P = manv;
            TenNV_P = tennv;
            ChucVu_P = chucvu;
            MaQL_P = maql;
        }
    }
}
