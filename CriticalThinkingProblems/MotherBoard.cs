using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingProblems
{
    class MotherBoard
    {
        //member variables (has a)
        public string manufacturer;
        public CPU processor;
        public RAM temporaryMemory;
        public HardDrive storage;
        public GPU graphics;

        //constructor (spawner)
        public MotherBoard(string manufacturer, RAM ram, CPU cpu, HardDrive hardDrive, GPU gpu)
        {
            temporaryMemory = ram;
            processor = cpu;
            storage = hardDrive;
            graphics = gpu;
            
            

        }

        //member methods (can do)
        public void InstallApplication(Application application)
        {
            CheckRequirements();
            ProcessInstall();

           
        }
    }
}
    