using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class LogicalProgram
    {
        public void FibonacciSeries()
        {
            int FirstNumber = 0;
            int SecondNumber = 1;
            int sum;
            Console.WriteLine("Welcome to Fibonacci Series");
            Console.Write("Enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("0 1 ");
            for (int i = 2; i <= number; i++)
            {
                sum = FirstNumber + SecondNumber;
                FirstNumber = SecondNumber;
                SecondNumber = sum;
                Console.Write(sum + " ");
            }
        }
    }
}
