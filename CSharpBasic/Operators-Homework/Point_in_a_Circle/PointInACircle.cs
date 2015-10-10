using System;

class PointInACircle
{
    static void Main()
    {
        Console.WriteLine("Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). ");
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        bool circle = (x * x) + (y * y) <= (2 * 2);
        Console.WriteLine("These coordinates are inside the circle = " + circle);
    }
}