using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class breakexample
    {
        static void Main(string []args)
        {
            for (int i = 0; i <= 5; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine("The number is " + i);
            }
            Console.ReadLine();

        }
    }
}
