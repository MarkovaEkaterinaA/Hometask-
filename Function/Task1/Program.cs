//Задача 1: Напишите программу, которая бесконечно запрашивает 
//целые числа с консоли. Программа завершается при вводе символа ‘q’ 
//или при вводе числа, сумма цифр которого чётная.

using System;

class Program
{
static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введите целое число или 'q' для выхода:");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            if (int.TryParse(input, out int number))
            {
                if (IsSumOfDigitsEven(number))
                {
                    Console.WriteLine($"Сумма цифр числа {number} чётная. Программа завершена.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Сумма цифр числа {number} нечётная. Продолжайте ввод.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Введите корректное целое число или 'q' для выхода.");
            }
        }
    }

    static bool IsSumOfDigitsEven(int number)
    {
        int sum = 0;
        number = Math.Abs(number); // Убедимся, что число положительное для подсчета суммы цифр

        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }

        return sum % 2 == 0;
    }
}