using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1_Spring2021
{
    class Program
    {
        static void Main(string[] args)
        {

            //Question 1
            Console.WriteLine("Q1 : Enter the number of rows for the traingle:");
            int n = Convert.ToInt32(Console.ReadLine());
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

            //Question 2:
            Console.WriteLine("Q2 : Enter the number of terms in the Pell Series:");
            int n2 = Convert.ToInt32(Console.ReadLine());
                int a = 1, b = 2, c, n, i;
                if (n <= 2)
                    return n;

                for (int i = 3; i <= n; i++)
                {
                    c = 2 * b + a;
                    a = b;
                    b = c;
                    int n = 4;
                    Console.Write(pell(n));
                }
                return b;
            }
            
            //Question 3:
            Console.WriteLine("Q3 : Enter the number to check if squareSums exist:");
            int n3 = Convert.ToInt32(Console.ReadLine());
            bool flag = (x == (int)x(n3);
            int i, c;
            double x;
            bool judgeSquareSum(int c);
            Console.WriteLine("Enter a String:");
            c = Console.ReadLine();
            for (i = 0; i * i <= c; i++)
            {

                if (flag)
                {
                    Console.WriteLine("Yes, the number can be expressed as a sum of squares of 2 integers");
                }
                else
                {
                    Console.WriteLine("No, the number cannot be expressed as a sum of squares of 2 integers");
                }
            }

            //Question 4:
            int[] arr = { 3, 1, 4, 1, 5 };
            Console.WriteLine("Q4: Enter the absolute difference to check");
            int k = Convert.ToInt32(Console.ReadLine());
            int n4 = diffPairs(arr, k);
            var map = new Dictionary<int, int>();
            int count = 0;

            foreach (var num in nums)
            {
                if (!map.ContainsKey(num)) map[num] = 0;
                map[num]++;
            }

            foreach (var num in map.Keys)
            {
                if ((k > 0 && map.ContainsKey(num + k)) || (k == 0 && map[num] > 1))
                    count++;
            }

            Console.WriteLine("There exists {0} pairs with the given difference", n4);

            //Question 5:
            List<string> emails = new List<string>();
            emails.Add("dis.email + bull@usf.com");
            emails.Add("dis.e.mail+bob.cathy@usf.com");
            emails.Add("disemail+david@us.f.com");
            int ans5 = UniqueEmails(emails);
            string str1, str2 = " ";
            int i;
            Console.WriteLine("Enter a String:");
            str1 = Console.ReadLine();

            for (i = 0; i < str1.Length; i++)
            {
                if (str1[i] == '.' || str1[i] == '+')
                {

                }
                else
                {
                    str2 = str2 + str1[i];
                }
            }
            Console.WriteLine("Q5");
            Console.WriteLine("The number of unique emails is " + str2);


            //Quesiton 6:
            string[,] paths = new string[,] { { "London", "New York" }, { "New York", "Tampa" },
                                        { "Delhi", "London" } };
            string destination = DestCity(paths);
            var dict = new Dictionary<string, string>();

            foreach (var list in paths)
            {
                dict.Add(list[0], list[1]);
            }
            string first = paths[0][0];

            while (dict.ContainsKey(first))
            {
                first = dict[first];
            }
            //Console.WriteLine(first);
            Console.WriteLine("Q6");
            Console.WriteLine("Destination city is " + destination);
            }
        }
    }
}

