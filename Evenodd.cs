using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Evenoddprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program for even or odd no.
            int num = 11;
            if (num % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
            Console.ReadLine();
        }
    }
}
