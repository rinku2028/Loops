using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class multiplicationforloop
    {
        static void Main(string[] args)
        {
            int x;
            int y;

            Console.Write("\n\n");
            Console.Write("Multiplication table as you wish:\n");
            Console.Write("-----------------------------------");
            Console.Write("\n\n");

            Console.Write("Please input the number for the multiplication : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for (x = 1; x <= 10; x++)
            {
                Console.Write("{0} X {1} = {2} \n", y,x, y * x);
            }
            Console.ReadLine();
        }
    }
}
