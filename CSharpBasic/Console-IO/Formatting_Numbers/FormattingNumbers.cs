using System;

class FormattingNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        while (a<0 || a>500)
        {
            Console.WriteLine("Invalid intput. Please try again ");
            a = int.Parse(Console.ReadLine());
        }

        
        
        decimal b = decimal.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());
        Console.WriteLine("|{0,-10:X}|{1}|{2,10:F2}|{3,-10:F3}|",a,Convert.ToString(a, 2).PadLeft(10, '0'),b,c);

    }
}