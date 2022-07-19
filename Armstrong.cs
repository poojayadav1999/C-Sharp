using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Armstrongno_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program for Armstrong no.

            int num;
            Console.WriteLine("Enter the no");
            num = int.Parse(Console.ReadLine());
            int sum = 0;
            int rem;
            int n = num;
            while (num > 0)
            {
                rem = num % 10;
                sum = sum + rem * rem * rem;
                num = num / 10;
            }
            if (n == sum)
            {
                Console.WriteLine("no. is Armstrong");
            }
            else
            {
                Console.WriteLine("no. is not Armstrong");
            }
            Console.ReadLine();

        }
    }
}
