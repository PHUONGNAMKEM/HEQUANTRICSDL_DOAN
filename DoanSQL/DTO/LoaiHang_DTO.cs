using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiHang_DTO
    {
        private string MaLoai;
        private string TenLoai;

        public string MaLoai_P { get => MaLoai; set => MaLoai = value; }
        public string TenLoai_P { get => TenLoai; set => TenLoai = value; }
        public LoaiHang_DTO(string maloai, string tenloai)
        {
            MaLoai_P = maloai;
            TenLoai_P = tenloai;
        }
    }
}
