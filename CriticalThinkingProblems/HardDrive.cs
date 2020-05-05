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
        public double availableStorage;
        public List<Application> ApplicationsInHardDrive;
        
        
        //constructor (spawner)
        public HardDrive(double totalStorage, double availableStorage)
        {

            this.availableStorage = availableStorage;
            this.totalStorage = totalStorage;

            ApplicationsInHardDrive = new List<Application>();
            
        }
        
        
    }
}
