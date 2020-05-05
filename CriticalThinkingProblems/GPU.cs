using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingProblems
{
    class GPU
    {
        //member variables (has a)
        public string manufacturer;
        public double effectiveMemory;

        //constructor (spawner)
        public GPU(double effectiveMemory)
        {
            this.effectiveMemory = effectiveMemory;
            manufacturer = "GeForce";
        }
       

        //member methods (can do)
    }
}
