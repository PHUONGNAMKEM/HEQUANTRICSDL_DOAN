using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class KhachHangView_BLL
    {
        KhachHangView_DAL DAL = new KhachHangView_DAL();
        public void login(Login_DTO login)
        {
            DAL.Login(login);
        }
        public List<KhachHang_DTO> display()
        {
            return DAL.display();
        }
        public bool them(KhachHang_DTO kh)
        {
            try
            {
                bool kq = DAL.them(kh);
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
        public bool xoa(KhachHang_DTO kh)
        {
            try
            {
                bool kq = DAL.xoa(kh);
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
        public bool sua(KhachHang_DTO kh)
        {
            try
            {
                bool kq = DAL.sua(kh);
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
        public string rank(KhachHang_DTO kh)
        {
            return DAL.rank(kh);
        }
    }
}
