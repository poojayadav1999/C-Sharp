using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace do_whileloop_program
{
    class Program
    {
        static void Main(string[] args)
        {
            //do-while loop
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);
            Console.ReadLine();
        }
    }
}
