using System;

class Sumof3Numbers
{
    static void Main()
    {
        Console.Write("a= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b= ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c= ");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c,(a + b + c));

    }
}