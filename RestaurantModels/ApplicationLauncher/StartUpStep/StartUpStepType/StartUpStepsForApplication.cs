using Microsoft.Extensions.Configuration;
using RestaurantLibrary.ApplicationLauncher.StartUpStep.TheSteps.ConfigBuilder;
using RestaurantLibrary.Providers.ConnectionString;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RestaurantLibrary.ApplicationLauncher.StartUpStep.StartUpStepType
{
    public class StartUpStepsForApplication:IStartUpStep
    {
        IConfigBuilder _configBuilder;
        IConnectionStringProvider _connectionStringProvider;


        public StartUpStepsForApplication(IConfigBuilder configBuilder, IConnectionStringProvider connectionStringProvider)
        {
            _configBuilder = configBuilder;
            _connectionStringProvider = connectionStringProvider;
        }

        //public void Execute()
        //{

        //}
    }
}
