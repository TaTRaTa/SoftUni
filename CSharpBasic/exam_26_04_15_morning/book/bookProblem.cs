using System;

class bookProblem
{
    static void Main()
    {
        
        int pagesOfTheBook = int.Parse(Console.ReadLine());
        int campingDaysInAMonth = int.Parse(Console.ReadLine());
        int pagesWhichStefanReadsEveryNormalDay = int.Parse(Console.ReadLine());
        
        if (campingDaysInAMonth == 30 || pagesWhichStefanReadsEveryNormalDay == 0)
        {
            Console.WriteLine("never");
            return;
        }
        int freeDaysforbook = 30 - campingDaysInAMonth;
        int pages = freeDaysforbook * pagesWhichStefanReadsEveryNormalDay;
        
        int months = (int)Math.Ceiling((double)pagesOfTheBook / pages);
        // X = years
        int X = months / 12;
        // Y = monts
        int Y = months % 12;
        Console.WriteLine("{0} years {1} months" , X , Y);
   
    }
}
