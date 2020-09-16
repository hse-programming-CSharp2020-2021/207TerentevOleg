using System;

namespace Task_1_слайд_14
{
    class Program
    {
        public static bool funk(double a, double b)
        {
            if(a * a + b* b <= 4)
            {
                return true;
            }
            return false;
        }
        public static bool check(double x, double y)
        {
            if(y>=0 && y >= x)
            {
                return true;
            }
            return false;
        }
        public static bool G(double x, double y)
        {
            if (funk(x, y) && check(x, y))
            {
                return true;
            }
            return false;
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
                Console.WriteLine(G(x, y));
            }
        }
    }
}
