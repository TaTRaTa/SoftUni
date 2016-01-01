using System;
using System.Linq;
using System.Collections.Generic;
class Bubble
{
    static void Main()
    {
        int[] numbers = { 2, 6, 9, 12, 1, 3, 10, 7, 5 };

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = 0; j < numbers.Length - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }     
            }  
        }

        numbers.ToList().ForEach(a =>  Console.Write("{0} ", a));
        Console.WriteLine();
    }
}