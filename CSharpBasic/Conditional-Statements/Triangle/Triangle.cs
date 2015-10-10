﻿using System;

class Triangle
{
    static void Main()
    {
        int Ax = int.Parse(Console.ReadLine());
        int Ay = int.Parse(Console.ReadLine());
        int Bx = int.Parse(Console.ReadLine());
        int By = int.Parse(Console.ReadLine());
        int Cx = int.Parse(Console.ReadLine());
        int Cy = int.Parse(Console.ReadLine());
        double a = Math.Sqrt(Math.Pow((Cx - Ax), 2) + Math.Pow((Cy - Ay), 2));
        double b = Math.Sqrt(Math.Pow((Bx - Cx), 2) + Math.Pow((By - Cy), 2));
        double c = Math.Sqrt(Math.Pow((Bx - Ax), 2) + Math.Pow((By - Ay), 2));
        double halfPerimeter = (a + b + c) / 2;
        if (a + b > c && b + c > a && a + c > b)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("{0:F2}", Math.Sqrt(halfPerimeter * (halfPerimeter - a) *
                (halfPerimeter - b) * (halfPerimeter - c)));
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:F2}", Math.Sqrt(Math.Pow((Bx - Ax), 2) + Math.Pow((By - Ay), 2)));
        }
    }
}
