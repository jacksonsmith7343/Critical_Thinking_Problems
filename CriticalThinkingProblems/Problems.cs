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
            //WhileLoop();
        }

        public void ForLoop(string word)
        {
            
           
            for (int i = 0; i< word.Length; i ++)
            {
                if(i %3 == 0)
                Console.WriteLine(word[i]);
            }
            Console.ReadLine();

        }
        

        public void WhileLoop()
        {
            int counter = 5;
            while (counter < 25)
            {
                counter++;
            }
            Console.ReadLine();
        }

    }
}
