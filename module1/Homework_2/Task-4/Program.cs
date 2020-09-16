using System;

namespace Task04
{
    class Program
    {
        public static void reverse(int a)
        {
            Console.WriteLine("" + a % 10 + a % 100 / 10 + a % 1000 / 100 + a / 1000);
        }
        static void Main(string[] args)
        {

            while(true){
                Console.WriteLine("введите число");
                if (!int.TryParse(Console.ReadLine(), out int a))
                {
                    Console.WriteLine("error");
                    return;
                }
                if(a < 1000 || a > 9999){
                    Console.WriteLine("не правильные входные данные");
                }
                reverse(a);
            }
        }
    }
}