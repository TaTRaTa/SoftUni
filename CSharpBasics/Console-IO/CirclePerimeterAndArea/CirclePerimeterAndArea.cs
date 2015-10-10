using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double area = Math.PI * Math.Pow(r, 2);
        double perimeter = 2 * Math.PI * r;
        Console.WriteLine("r= {0} perimeter ={1:F2} area = {2:#.##}", r, perimeter, area);
    }
}