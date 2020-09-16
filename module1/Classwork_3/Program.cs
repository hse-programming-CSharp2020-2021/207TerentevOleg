using System;

namespace classwork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A:");
            if(!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("error");
            }
            Console.WriteLine("B:");
            if(!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("error");
            }
            Console.WriteLine("Delta:");
            if(!double.TryParse(Console.ReadLine(), out double delta))
            {
                Console.WriteLine("error");
            }
            double S = 0.0, c = a;
            while(b-c>delta)
            {
                S += delta * (c * c + (c + delta) * (c + delta)) / 2;
                c += delta;
            }
            S += (b - c) * (c * c + b * b) / 2;
            Console.WriteLine(S);
        }
    }
}
