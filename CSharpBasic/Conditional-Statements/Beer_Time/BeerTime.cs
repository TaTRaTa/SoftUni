using System;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        string choiceTime = Console.ReadLine();
        string format = "h:mm tt";
//        DateTime enterTime = DateTime.ParseExact(choiceTime, format, CultureInfo.InvariantCulture);
        DateTime enterTime = DateTime.ParseExact( choiceTime , format ,CultureInfo.InvariantCulture );
        DateTime start = DateTime.Parse("1:00 PM" );
        DateTime end = DateTime.Parse("3:00 AM");
        if (enterTime >= start || enterTime < end)
        {
            Console.WriteLine("beer time");
        }
        else
        {
            Console.WriteLine("non-beer time");
        }
    }
}
