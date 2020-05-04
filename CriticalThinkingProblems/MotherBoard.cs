using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingProblems
{
    class MotherBoard
    {
        public string manufacturer;
        public CPU processor;
        public RAM temporaryMemory;
        public HardDrive storage;
        public GPU graphics;
        public Application requiredStorage;
        public Application requiredRAM;

        public MotherBoard(string manufacturer, RAM ram, CPU cpu, HardDrive hardDrive, GPU gpu)
        {
            manufacturer = manufacturer;
            temporaryMemory = ram;
            processor = cpu;
            storage = hardDrive;
            graphics = gpu;
            var valueOfAvailableStorage = hardDrive.AvailableStorage;
            
        }

        public void InstallApplication(Application application)
        {
            List<Application> ApplicationsInHardDrive = new List<Application>();

            var valueOfAvaileStorage = storage.AvailableStorage;
            if ( temporaryMemory.TotalGigabytes> application.requiredRAM && valueOfAvaileStorage > application.requiredStorage)
            {
                ApplicationsInHardDrive.Add(application);
            }
            
        }
    }
}
    