using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Write an expression that calculates trapezoid's area by given sides a and b and height h.");
        Console.WriteLine(" 'a' is ...");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine(" 'b' is ...");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine(" 'h' is ...");
        double h = double.Parse(Console.ReadLine());

        double area = ( ( a + b ) / 2 ) * h;
        Console.WriteLine("area is " + area);
    }
}