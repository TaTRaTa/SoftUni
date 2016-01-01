using System;
using System.Collections.Generic;
using System.Linq;


class Select
{
    static void Main()
    {
        int[] numbers = { 2, 6, 9, 12, 1, 3, 10, 7, 5, 0 };

        for (int element = 0; element < numbers.Length - 1; element++)
        {
            for (int current = element + 1; current < numbers.Length; current++)
            {
                if (numbers[element] > numbers[current])
                {
                    int temp = numbers[element];
                    numbers[element] = numbers[current];
                    numbers[current] = temp;
                }
            }
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i == numbers.Length - 1)
            {
                Console.WriteLine(numbers[i]);
            }
            else
            {
                Console.Write(numbers[i] + ", ");
            }
        }
    }
}

