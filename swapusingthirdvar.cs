using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Swaptwonousingthirdvariable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program for Swapping two no using third no.

            int a = 10, b = 20, temp;

            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Values after swapping are:");
            Console.WriteLine("value of a is:" + a);
            Console.WriteLine("value of b is:" + b);
            Console.ReadLine();
        }
    }
}
