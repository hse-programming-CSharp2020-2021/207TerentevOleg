using System;

namespace Task_7
{
    class Program
    {
        public static void whole(double n)
        {
            double a = Math.Truncate(n);
            double b = n - a;
            var c = (a.ToString("F3"), b.ToString("F3"));
            Console.WriteLine("целая и дробная часть:");
            Console.WriteLine(c);
        } 
        public static void sqrt_pow(double n)
        {
            Console.WriteLine("корень и квадрат:");
            Console.WriteLine((n>0?Math.Sqrt(n).ToString("F3"):"не существует", (n * n).ToString("F3")));
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("введите число");
                if (!double.TryParse(Console.ReadLine(), out double n))
                {
                    Console.WriteLine("error");
                    return;
                }
                whole(n);
                sqrt_pow(n);
            }
        }
    }
}
