using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool odd = n % 2 != 0 ? true : false;
        Console.WriteLine(odd);
    }
}