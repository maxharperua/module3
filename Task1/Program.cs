using System;

namespace Task1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int num;
            while (true)
            {
                if(int.TryParse(Console.ReadLine(), out num))
                {
                   break;
                }
                Console.WriteLine("Ошибка ввода, введите целое число!");
            }

            Console.WriteLine($"Введенное число - {num}");
            if (num % 2 == 1)
            {
                Console.WriteLine("Число нечетное");
            }
            else
            {
                Console.WriteLine("Число четное");
            }

            Console.ReadKey();
        }
    }
}