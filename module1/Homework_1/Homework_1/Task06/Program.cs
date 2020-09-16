using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int n = 0, b = -1;

            while (b != 0)
            {
                input = Console.ReadLine();
                if (!int.TryParse(input, out b))
                {
                    Console.WriteLine("ошибка ввода");
                    return;
                }
                if (b % 2 == 0)
                {
                    n += 1;
                }

            }
            Console.WriteLine(n - 1);
            return;


        }
    }
}
