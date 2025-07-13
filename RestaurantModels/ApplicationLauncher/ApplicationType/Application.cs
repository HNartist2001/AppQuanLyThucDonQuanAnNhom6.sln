using RestaurantLibrary.ApplicationLauncher.StartUpStep.StartUpStepType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantLibrary.ApplicationLauncher.ApplicationType
{
    internal class Application:IApplication
    {
        IEnumerable<IStartUpStep> _startUpSteps;

        public Application (IEnumerable<IStartUpStep> startUpSteps)
        {
            _startUpSteps = startUpSteps;
        }

        public void Run()
        {
            //foreach (var Step in _startUpSteps) 
            //{
            //    Step.Execute();
            //}
        }
        
    }
}
