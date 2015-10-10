using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Write an expression that calculates rectangle’s perimeter and area by given width and height.");
        Console.Write( "a = " );
        double a = double.Parse(Console.ReadLine());
        Console.Write( "b = " );
        double b = double.Parse(Console.ReadLine());
        double perimeter = (2 * a) + (2 * b);
        Console.WriteLine("perimeter is " + perimeter);
        double area = a * b;
        Console.WriteLine("area is " + area);

    }
}