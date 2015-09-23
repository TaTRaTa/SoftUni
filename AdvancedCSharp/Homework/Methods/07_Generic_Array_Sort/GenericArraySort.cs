using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

class GenericArraySort
{
    static void Main()
    {
        int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
        string[] strings = { "zaz", "cba", "baa", "azis" };
        DateTime[] dates =
        {
            new DateTime(2002, 3, 1), new DateTime(2015, 5, 6), new DateTime(2014, 1, 1)
        };
        SortArray(numbers);
        SortArray(strings);
        SortArray(dates);
    }

    private static void SortArray<T>(T[] var) where T : IComparable
    {
        int len = var.Length;
        T maxValue;
        for (int i = 0; i < len; i++)
        {
            for (int j = i + 1; j < len; j++)
            {
                if ((var[i].CompareTo(var[j]) > 0))
                {
                    maxValue = var[i];
                    var[i] = var[j];
                    var[j] = maxValue;

                }
            }
        }
        foreach (var i in var)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

