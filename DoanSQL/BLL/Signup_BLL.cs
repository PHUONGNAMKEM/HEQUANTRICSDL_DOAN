using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class Signup_BLL
    {
        Signup_DAL DAL=new Signup_DAL();
        public bool signup(Signup_DTO signup)
        {
            try
            {
                DAL.signup(signup);
                return true; 
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
