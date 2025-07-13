using Autofac;
using RestaurantLibrary;
using RestaurantLibrary.ApplicationLauncher.ApplicationType;
using RestaurantLibrary.ApplicationLauncher.StartUpStep.StartUpStepType;
using RestaurantLibrary.ApplicationLauncher.StartUpStep.TheSteps.ConfigBuilder;
using RestaurantLibrary.Providers.ConnectionString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAppUI
{
    internal class IOCcontrainer
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<StartUpStepsForApplication>().As<IStartUpStep>();
            builder.RegisterType<Bridge>().As<IBridge>().WithParameter(new TypedParameter(typeof(Type), typeof(Program)));
            builder.RegisterType<ConnectionStringFetcher>().As<IConnectionStringProvider>().WithParameter(new TypedParameter(typeof(string), "Defaults"));
            builder.RegisterType<ConfigBuilderForUserSecret>().As<IConfigBuilder>();


            return builder.Build();
        }
    }
}
