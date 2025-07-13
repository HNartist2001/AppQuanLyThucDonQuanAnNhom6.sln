using Autofac;
using RestaurantLibrary.ApplicationLauncher.StartUpStep.TheSteps.ConfigBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantLibrary.RoleModules
{
    internal class OwnerModeModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<OwnerDashboard>().As<IDashboard>();
            builder.RegisterType<DeleteDocumentButton>().As<IDeleteFeature>();
            builder.RegisterType<AuditTrailLogger>().As<ILogger>();
            builder.RegisterType<OwnerConfigBuilder>().As<IConfigBuilder>();

        }
    }
}
