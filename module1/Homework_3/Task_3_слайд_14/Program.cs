using System;
using System.Reflection.Metadata.Ecma335;

namespace Task_3_слайд_14
{
    class Program
    {
        public static void G(double x)
        {
            if (x < 0.5){
                Console.WriteLine(Math.Sin(Math.PI/2));
            }
            else
            {
                Console.WriteLine(Math.Sin(Math.PI*(x-1)/2));
            }

        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("введите х:");
                if (!double.TryParse(Console.ReadLine(), out double x))
                {
                    Console.WriteLine("error");
                    continue;
                }
                G(x);
            }
        }
    }
}
