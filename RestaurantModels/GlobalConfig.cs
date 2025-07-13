using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using RestaurantLibrary.DataAccess;
using RestaurantLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration.UserSecrets;


namespace RestaurantLibrary
{
    public class GlobalConfig
    {
        public static string CnnString { get; set; }

        public static string GetConnectionStringFromUserSecret(string StringName, Type AnchorType)
        {
            var config = new ConfigurationBuilder()
            .AddUserSecrets(AnchorType.Assembly, optional: true)            // or any class in your assembly  
            .Build();

            return config[$"ConnectionStrings:{StringName}"]; 
        }
        //But writing like this will create hidden dependency? -> the core of the problem is: classlibrary is referenced by higher up - not itself depend on higher up project like UI - it's not it purpose - it's a load of tool for other projects,... to pull out to use - not it self using anything --> addressed

        public static IDataConnection Connection { get; set; }
        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
        }
    }
}
