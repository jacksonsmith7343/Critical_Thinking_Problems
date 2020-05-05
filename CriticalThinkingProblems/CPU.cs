using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingProblems
{
    class CPU
    {
        //member variables (has a)
        public string manufacturer;
        public GPU effectiveMemory;


        //constructor (spanwer)
        public CPU()
        {
            GPU gpu = new GPU();
        }

        //member methods (can do)
        public void ProcessInstall(Application application, HardDrive hardDrive, RAM ram)
        {
            
            hardDrive.ApplicationsInHardDrive.Add(application);
        }

        //Game class has a variable RequiredEffectiveMemory

        public bool CheckRequirements(Application application, HardDrive hardDrive, RAM ram)
        {
            bool installApplication = false;

          
            if (ram.temporaryMemory > application.requiredRAM && hardDrive.totalStorage > application.requiredStorage || graphics.effectiveMemory > requiredEffectiveMemory)
            {
                
                ProcessInstall(application, hardDrive, ram);
                installApplication = true;
            }
            return installApplication;
            
        }
    }
}
