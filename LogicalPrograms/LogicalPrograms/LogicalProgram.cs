using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class LogicalProgram
    {
        public void PrimeNumber()
        {
            int Count=0;    
            Console.WriteLine("Enter the number");
            int Number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i<=Number; i++)
            {
                if (Number % i == 0)
                {
                    
                    Count++;
                }
            }
            if(Count == 2)
            {
                Console.WriteLine("The number is prime number");
            }
            else
            {
                Console.WriteLine("The number is not a prime number");
            }
           
        }
    }
}
