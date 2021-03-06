﻿using System;
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
        public string name;
        


        //constructor (spanwer)
        public CPU()
        {
            manufacturer = "Intel";
            
        }

        //member methods (can do)
        public void ProcessInstall(Application application, HardDrive hardDrive, RAM ram)
        {
            
            hardDrive.ApplicationsInHardDrive.Add(application);
        }

        //Game class has a variable RequiredEffectiveMemory

        public bool CheckRequirements(Application application, HardDrive hardDrive, RAM ram, GPU gpu)
        {
            bool installApplication = false;

          
            if (ram.temporaryMemory > application.requiredRAM && hardDrive.totalStorage > application.requiredStorage || gpu.effectiveMemory > application.requiredEffectiveMemory)
            {
                
                ProcessInstall(application, hardDrive, ram);
                installApplication = true;
            }
            return installApplication;
            
        }
    }
}
