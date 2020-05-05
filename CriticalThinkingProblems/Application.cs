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
        

        //constructor (spawner)
        public Application(double requiredRAM, double requiredStorage)
        {
            applicationName = "Slack";
            applicationType = "Messaging service";
            this.requiredRAM = requiredRAM; //In Gigabytes
            this.requiredStorage = requiredStorage ; //In Gigabytes
        }



    }
}
