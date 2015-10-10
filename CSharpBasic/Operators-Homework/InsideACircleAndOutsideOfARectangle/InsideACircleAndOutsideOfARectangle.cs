using System;

class InsideACircleAndOutsideOfARectangle
{
    static void Main()
    {
        Console.WriteLine("Enter coordinates x and y for circle K({1.1}, 1.5 ):");
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
         //if (((x - 1) * (x - 1)) + ((y -1) * (y - 1)) <= (1.5 * 1.5) && (x <= 2.5 && x >= -0.5) && (y <= 2.5 && y > 1))
        if ((Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2) <= Math.Pow(1.5, 2)) && (x <= 2.5 && x >= -0.5) && (y <= 2.5 && y > 1))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}