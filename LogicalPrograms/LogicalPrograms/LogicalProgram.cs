using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class LogicalProgram
    {
         public  void PerfectNumber()
         {
            int SumOfDivisors=0;
            Console.WriteLine("Welcome to Perfect Numbers");
            Console.Write("Enter the number = ");
            int number=Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<=number/2;i++)
            {
                if (number%i==0)
                {
                    SumOfDivisors += i;
                    
                }
            }
            if (SumOfDivisors == number)
            {
                Console.WriteLine("This is a perfect number");
            }
            else
            {
                Console.WriteLine("This is not a perfect number");
            }
        }
    }
}
