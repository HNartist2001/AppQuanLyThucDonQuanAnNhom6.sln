using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantLibrary.ApplicationLauncher.StartUpStep.TheSteps.ConfigBuilder
{
    public class Bridge:IBridge
    {
        public static Type _Anchor;

        public Bridge (Type Anchor)
        {
            _Anchor = Anchor;
        }
    }
}
