using System;

class TravellerBob
{
    static void Main()
    {
        string kindOfYear = Console.ReadLine();
        int contract = int.Parse(Console.ReadLine());
        int monthsWithFamily = int.Parse(Console.ReadLine());
        double travels = 3 * 4;
        double monthsTravels = travels * contract;

        double travelWithFamily = (monthsWithFamily * 2) * 2;

        double normalMonths = 12 - contract - monthsWithFamily;
        double sumTravels = (travels * normalMonths) * 0.6;

        if (kindOfYear == "leap")
        {
            double additional = (monthsTravels + travelWithFamily + sumTravels) * 0.05;
            int totalTravel = (int)(monthsTravels + travelWithFamily + sumTravels + additional);
            Console.WriteLine(totalTravel);
        }
        else
        {
            int totalTravel = (int)(monthsTravels + travelWithFamily + sumTravels);
            Console.WriteLine(totalTravel);
        }

    }
}