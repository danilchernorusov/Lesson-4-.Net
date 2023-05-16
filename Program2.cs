using System;

public class Progpam
{
    public static void Main()
    {
        int len1, len2, min, max;
        Console.Write("Скiльки масивiв ви хочете додати до масиву? ");
        do
        {
            len1 = Convert.ToInt32(Console.ReadLine());
        } while (len1 < 0);

        Console.Write("Скiльки елементiв ви хочете додати до 1 масиву? ");
        do
        {
            len2 = Convert.ToInt32(Console.ReadLine());
        } while (len2 < 0);

        int[,] numbers = new int[len1,len2];

        Console.WriteLine("Введiть числа по черзi.");

        for (int i = 0; i < len1; i++)
        {
            Console.WriteLine($"Масив номер {i}.");
            for (int x = 0; x < len2; x++)
            {
                Console.WriteLine($"Число номер {x}.");
                numbers[i,x] = Convert.ToInt32(Console.ReadLine());
            }
        }

        min = numbers[0,0];
        max = numbers[0,0];
        for (int i = 0; i < len1; i++)
        {
            for (int x = 0; x < len2; x++)
            {
                if (numbers[i,x] < min)
                {
                    min = numbers[i,x];
                }
                else if (numbers[i,x] > max)
                {
                    max = numbers[i,x];
                }
            }
        }

        Console.WriteLine(min + max);
    }
}