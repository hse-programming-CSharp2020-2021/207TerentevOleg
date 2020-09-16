using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            //объявление переменных с проверкой данных
            bool flag;
            double U, R, I, P;
            string input;
            Console.WriteLine("введите напряжение : ");
            input = Console.ReadLine();

            flag = double.TryParse(input, out U);
            if (!flag)
            {
                Console.WriteLine("неправильный ввод. Ввод дроби через запятую");
                return;
            }
            Console.WriteLine("введите сопротивление: ");
            input = Console.ReadLine();
            flag = double.TryParse(input, out R);
            if (!flag)
            {
                Console.WriteLine("неправильный ввод. Ввод дроби через запятую");
                return;
            }

            //вычисление и вывод силы тока 
            I = U / R;
            Console.WriteLine("Сила тока = " + I.ToString("F"));
            //вычисление и вывод мощности
            P = U * U / R;
            Console.WriteLine("Мощность тока = " + P.ToString("F"));

            return;
        }
    }
}
