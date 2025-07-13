using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantLibrary.ApplicationLauncher.StartUpStep.TheSteps.ConfigBuilder
{
    public interface IConfigBuilder
    {
        IConfiguration ReturnConfig(Type Anchor);
    }
}
