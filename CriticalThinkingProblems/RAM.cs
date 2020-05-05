using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingProblems
{
    class RAM
    {
        //member variables (has a)
        public double totalGigabytes;
        public string brand;
        public double temporaryMemory;


        //constructor (spawner)
        public RAM(double totalGigabytes)
        {
            this.totalGigabytes = totalGigabytes;
            brand = "Corsair";
        }
    }
}
