using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class QuickSort
{
    static void Main()
    {
        int[] numbers = { 2, 6, 6, 9, 12, 1, 3, 10, 7, 5, 0 };
        Quicksort(numbers);
        Console.WriteLine(string.Join(", ", numbers));
    }

    public static void Quicksort(int[] numbers)
    {
        Quicksort(numbers, 0, numbers.Length - 1);
    }

    public static void Quicksort(int[] arr, int left, int right)
    {
        int index = Partition(arr, left, right);
        if (left < index - 1)
        {
            Quicksort(arr, left, index - 1);
        }

        if (index < right)
        {
            Quicksort(arr, index, right);
        }

    }
    public static int Partition(int[] arr, int left, int right)
    {
        int i = left, j = right;
        int tmp;
        int pivot = arr[(left + right) / 2];

        while (i <= j)
        {
            while (arr[i] < pivot)
                i++;
            while (arr[j] > pivot)
                j--;
            if (i <= j)
            {
                tmp = arr[i];
                arr[i] = arr[j];
                arr[j] = tmp;
                i++;
                j--;
            }
        };

        return i;
    }
}

