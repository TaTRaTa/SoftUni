using System;

class PrintLongSequence
{
    static void Main()
    {
        Console.WriteLine("Print Long Sequence... ");
        for (int n = 2; n <= 1000; n++)
        {
            if(n%2==0)
            {
                Console.WriteLine(n+" ");
            }
            else
            {
                Console.WriteLine(-n +" ");
            }
        }
        Console.ReadLine();

    }
}