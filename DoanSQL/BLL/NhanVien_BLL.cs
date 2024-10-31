using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhanVien_BLL
    {
        NhanVien_DAL DAL = new NhanVien_DAL();
        public void login(Login_DTO login)
        {
            DAL.Login(login);
        }
        public List<NhanVien_DTO> display()
        {
            return DAL.display();
        }
        public bool them(NhanVien_DTO nv)
        {
            try
            {
                bool kq = DAL.them(nv);
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
        public bool xoa(NhanVien_DTO nv)
        {
            try
            {
                bool kq = DAL.xoa(nv);
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
        public bool sua(NhanVien_DTO nv)
        {
            try
            {
                bool kq = DAL.sua(nv);
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
