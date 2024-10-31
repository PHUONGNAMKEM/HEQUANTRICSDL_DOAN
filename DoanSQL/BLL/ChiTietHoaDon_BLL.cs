using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class ChiTietHoaDon_BLL
    {
         ChiTietHoaDon_DAL DAL = new ChiTietHoaDon_DAL();
        public void login(Login_DTO login)
        {
            DAL.Login(login);
        }
        public List<ChiTietHoaDon_DTO> display()
        {
            return DAL.display();
        }
        public string them(ChiTietHoaDon_DTO hd)
        {
            try
            {
                string kq = DAL.them(hd);
                if (kq == "true")
                {
                    return "true";
                }
                else return kq;
            }
            catch (Exception ex)
            {
                return "false";
            }

        }
        public bool xoa(ChiTietHoaDon_DTO hd)
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
        public string sua(ChiTietHoaDon_DTO hd)
        {
            try
            {
                string kq = DAL.sua(hd);
                if (kq == "true")
                {
                    return "true";
                }
                else return kq;
            }
            catch (Exception ex)
            {
                return "false";
            }

        }
        public List<HangHoa_DTO> getall_mahang()
        {
            return DAL.getall_mahang();
        }
        public List<HoaDon_DTO> getall_mahoadon()
        {
            return DAL.getall_mahoadon();
        }
    }
}
