using System;

public class Program
{
    public static void Main()
    {
        int len1, len2;
        do
        {
            Console.Write("Скiльки масивiв ви хочете додати до масиву? ");
            len1 = Convert.ToInt32(Console.ReadLine());
        } while (len1 <= 0);

        do
        {
            Console.Write("Скiльки елементiв ви хочете додати до 1 масиву? ");
            len2 = Convert.ToInt32(Console.ReadLine());
        } while (len2 <= 0);

        int[,] numbers = new int[len1, len2];
        int[] max = new int[len1];

        for(int i = 0; i < len1; i++)
        {
            max[i] = 0;
        }

        Console.WriteLine("Введiть числа по черзi.");

        for (int i = 0; i < len1; i++)
        {
            Console.WriteLine($"Масив номер {i}.");
            for (int x = 0; x < len2; x++)
            {
                Console.WriteLine($"Число номер {x}.");
                numbers[i, x] = Convert.ToInt32(Console.ReadLine());
            }
        }

        for(int i = 0; i < len1; i++)
        {
            for(int x = 0; x < len2; x++)
            {
                max[i] += numbers[i,x];
            }
        }

        int index = Array.IndexOf(max, max.Max());
        Console.WriteLine($"Номер рядка з найбiльшою сумою елементiв - {index}.");
    }
}