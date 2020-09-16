using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double C, F, K, R, De, N, Re, Ro;
            string input = Console.ReadLine();
            if (!double.TryParse(input, out C))
            {
                Console.WriteLine("не правильный ввод");
                return;
            }
            F = C * 9 / 5.0 + 32;
            K = C + 273.15;
            R = (C + 273.15) * 9 / 5.0;
            De = (100 - C) * 3 / 2.0;
            N = C * 33 / 100.0;
            Re = C * 4 / 5.0;
            Ro = C * 21 / 40.0 + 7.5;
            Console.WriteLine("Фаренгейт = " + F.ToString("F"));
            Console.WriteLine("Кельвин = " + K.ToString("F"));
            Console.WriteLine("Ранкин = " + R.ToString("F"));
            Console.WriteLine("Делиль = " + De.ToString("F"));
            Console.WriteLine("Ньютон = " + N.ToString("F"));
            Console.WriteLine("Реомюр = " + Re.ToString("F"));
            Console.WriteLine("Рёмер = " + Ro.ToString("F"));

        }
    }
}

