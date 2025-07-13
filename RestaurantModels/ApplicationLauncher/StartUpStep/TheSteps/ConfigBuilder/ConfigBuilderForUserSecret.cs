using Microsoft.Extensions.Configuration;
using RestaurantLibrary.ApplicationLauncher.StartUpStep.StartUpStepType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantLibrary.ApplicationLauncher.StartUpStep.TheSteps.ConfigBuilder
{
    public class ConfigBuilderForUserSecret : IConfigBuilder, IStartUpStepForApplication
    {
        Type _Anchor;
        public ConfigBuilderForUserSecret(Type Anchor)
        {
            _Anchor = Anchor;
        }

        public IConfiguration ReturnConfig(Type Anchor)
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets(Anchor.Assembly, optional: true)
                .Build();

            return config;
        }
    }

}
