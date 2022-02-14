using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LogicalPrograms
{
    internal class LogicalProgram
    {

        Stopwatch watch = new Stopwatch();  
        private static int Yourchoice;

        public  void StartWatch()
        {
            do
            {
                Console.WriteLine("1. Start\n2. Stop \n3. Elapsed \n4. Exit");
                Console.Write("Enter Your Choice");
                int Yourchoice = Convert.ToInt32(Console.ReadLine());
                switch (Yourchoice)
                {
                    case 1:
                        watch.Start();
                        break;
                    case 2:
                        watch.Stop();
                        break;
                    case 3:
                        double elapsedTime = Math.Round((double)watch.ElapsedMilliseconds / 1000, 2);
                        Console.WriteLine("Elapsed Time is : " + elapsedTime + " Seconds");
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }

            } while (Yourchoice < 3);
        }
    }

}

