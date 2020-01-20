using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class infiniteloop
    {
        static void Main(string[] args)
        {
            //Printing infinite loop
            for(; ; )
            {
                Console.WriteLine(2);
            }
            Console.ReadLine();

        }
    }
}
