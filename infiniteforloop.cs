using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class infiniteloop
    {
        static void Main(string []args)
        {
            for(; ;)
            {
                Console.WriteLine("Hello! This is infinite loop!");
                
            }

            Console.ReadLine();
        }
    }
}
