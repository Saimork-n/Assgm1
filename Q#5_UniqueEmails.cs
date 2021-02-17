using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2 = " ";
            int i;
            Console.WriteLine("Enter a String:");
            str1 = Console.ReadLine();

            for (i = 0; i < str1.Length; i++)
            {
                if(str1[i]=='.' || str1[i]=='+')
                {

                }
                else
                {
                    str2 = str2 + str1[i];
                }
            }
            Console.WriteLine(str2);
            Console.ReadLine();
        }
    }
}
