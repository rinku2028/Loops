using System;

namespace ConsoleApp9
{
    class continueexample
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 5; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine("The number is"+ i);
            }
            Console.ReadLine();
        }
    }
}
