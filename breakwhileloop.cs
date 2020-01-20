using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class breakwhileloop
    {
        static void Main(string[] args)
        {
            //break in while loop
            int i = 0;

            while (true)
            {
                Console.WriteLine("Value of i: {0}", i);

                i++;

                if (i > 10)
                    break;
            }
        }
    }
}
