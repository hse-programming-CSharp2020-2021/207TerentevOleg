using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            //инициализация переменных
            bool flag;
            double a, b, c;
            string input;
            Console.WriteLine("введите катет: ");
            input = Console.ReadLine();

            flag = double.TryParse(input, out a);
            if (!flag)
            {
                Console.WriteLine("неправильный ввод. Ввод дроби через запятую");
                return;
            }
            Console.WriteLine("введите катет: ");
            input = Console.ReadLine();
            flag = double.TryParse(input, out b);
            if (!flag)
            {
                Console.WriteLine("неправильный ввод. Ввод дроби через запятую");
                return;
            }

            c = Math.Pow(a * a + b * b, 0.5);
            Console.WriteLine("гипотенуза = " + c.ToString("F"));
            return;


        }
    }
}
