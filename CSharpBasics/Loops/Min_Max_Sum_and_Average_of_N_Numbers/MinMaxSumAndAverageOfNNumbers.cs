using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int forLoops = n;
        int min = int.MaxValue;
        int max = int.MinValue;
        double average = 0.0;
        int sum = 0;
        while (forLoops>0)
        {
            int num = int.Parse(Console.ReadLine());
            if (num>max)
            {
                max = num;
            }
            if (num<min)
            {
                min = num;
            }
            sum += num;
            forLoops--;
        }
        average = (double)sum / (double)n;
        Console.WriteLine("Min = {0}", min);
        Console.WriteLine("Max = {0}", max);
        Console.WriteLine("Sum = {0}", sum);
        Console.WriteLine("Average = {0}", average);

    }
}