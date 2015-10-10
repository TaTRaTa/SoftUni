using System;

class CheckaBitatGivenPosition
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p ;
        int bite = (n & mask) >> p;
        bool check = bite == 1;
        Console.WriteLine(check);


    }
}