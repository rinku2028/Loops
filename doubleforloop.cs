using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class doubleforloop
    {
        //printing decimal values in for loop
        static void Main(string[] args)
        {
            for (double d = 1.01D; d < 1.10; d += 0.01D)
            {
                Console.WriteLine("Value of i: {0}", d);
            }
            Console.ReadLine();
        }
    }
}
