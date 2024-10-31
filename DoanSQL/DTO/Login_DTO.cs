using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Login_DTO
    {
        private string User;
        private string Pass;
        private string Server;
        private string Data;

        public string UserName { get => User; set => User = value; }
        public string Password { get => Pass; set => Pass = value; }
        public string Servername { get => Server; set => Server = value; }
        public string Database { get => Data; set => Data = value; }

        public Login_DTO(string username, string password, string servername, string database) 
        {
            UserName = username;
            Password = password;
            Servername = servername;
            Database = database;
        }

        
    }
}
