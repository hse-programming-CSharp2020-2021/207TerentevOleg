using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //инициализация переменных
            
            char ch;
            //считывание данных
            if(!int.TryParse(Console.ReadLine(), out int Code))
            {
                Console.WriteLine("Error");
                return;
            }
            //преобразование целого числа к char
            ch = (char)Code;
            //вывод данных
            Console.WriteLine(ch);

        }
    }
}