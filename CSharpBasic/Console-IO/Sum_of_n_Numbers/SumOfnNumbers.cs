using System;

class SumOfnNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double num = 0;
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
             num = double.Parse(Console.ReadLine());
             sum += num;
        }
        Console.WriteLine(sum);
    }
}