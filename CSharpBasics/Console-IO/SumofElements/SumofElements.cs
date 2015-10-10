using System;

class SumofElements
{
    static void Main()
    {
        string[] n = Console.ReadLine().Split();
        long sum = 0;
        long MaxElement = long.Parse(n[0]);
        for (int i = 1; i < n.Length; i++)    
        {
            long element = int.Parse(n[i]);
            if (MaxElement >= element)
            {
                sum += element;

            }
            else if (MaxElement < element)
            {
                sum += MaxElement;
                MaxElement = element;
            }

        }
        if (MaxElement - sum == 0)
        {
            Console.WriteLine("Yes, sum={0}", sum);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(MaxElement - sum));
        }
        Console.WriteLine();


    }
}