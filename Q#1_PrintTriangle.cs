using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            for (i = 1; i <= 5; i++)
            {
                for (j = 4; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
