using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorMadness calculatorMadness = new CalculatorMadness();
            calculatorMadness.RunCalculations();
            
            Problems problems  = new Problems();
            problems.Run();
        }
    }
}
