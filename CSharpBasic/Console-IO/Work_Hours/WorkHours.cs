using System;

class WorkHours
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());
            
        // h - (((d * 0.9) * 12) * (p/100));
        int workHours = (int)(((d * 0.9) * 12) * (p / 100));
        
        if (workHours < h)
        {
            Console.WriteLine("No");
            Console.WriteLine("{0}", workHours - h);
        }
        else
        {
            Console.WriteLine("Yes");
            Console.WriteLine("{0}", workHours - h);
        }
        

    }
}