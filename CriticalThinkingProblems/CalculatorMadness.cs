using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingProblems
{
    class CalculatorMadness
    {
        
        public int AddTwoNumbers(int numberOne , int numberTwo)
        {
            int sum = numberOne + numberTwo;
            return sum;
        }

        public void RunCalculations()
        {
            int result = AddTwoNumbers(8, 40);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public void SubtractNumbers()
        {

        }

        public void MultiplyNumbers()
        {

        }

        public void DivideNumbers()
        {

        }
       
    }
}
//Console.WriteLine("Enter first number to add:");
//            int value1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter second number to add:");
//            int value2 = int.Parse(Console.ReadLine());
//int output = AddTwoNumbers(value1, value2);
//Console.WriteLine("The result is:" + output);
