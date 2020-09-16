using System;
using System.Linq;

namespace Task_2_1_
{
    class Program
    {
        public static void reverse(uint a)
        {
            string ans = "", n = a.ToString();
            for(int i = n.Length - 1; i >= 0; i--)
            {
                ans += n[i];
            }
            Console.WriteLine(System.Int64.Parse(ans));
            return;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("ведите число");
                if (!uint.TryParse(Console.ReadLine(), out uint a))
                {
                    Console.WriteLine("error");
                    return;
                }
                reverse(a);
            }
        }
    }
}
