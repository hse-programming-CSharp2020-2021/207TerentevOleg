using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Task03
{
    class Program
    {

        public static void decision(double A, double B, double C)
        {
            switch (A)
            {
                case 0:
                    switch (B)
                    {
                        case 0:
                            Console.WriteLine("нет корней");
                            break;
                        default:
                            double x = -1 * C / B;
                            Console.WriteLine("X = " + x.ToString("F3"));
                            break;
                    }
                    break;
                default:
                    double D = Math.Pow(B, 2) - 4 * A * C;
                    int k = D >= 0 ? 1 : 0;
                    switch (k)
                    {
                        case 1:
                            double x = (-1 * B + Math.Sqrt(D)) / 2 * A;
                            double x1 = (-1 * B - Math.Sqrt(D)) / 2 * A;
                            Console.WriteLine("X1 = " + x.ToString("F3"));
                            Console.WriteLine("X2 = " + x1.ToString("F3"));
                            break;
                        default:
                            double real = -B / (2 * A);
                            Complex d = D;
                            var im = Complex.Sqrt(d) / (2 * A);
                            Complex x2 = real + im;
                            Complex x3 = real - im;
                            Console.WriteLine("X = " + x2);
                            Console.WriteLine("X2 = " + x3);
                            break;
                    }
                    break;
            }
        }



        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("A:");
                if (!double.TryParse(Console.ReadLine(), out double A))
                {
                    Console.WriteLine("ERROR");
                    return;
                }
                Console.WriteLine("B:");
                if (!double.TryParse(Console.ReadLine(), out double B))
                {
                    Console.WriteLine("ERROR");
                    return;
                }
                Console.WriteLine("C:");
                if (!double.TryParse(Console.ReadLine(), out double C))
                {
                    Console.WriteLine("ERROR");
                    return;
                }
                decision(A, B, C);
            }
        }
    }
}
