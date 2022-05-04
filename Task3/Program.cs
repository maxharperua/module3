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
            
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Ошибка ввода, введите целое число! > 1");
            }
            
            int i = 2;
            double sqrtNumber = Math.Sqrt(number);
            while (i <= sqrtNumber)
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