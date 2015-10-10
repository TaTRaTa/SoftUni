using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.WriteLine("Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time");
        int n = int.Parse(Console.ReadLine());
        bool number = ((n % 1 == 0) && (n % 5 == 0) && (n % 7 == 0));
        Console.WriteLine(number);
    }
}