using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        void run()
        {
            Console.WriteLine("Please enter the a postive integer: ");
            string inputvalue = Console.ReadLine();
            long factorialvalue = CalculateFactorial(inputvalue);
            Console.WriteLine($"Factorial({inputvalue}) is {factorialvalue} ");
            Console.ReadKey();
        }

        private long CalculateFactorial (string input)
        {
            int inputvalue = int.Parse(input);
            long factorial(int dataValue)
            {
                if (dataValue == 1) return 1;
                else return dataValue * factorial(--dataValue);

            }   
                
            long factorialValue = factorial(inputvalue);
                return factorialValue;
         
        }
    }
}
