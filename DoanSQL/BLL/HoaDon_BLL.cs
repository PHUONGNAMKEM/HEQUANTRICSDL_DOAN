using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class HoaDon_BLL
    {
        HoaDon_DAL DAL = new HoaDon_DAL();
        public void login(Login_DTO login)
        {
            DAL.Login(login);
        }
        public List<HoaDon_DTO> display()
        {
            return DAL.display();
        }
        public bool them(HoaDon_DTO hd)
        {
            try
            {
                bool kq = DAL.them(hd);
                if (kq == true)
                {
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool xoa(HoaDon_DTO hd)
        {
            try
            {
                bool kq = DAL.xoa(hd);
                if (kq == true)
                {
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool sua(HoaDon_DTO hd)
        {
            try
            {
                bool kq = DAL.sua(hd);
                if (kq == true)
                {
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public List<KhuyenMai_DTO> getall_makm()
        {
            return DAL.getall_makm();
        }
        public List<NhanVien_DTO> getall_manv()
        {
            return DAL.getall_manv();
        }
        public List<KhachHang_DTO> getall_makh()
        {
            return DAL.getall_makh();
        }
    }
}
