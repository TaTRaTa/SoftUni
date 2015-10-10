using System;

class Volleyball
{
    static void Main()
    {
        
       // Console.WriteLine("'leap' or 'normal' year ?");
        string year = Console.ReadLine();
        //Console.WriteLine("how many holidays does he have ?");
        int p = int.Parse(Console.ReadLine());
        //Console.WriteLine("how many weekends does he have ?");
        int h = int.Parse(Console.ReadLine());
        double? result = null;

        
        
            if (year == "leap")
            {
                result = (h + ((48 - h) * 0.75) + (p * 0.66)) * 1.15;
            }
            else if (year == "normal")
            {
                result = h + ((48 - h) * 0.75) + (p * 0.66);
            }
           /* else if (result == null)
            {
                Console.WriteLine("error");
                return;
            } */
            Console.WriteLine(/*"result is {0}", */(int)result);
        
    }
}