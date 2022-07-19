using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwitchstatProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch stat
            int x = 4;
            switch (x)
            {
                case 1:
                    Console.WriteLine("Today is Sunday");
                    break;
                case 2:
                    Console.WriteLine("Today is Monday");
                    break;
                case 3:
                    Console.WriteLine("Today is Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Today is Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Today is Friday");
                    break;
                case 6:
                    Console.WriteLine("Today is Saturday");
                    break;
                default:
                    Console.WriteLine("No any day");
                    break;
            }
            Console.ReadLine();

        }
    }
}
