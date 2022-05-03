using System;

namespace Task3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число для проверкаи на признак простоты");
            int number;
            bool isSimple = true;
            while (true)
            {
                if(int.TryParse(Console.ReadLine(), out number) && number >= 2)
                {
                    break;
                }
                Console.WriteLine("Ошибка ввода, введите целое число! > 1");
            }
            
            int i = 2;
            while (i <= number / 2)
            {
                if (number % i == 0)
                {
                    isSimple = false;
                    break;
                }
                i++;
            }
            
            Console.WriteLine(isSimple ? "Число простое" : "Число не простое");
            Console.ReadKey();
            
        }
        
    }
}