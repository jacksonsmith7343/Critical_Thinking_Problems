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
            ForLoop("Hello World");
        }

        public void ForLoop(string word)
        {
            Console.WriteLine();
           

            for (int i = 0; i < word.Length; i++)
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
