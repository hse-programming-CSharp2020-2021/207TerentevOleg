using System;

namespace Task_2_слайд_14
{
    class Program
    {
        public static void G(double x, double y)
        {
            if(x < y && x > 0)
            {
                Console.WriteLine(x + Math.Sin(y));
            }
            else if(x > y && x < 0)
            {
                Console.WriteLine(y - Math.Cos(x));
            }
            else
            {
                Console.WriteLine(0.5 * x * y);
            }
            return;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("введите x:");
                if (!double.TryParse(Console.ReadLine(), out double x))
                {
                    Console.WriteLine("error");
                    return;
                }
                Console.WriteLine("введите y:");
                if (!double.TryParse(Console.ReadLine(), out double y))
                {
                    Console.WriteLine("error");
                    return;
                }
                G(x, y);
            }
        }
    }
}
