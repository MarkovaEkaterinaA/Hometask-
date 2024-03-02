//Напишите программу, которая перевернёт одномерный массив 
//(первый элемент станет последним, второй – предпоследним и т.д.)

using System;
 
public class Example
{
    public static void Main()
    {
        int[] array = { 24, 48, 26, 78, 98, 14 };
        Array.Reverse(array);
 
        Console.WriteLine(String.Join(',', array));
    }
}