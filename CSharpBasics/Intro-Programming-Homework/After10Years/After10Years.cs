using System;

class After10Years
{
    static void Main()
    {
        Console.WriteLine("today is " + DateTime.Now);
        DateTime MyBday=new DateTime(1989,08,16);
        DateTime Todayis = DateTime.Now;
        var MyAge = Todayis.Year - MyBday.Year;
        Console.WriteLine("My Age is " + MyAge );
        var AgeFuture = MyAge + 10;
        Console.WriteLine("After10Years " + AgeFuture);
        
    }
}