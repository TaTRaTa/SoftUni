using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Write("weight on the Earth of a man is   ");
        double weight = double.Parse(Console.ReadLine());
        Console.WriteLine("weight of a man on the moon is  "+ (weight*0.17));
    }
}