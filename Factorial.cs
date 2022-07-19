using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactorialProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Factorial program

            int num;
            int fact = 1;
            Console.WriteLine("Enter the number");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;

            }
            Console.WriteLine("factorial of a num is:" + fact);
            Console.ReadLine();
        }
    }
}
