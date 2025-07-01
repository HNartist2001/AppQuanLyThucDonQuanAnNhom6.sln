using Dapper;
using Microsoft.Data.SqlClient;
using RestaurantLibrary.Models;
using RestaurantLibrary.Models.HumanChildClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantLibrary.DataAccess
{
    internal class SqlConnector:IDataConnection
    {
        public CustomerModel LoginChecking(LoginModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Username", model.LogUserName);
                parameters.Add("@Password", model.LogPassword);

                var result = connection.QueryFirstOrDefault<CustomerModel>("dbo.spUser_Login", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
        }
    }
}
