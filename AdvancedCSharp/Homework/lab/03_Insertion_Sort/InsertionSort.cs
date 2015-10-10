using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class InsertionSort
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int maxValue = int.MinValue;
        int count = 0;
        for (int i = 1; i < numbers.Length; i++)
        {
            for (int j = i ; j > 0; j--)
            {
                if ( j > 0 && numbers[j - 1] > numbers[j])
                {
                    maxValue = numbers[j - 1];                    
                    numbers[j - 1] = numbers[j];
                    numbers[j] = maxValue;
                }             
            }
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
}

