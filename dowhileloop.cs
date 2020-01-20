using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class dowhileloop
    {
        static void Main(string[] args)
        {
            //execute using do while loop
            int i = 0;

            do
            {
                Console.WriteLine("Value of i: {0}", i);

                i++;

            } while (i < 10);

            Console.ReadLine();

        }
    }
}
