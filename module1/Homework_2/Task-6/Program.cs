using System;
using System.Net.NetworkInformation;

namespace Task06
{
    class Program
    {
        public static void dollar(double budget, uint part)
        {
            double Game = budget / 100 * part;
            Console.WriteLine((Game/74.91).ToString("C3"));
            Console.WriteLine((Game/88.70).ToString()+ " €");
            Console.WriteLine("{0,7:C}",Game);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("бюджет");
                if (!double.TryParse(Console.ReadLine(), out double budget))
                {
                    Console.WriteLine("error");
                    return;
                }
                if (budget < 0.0)
                {
                    Console.WriteLine("error");
                    return;
                }
                Console.WriteLine("%");
                if (!uint.TryParse(Console.ReadLine(), out uint part))
                {
                    Console.WriteLine("error");
                    return;
                }
                dollar(budget, part);            
            }
        }
    }
}