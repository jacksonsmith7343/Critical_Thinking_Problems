using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingProblems
{
    class Application
    {
        public string applicationName;
        public string applicationType;
        public double requiredRAM;
        public double requiredStorage;

        public Application()
        {
            Application application = new Application();
            applicationName = "Slack";
            applicationType = "Messaging service";
            requiredRAM = 4.0; //In Gigabytes
            requiredStorage = 0.512; //In Gigabytes
        }



    }
}
