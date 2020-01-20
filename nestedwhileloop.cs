using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class nestedwhileloop
    {

        static void Main(string[] args)
        {
            //nested while loop in c#
            int i = 0;

            while (i < 2)
            {
                Console.WriteLine("Value of i: {0}", i);
                int j = 1;

                i++;

                while (j < 2)
                {
                    Console.WriteLine("Print value of j: {0}", j);
                    j++;
                }
            }
            Console.ReadLine();
        }
    }
}
