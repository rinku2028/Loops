using System;

namespace multiplicationtable
{
    class multiplytableofgivenint
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("DISPLAY MULTIPLICAITON TALBE:\n");
            Console.WriteLine("Please input number to be calculated:");
            j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n"); //New line

            for(i=1;i<=10;i++)
            {
                Console.WriteLine("{0}x{1}={2}\n",j,i,i * j);
            }
            Console.ReadLine();
        }
    }
}
