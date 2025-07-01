using Dapper;
using Microsoft.Data.SqlClient;
using RestaurantLibrary.DataAccess;
using RestaurantLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantLibrary
{
    public class GlobalConfig
    {
        public static string CnnString { get; set; }      
       
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
