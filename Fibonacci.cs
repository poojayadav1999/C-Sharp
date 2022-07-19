using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibonacciseries_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fibonacci series
            int n1 = 0;
            int n2 = 1; int n3;
            int num = 0;
            Console.WriteLine("Enter the fibonacci series no.");
            num = int.Parse(Console.ReadLine());
            Console.Write(n1 + "" + n2 + "");
            for (int i = 2; i < num; ++i)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;

            }

            Console.ReadLine();
        }
    }
}
