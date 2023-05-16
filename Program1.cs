using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Скiльки елементiв ви хочете додати до масиву? ");
        int len, sum = 0, evenNumbers = 0;
        do
        {
            len = Convert.ToInt32(Console.ReadLine());
        } while (len < 0);

        int[] numbers = new int[len];

        Console.WriteLine("Введiть числа по черзi.");

        for (int i = 0; i < len; i++)
        {
            Console.WriteLine($"Число номер {i}.");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        foreach (int number in numbers)
        {
            if (number > 0)
            {
                sum += number;
            }

            if (number % 2 == 0 && number != 0)
            {
                evenNumbers++;
            }
        }

        Console.WriteLine($"Сума додатних чисел дорiвнює {sum}.");
        Console.WriteLine($"Кiлькiсть парних чисел дорiвнює {evenNumbers}");
    }
}