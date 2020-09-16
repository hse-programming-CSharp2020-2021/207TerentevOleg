using System;
using System.Runtime.InteropServices;

namespace Task02
{
    class Program
    {
        public static uint max_int(uint P)
        {
            uint p0 = P / 100, p1 = (P % 100) / 10, p2 = P % 10;
            if (p0 < p1)
            {
                uint a = p0;
                p0 = p1;
                p1 = a;
            }
            if (p0 < p2)
            {
                uint a = p0;
                p0 = p2;
                p2 = a;
            }
            if (p1 < p2)
            {
                uint a = p1;
                p1 = p2;
                p2 = a;
            }
            return p0 * 100 + p1 * 10 + p2;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("P:");
                if (!uint.TryParse(Console.ReadLine(), out uint P))
                {
                    Console.WriteLine("ERROR");
                    return;
                }
                Console.WriteLine(max_int(P));
            }
            
        }
    }
}
