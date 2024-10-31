using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietKhuyenMai_BLL
    {
        ChiTietKhuyenMai_DAL DAL = new ChiTietKhuyenMai_DAL();
        public void login(Login_DTO login)
        {
            DAL.Login(login);
        }
        public List<ChiTietKhuyenMai_DTO> display()
        {
            return DAL.display();
        }
        public bool them(ChiTietKhuyenMai_DTO km)
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
        public bool xoa(ChiTietKhuyenMai_DTO km)
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
        public bool sua(ChiTietKhuyenMai_DTO km)
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
