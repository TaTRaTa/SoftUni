using System;

class TheBiggestof3Numbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double biggest = 0;
        if (a > b && a > c)
        {
            biggest = a;
        }
        else if (b > a && b > c)
        {
            biggest = b;
        }
        else if (c > a && c > b)
        {
            biggest = c;
        }
        Console.WriteLine("The biggest number is {0}", biggest);
    }
}