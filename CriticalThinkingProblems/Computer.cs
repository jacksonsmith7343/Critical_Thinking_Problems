using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingProblems
{
    class Computer
    {
        //member variables (has a)



        //constructor (spawner)
        public Computer()
        {
            GPU gpu = new GPU(2.0);
            HardDrive hardDrive = new HardDrive(20.0, 20.0);
            RAM ram = new RAM(8.0);
            CPU cpu = new CPU();
            Game game = new Game(2.0);

        }


        //member methods (can do)

    }
}
