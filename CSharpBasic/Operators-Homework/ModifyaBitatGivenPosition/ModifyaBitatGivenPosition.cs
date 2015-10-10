using System;

class ModifyaBitatGivenPosition
{
    static void Main()
    {
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("p= ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("v= ");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine();
       
        int mask = 0;
        if (v == 1)
        {
             mask = 1 << p;
            n |= mask;
            Console.WriteLine(n);

        }
        else if (v == 0)
        {
            mask = ~(1 << p);
            n &= mask;
            Console.WriteLine(n);
        }

    }
}