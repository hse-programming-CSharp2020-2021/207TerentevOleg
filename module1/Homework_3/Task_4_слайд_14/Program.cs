using System;

namespace Task_4_слайд_14
{
    class Program
    {
        public static void min(uint a, uint b, uint c)
        {
            if(a % 100 > b % 100)
            {
                uint d = a;
                a = b;
                b = d;
            }
            if (a % 100 > c % 100)
            {
                uint d = a;
                a = c;
                c = d;
            }
            Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("введите номер аудитории:");
            if(!uint.TryParse(Console.ReadLine(),out uint n1))
            {
                Console.WriteLine("ERROR");
            }
            Console.WriteLine("введите номер аудитории:");
            if (!uint.TryParse(Console.ReadLine(), out uint n2))
            {
                Console.WriteLine("ERROR");
            }
            Console.WriteLine("введите номер аудитории:");
            if (!uint.TryParse(Console.ReadLine(), out uint n3))
            {
                Console.WriteLine("ERROR");
            }
            min(n1, n2, n3);
        }
    }
}
