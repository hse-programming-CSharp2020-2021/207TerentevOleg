using System;

namespace Task05
{
    class Program
    {
        public static void check(double a, double b, double c)
        {
            int n = 0;
            n += a + b > c ? 1 : 0;
            n += a + c > b ? 1 : 0;
            n += c + b > a ? 1 : 0;
            switch (n)
            {
                case 3:
                    Console.WriteLine("треугольник существует!");
                    break;
                default:
                    Console.WriteLine("треугольника не существует!");
                    break;

            }
            return;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("A:");
                if (!double.TryParse(Console.ReadLine(), out double a))
                {
                    Console.WriteLine("error");
                    return;
                }
                Console.WriteLine("B:");
                if (!double.TryParse(Console.ReadLine(), out double b))
                {
                    Console.WriteLine("error");
                    return;
                }
                Console.WriteLine("C:");
                if (!double.TryParse(Console.ReadLine(), out double c))
                {
                    Console.WriteLine("error");
                    return;
                }
                int n = 0;
                n += a <= 0 ? 1 : 0;
                n += b <= 0 ? 1 : 0;
                n += c <= 0 ? 1 : 0;
                switch (n)
                {
                    case 0:
                        check(a, b, c);
                        break;
                    default:
                        Console.WriteLine("нулевая или отрицательная длинна!");
                        break;
                }
                
            }
        }
    }
}