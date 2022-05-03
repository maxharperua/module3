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
            
            while (true)
            {
                if(int.TryParse(Console.ReadLine(), out cardCount))
                {
                    break;
                }
                Console.WriteLine("Ошибка ввода, введите целое число!");
            }
            
            for (int i = 1; i <= cardCount; i++)
            {
                Console.WriteLine("Введите номинал карты номер " + i );
                string input = Console.ReadLine();
 
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
                        case "j":
                        case "Q":
                        case "q":
                        case "K":
                        case "k":
                        case "T":
                        case "t":
                            totalScore += 10;
                            break;
                    }
                }
            }
            
            Console.WriteLine("Значение суммы карт - " + totalScore);
        }
    }
}