using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace If_elseladder_program
{
    class Program
    {
        static void Main(string[] args)
        {
            //If_else ladder
            int z = 20;
            if (z <= 15)
            {
                Console.WriteLine("You cannot drive");
            }
            else if (z < 18)
            {
                Console.WriteLine("You have a license");
            }
            else if (z <= 20)
            {
                Console.WriteLine("please you can get license");
            }
            else
            {
                 Console.WriteLine("You can drive");
            }
            Console.ReadLine();
        }
    }
}
