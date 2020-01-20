using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class whileloop
    {
        static void Main(string[] args)
        {
            //using while loop to execute block of code repeatedly
            int y = 0;

            while (y < 10)
            {
                Console.WriteLine("The value  of y: {0}", y);

                y++;
            }
        }
    }
}
