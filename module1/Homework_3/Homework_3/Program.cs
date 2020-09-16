using System;

namespace Homework_3
{
    class Program
    {
        public static bool check(int n)
        {
            if (n > 99)
            {
                string a = n.ToString();
                for (int i = 0; i < a.Length; i++)
                {
                    if (i != 0 && a[i] != a[i - 1])
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void S()
        {
            int n = 0;
            int s = 0;
            while (!check(s))
            {
                n += 1;
                s += n;
            }
            Console.WriteLine($"количество = {n}");
            Console.WriteLine($"1+2+3+...+{n-2}+{n-1}+{n}");
            Console.WriteLine($"чмсло = {s}");
            return;
        }
        static void Main(string[] args)
        {
            S();
            return;
        }
    }
}
