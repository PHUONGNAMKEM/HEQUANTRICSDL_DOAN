using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HangHoa_BLL
    {
        HangHoa_DAL DAL = new HangHoa_DAL();
        public void login(Login_DTO login)
        {
            DAL.Login(login);
        }
        public List<LoaiHang_DTO> getall_mahang()
        {
            return DAL.getall_mahang();
        }
        public List<HangHoa_DTO> display()
        {
            return DAL.display();
        }
        public List<HangHoa_DTO> display_1()
        {
            return DAL.display_1();
        }
        public List<HangHoa_DTO> display_2()
        {
            return DAL.display_2();
        }
        public bool them(HangHoa_DTO hang)
        {
            try
            {
                bool kq = DAL.them(hang);
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
        public bool xoa(HangHoa_DTO hang)
        {
            try
            {
                bool kq = DAL.xoa(hang);
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
        public bool sua(HangHoa_DTO hang)
        {
            try
            {
                bool kq = DAL.sua(hang);
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
        public List<HangHoa_DTO> search(string name, string giadau, string giacuoi)
        {
            return DAL.search(name, giadau, giacuoi);
        }
    }
}
