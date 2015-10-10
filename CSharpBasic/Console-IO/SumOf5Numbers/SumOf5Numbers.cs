using System;

class SumOf5Numbers
{
    static void Main()
    {
        double n1 = double.Parse(Console.ReadLine());
        double n2 = double.Parse(Console.ReadLine());
        double n3 = double.Parse(Console.ReadLine());
        double n4 = double.Parse(Console.ReadLine());
        double n5 = double.Parse(Console.ReadLine());
        Console.WriteLine("{0} {1} {2} {3} {4} {5} ", n1, n2, n3, n4, n5,(n1+n2+n3+n4+n5));

    }
}