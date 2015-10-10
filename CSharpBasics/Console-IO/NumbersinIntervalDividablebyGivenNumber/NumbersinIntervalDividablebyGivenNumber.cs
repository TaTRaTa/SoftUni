using System;

class NumbersinIntervalDividablebyGivenNumber
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int p = 0;
        while (start>end)
        {
            Console.WriteLine("try again");
             start = int.Parse(Console.ReadLine());
             end = int.Parse(Console.ReadLine());
        }
        for ( int i = start ; i <= end; i++)
        {
            if (i%5==0)
            {
                p++;
            }

        }
        Console.WriteLine("start {0} - end {1} | p = {2}",start, end, p);

    }
}