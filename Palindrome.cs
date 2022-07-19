using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindromeno_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //program of palindrom no.
            int num;
            Console.WriteLine("Enter the number");
            num = int.Parse(Console.ReadLine());
            int sum = 0; int rem; int n;
            n = num;
            while (num > 0)
            {
                rem = num % 10;
                sum = (sum * 10) + rem;
                num = num / 10;
            }
            if (n == sum)
            {
                Console.WriteLine("no. is Palindrom");
            }
            else
            {
                Console.WriteLine("no. is not Palindrom");
            }
            Console.ReadLine();


        }
    }
}
