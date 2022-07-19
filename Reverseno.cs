using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverseno_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program for Reverse no.

            int num;
            Console.WriteLine("Enter the no");
            num = int.Parse(Console.ReadLine());
            int n = num;
            int rem;
            int Revnum = 0;

            while (num != 0)
            {
                rem = num % 10;
                Revnum = (Revnum * 10) + rem;
                num = num / 10;
            }
            Console.WriteLine("Reverse number is:" + Revnum);
            Console.ReadLine();

        }
    }
}
