using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string x = "This website is for losers LOL!";
            Console.WriteLine(x);
            x = Checker(x);
            Console.WriteLine(x);
            Console.ReadLine();
        }

        private static string Checker(string str)
        {
            List<char> chars2 = new List<char>();
            var chars = str.ToCharArray();
            char[] check = { 'a', 'e', 'i', 'o', 'u', 'y',
                       'A', 'E', 'I', 'O', 'U', 'Y' };
            

            foreach (char i in chars)
            {
                int c = 0;
                bool d = false;

                foreach (char j in check)
                {
                    if (i == j)
                    {
                        d = true;
                    }
                }

                if(!d)
                {
                    chars2.Add(i);
                }
            }

            string str2 = string.Join("", chars2.ToArray());

            return str2;
        }
    }
}
