using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class LogicalProgram
    {
        public void ReverseNumber()
        {
            int Reminder=0;
            int ReverseNmuber=0;
            Console.Write("Enter the number = ");
            int Number=Convert.ToInt32(Console.ReadLine());
            while(Number>0)
            {
                Reminder=Number%10;
                ReverseNmuber=(ReverseNmuber*10+Reminder);
                Number=Number/10;
            }
            Console.WriteLine("The Reverse Number is = " + ReverseNmuber);
        }
    }
}
