using Microsoft.Extensions.Configuration;
using System.Configuration;
using RestaurantLibrary;
namespace RestaurantAppUI
{
    public class SecretAnchor { };
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GlobalConfig.InitializeConnections(DatabaseType.Sql);
            GlobalConfig.CnnString = GlobalConfig.GetConnectionStringFromUserSecret("Default", typeof(Program));
            Application.Run(new LoginForm());
            //Here's a new line!
        }
    }
}