﻿using System;

class Pairs
{
    static void Main()
    {
        string[] num = Console.ReadLine().Split();
        int sumTwo = 0;
        int[] sum = new int[(num.Length) / 2];
        int j = 0;
        int countEqualElemnts = 1;
        int maxdiff = 0;
        for (int i = 0, count = 1; i < num.Length; i++, count++)
        {
            int numInt = Convert.ToInt32(num[i]);
            sumTwo += numInt;
            if (count == 2)
            {
                sum[j] = sumTwo;
                sumTwo = 0;
                count = 0;
                j++;
            }
        }
        int compareValue = sum[0];
        for (int i = 1; i < (num.Length) / 2; i++)
        {
            if (compareValue == sum[i])
            {
                countEqualElemnts++;
            }
        }
        if (countEqualElemnts != (num.Length) / 2)
        {
            for (int i = 1; i < (num.Length) / 2; i++)
            {
                int diff = Math.Abs(compareValue - sum[i]);
                compareValue = sum[i];
                if (maxdiff < diff)
                {
                    maxdiff = diff;
                }
            }
            Console.WriteLine("No, maxdiff={0}", maxdiff);
        }
        if (countEqualElemnts == (num.Length) / 2)
        {
            Console.WriteLine("Yes, value={0}", sum[0]);
        }
    }
}