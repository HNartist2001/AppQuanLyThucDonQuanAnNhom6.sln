using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantLibrary.Models
{
    public class LoginModel
    {
        public string LogUserName { get; set; }
        public string LogPassword { get; set; }

        public LoginModel(string Logusername, string Logpassword) 
        {
            LogUserName = Logusername;
            LogPassword = Logpassword; 
        }
    }
}
