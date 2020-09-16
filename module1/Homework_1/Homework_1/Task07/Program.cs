using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int n, a;
            input = Console.ReadLine();
            if (!int.TryParse(input, out n))
            {
                Console.WriteLine("неверный ввод");
                return;
            }
            a = n / 100;
            Console.WriteLine(a % 10);
        }
    }
}
