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
            int result = MultiplyNumbers(40 , 35);
            int result2 = DivideNumbers(result , 4);
            int result3 = AddTwoNumbers(6 , 5);
            int result4 = SubtractNumbers(result3, 350);
            int result5 = AddTwoNumbers(result4, 4);
            Console.WriteLine(result5);
            Console.ReadLine();
        }

        public int SubtractNumbers(int numberOne , int numberTwo)
        {
            int sum = numberOne - numberTwo;
            return sum;
        }

        public int MultiplyNumbers(int numberOne, int numberTwo)
        {
            int sum = numberOne * numberTwo;
            return sum;
        }

        public int DivideNumbers(int numberOne, int numberTwo)
        {
            int sum = numberOne / numberTwo;
            return sum;
        }
       
    }
}
//Console.WriteLine("Enter first number to add:");
//            int value1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter second number to add:");
//            int value2 = int.Parse(Console.ReadLine());
//int output = AddTwoNumbers(value1, value2);
//Console.WriteLine("The result is:" + output);
