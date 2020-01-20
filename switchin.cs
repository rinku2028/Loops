using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class switchin
    {
        static void Main(string[] args)
        {
            //switch case
            int i = 15;

            switch (i)
            {
                case 5:
                    Console.WriteLine("The value of i is 5");
                    break;
                case 10:
                    Console.WriteLine("The value of i is 10");
                    break;
                case 15:
                    Console.WriteLine("The value of i is 15");
                    break;
                default:
                    Console.WriteLine("Unknown value");
                    break;
            }
            Console.ReadLine();
        }
    }
}
