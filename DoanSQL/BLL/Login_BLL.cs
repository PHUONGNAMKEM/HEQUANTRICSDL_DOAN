using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Login_BLL
    {
        Login_DAL DAL=new Login_DAL();
        public bool login(Login_DTO login) 
        {
            try
            {
                if(DAL.login(login)==true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
