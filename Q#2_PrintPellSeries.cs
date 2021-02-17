using System;

namespace ConsoleApp1
{
    class Program
    {
        // calculate nth pell number 
        public static int pell(int n)
        {
            int a = 1, b = 2, c, n, i;
            if (n <= 2)
                return n;
            
            for (int i = 3; i <= n; i++)
            {
                c = 2 * b + a;
                a = b;
                b = c;
            }
            return b;
        }
        public static void Main()
        {
            int n = 4;
            Console.Write(pell(n));
        }
    }
}
