using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class nestedloops
    {
        static void Main(string []args)
        {
            // loop within loop printing Nested Loops
            for (int i = 2; i < 3; i++)
                for (int j = 1; j < i; j++)
                    Console.WriteLine("NestedLoops");
            Console.ReadLine();
        }
    }
}
