using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingProblems
{
    public abstract class Application
    {
        //member variables (has a)
        public string applicationName;
        public string applicationType;
        public double requiredRAM;
        public double requiredStorage;
        public double requiredEffectiveMemory;

        //constructor (spawner)
        public Application()
        {
            applicationName = "Slack";
            applicationType = "Messaging service";
            requiredRAM = 4.0; //In Gigabytes
            requiredStorage = 0.512; //In Gigabytes
        }



    }
}
