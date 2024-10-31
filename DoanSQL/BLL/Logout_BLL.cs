using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;


namespace BLL
{
    public class Logout_BLL
    {
        Logout_DAL DAL = new Logout_DAL();
        public void Xoa_phiendangnhap(Logout_DTO logout)
        {
            DAL.Xoa_phiendangnhap(logout);
        }
        public bool timer_logout_Tick(Logout_DTO logout)
        {
            bool kq = DAL.timer_logout_Tick(logout);
            if(kq)
            {
                return true;
            }    
            return false;

        }
    }
}
