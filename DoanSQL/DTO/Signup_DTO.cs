using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Signup_DTO
    {
        private string User;
        private string Pass;
        public string UserName { get => User; set => User = value; }
        public string Password { get => Pass; set => Pass = value; }

        public Signup_DTO(string username, string password)
        {
            UserName = username;
            Password = password;
        }
    }
}
