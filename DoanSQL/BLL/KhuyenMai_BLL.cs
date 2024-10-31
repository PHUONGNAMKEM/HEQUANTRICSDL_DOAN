using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhuyenMai_BLL
    {
        KhuyenMai_DAL DAL = new KhuyenMai_DAL();
        public void login(Login_DTO login)
        {
            DAL.Login(login);
        }
        public List<KhuyenMai_DTO> display()
        {
            return DAL.display();
        }
        public bool them(KhuyenMai_DTO km)
        {
            try
            {
                bool kq = DAL.them(km);
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
        public bool xoa(KhuyenMai_DTO km)
        {
            try
            {
                bool kq = DAL.xoa(km);
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
        public bool sua(KhuyenMai_DTO km)
        {
            try
            {
                bool kq = DAL.sua(km);
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
    }
}
