using System;
namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double a;
            string input = Console.ReadLine();
            Console.WriteLine("введите число а:");
            if (!double.TryParse(input, out a))
            {
                Console.WriteLine("не правильный ввод");
                return;
            }
            Console.WriteLine("введите число n:");
            if (!int.TryParse(input, out n))
            {
                Console.WriteLine("не правильный ввод");
                return;
            }
            ///быстрое возведение в степень
            double b = a;
            while (n > 0)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                    a *= a;
                }
                else
                {
                    n -= 1;
                    a *= b;
                }
            }
            Console.WriteLine(a.ToString("F4"));
            return;


        }
    }
}
