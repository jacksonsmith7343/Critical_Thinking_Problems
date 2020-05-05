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
        public GPU graphics;
        public Application requiredStorage;
        public Application requiredRAM;
        public List<Application> ApplicationsInHardDrive;

        //constructor (spawner)
        public MotherBoard(string manufacturer, RAM ram, CPU cpu, HardDrive hardDrive, GPU gpu)
        {
            manufacturer = manufacturer;
            processor = cpu;
            graphics = gpu;
            var valueOfAvailableStorage = hardDrive.AvailableStorage;
            

        }

        //member methods (can do)
        public void InstallApplication(Application application)
        {
            CheckRequirements();
            ProcessInstall();

           
        }
    }
}
    