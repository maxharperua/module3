using System;

namespace Task2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int cardCount = 0;
            int totalScore = 0;
            
            Console.WriteLine("Здраствуйте, введите количество карт");
            
            while (!int.TryParse(Console.ReadLine().Trim().ToUpper(), out cardCount))
            {
                Console.WriteLine("Ошибка ввода, введите целое число!");
            }
            
            for (int i = 1; i <= cardCount; i++)
            {
                Console.WriteLine("Введите номинал карты номер " + i );
                string input = Console.ReadLine().Trim().ToUpper();
 
                bool result = int.TryParse(input, out var number);
                if (result && number >= 2 && number <= 10)
                {
                    totalScore += number;
                }
                else
                {
                    switch (input)
                    {
                        case "J":
                        case "Q":
                        case "K":
                        case "T":
                            totalScore += 10;
                            break;
                    }
                }
            }
            
            Console.WriteLine("Значение суммы карт - " + totalScore);
        }
    }
}