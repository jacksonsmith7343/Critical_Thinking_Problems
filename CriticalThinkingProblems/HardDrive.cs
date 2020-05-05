using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingProblems
{
    class HardDrive
    {
        //member variables (has a)
        public double totalStorage;
        public double AvailableStorage;
        public List<Application> ApplicationsInHardDrive;
        

        //constructor (spawner)
        public HardDrive()
        {
            ApplicationsInHardDrive = new List<Application>();
            
        }
        
        
    }
}
