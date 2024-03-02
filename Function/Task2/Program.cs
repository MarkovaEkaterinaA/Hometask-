//Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = GenerateRandomArray(10); // Создаем массив из 10 случайных трехзначных чисел

        // Выводим массив на экран
        Console.WriteLine("Сгенерированный массив:");
        foreach (int number in array)
        {
            Console.WriteLine(number);
        }

        // Подсчитываем количество четных чисел в массиве
        int countEven = CountEvenNumbers(array);

        // Выводим результат
        Console.WriteLine($"Количество чётных чисел в массиве: {countEven}");
    }

    static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size]; // Создаем массив указанного размера

        // Заполняем массив случайными трехзначными числами
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(100, 1000); // Генерируем случайное число от 100 до 999
        }

        return array;
    }

    static int CountEvenNumbers(int[] array)
    {
        int countEven = 0;

        // Подсчитываем количество четных чисел в массиве
        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                countEven++;
            }
        }

        return countEven;
    }
}