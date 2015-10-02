using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Disk
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); // board => x and y == n
        int r = int.Parse(Console.ReadLine()); // radius
        int center = n / 2;
        for (int x = 0; x < n; x++)
        {
            for (int y = 0; y < n; y++)
            {
                          
                if (r * r >= Math.Pow(center - x, 2) + Math.Pow(center - y, 2))
                    //formula => r*r == x*x + y*y
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }                
            }
            Console.WriteLine();
        }
    }
}

