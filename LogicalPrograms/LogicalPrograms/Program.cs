using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================Logical Programs===================");
            LogicalProgram program = new LogicalProgram();
            //program.PrimeNumber();
            //program.ReverseNumber();
            //program.FibonacciSeries();
            //program.CouponNumber();
            program.PerfectNumber();
            Console.ReadLine(); 
        }
    }
}
