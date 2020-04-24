using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingProblems
{
    class Problems
    {
        //member variables 

        //constructor

        //member variables 

        public void Run()
        {
            ForLoop();
        }

        public void ForLoop()
        {
            Console.WriteLine("What number would you like to start the loop?");
            

            for (int i = Int32.Parse(Console.ReadLine()); i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        public void WhileLoop()
        {

        }

    }
}
