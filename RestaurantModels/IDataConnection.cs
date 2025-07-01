using RestaurantLibrary.Models;
using RestaurantLibrary.Models.HumanChildClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantLibrary
{
    public interface IDataConnection
    {
        CustomerModel LoginChecking (LoginModel model);
        
    }
}
