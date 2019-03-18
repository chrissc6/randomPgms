using System;

namespace nextS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            long x = 625;
            x = check(x);
            Console.WriteLine(x);
        }

        private static long check(long num)
        {
            long x = 0;
            double y = 0;
            int z = -1;
            bool check = false;

            y = num;
            y = Math.Sqrt(y);
            y = (y  % 1);

            if (y == 0)
            {
                check = true;
                y = num;
                y = Math.Sqrt(y);
                x = Convert.ToInt64(y);
                
            }
            else
            {
                return z;
            }

            if (check == true)
            {
                x++;
                x = x * x;
            }

            return x;
        }
    }
}
