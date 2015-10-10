using System;

class ZeroSubset
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());

        if (a + b + c + d ==0 || a + b + c + e == 0 || a + b + d + e == 0 || a + c + d + e == 0 || b + c + d + e == 0)
        {
            Console.WriteLine("sum of four numbers is = 0");
            if (a + b == 0 || a + b + d == 0 || a + b + e == 0 || a + c + d == 0 || a + c + e == 0 || a + d + e == 0 || b + c + d == 0 || b + c + e == 0 || b + d + e == 0)
            {
                Console.WriteLine("sum of three numbers is = 0");
                if (a + b == 0 || a + c == 0 || a + d == 0 || a + e == 0 || b + c == 0 || b + d == 0 || b + e == 0 || c + d == 0 || c + e == 0 || d + e == 0)
                {
                    Console.WriteLine("sum of two numbers is = 0");
                }
            }
        }
        else
        {
            Console.WriteLine(" no zero subset");
        }
    }
}