using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Swappingtwono_Prog
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program for Swapping two no Without using third no.

            int a;
            int b;
            Console.WriteLine("Enter first no");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second no");
            b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("No of a is:" + a);
            Console.WriteLine("No of b is:" + b);
            Console.ReadLine();

        }
    }
}
