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
            var Config = new ConfigurationBuilder().AddUserSecrets<SecretAnchor>().Build();
            GlobalConfig.CnnString = Config["ConnectionStrings:Default"];

            Application.Run(new LoginForm());
        }
    }
}