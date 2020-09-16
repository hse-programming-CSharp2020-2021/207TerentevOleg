using System;

namespace task1
{
    class Program
    {
        public static double Pow(double x, int n)
        {
            double b = x;
            while (n > 0)
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                    x *= x;
                }
                else
                {
                    n -= 1;
                    x *= b;
                }
            }
            return x;
        }
        public static double Funk(double x)
        {
            double ans = 12 * Pow(x, 4) + 9 * Pow(x, 3) - 3 * Pow(x, 2) + 2 * x - 4;
            return ans;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("X:");
                if (!double.TryParse(Console.ReadLine(), out double x))
                {
                    Console.WriteLine("error");
                    return;
                }
                Console.WriteLine(Funk(x));
            }
        }
    }
}