using System;

class torentPirate
{
    static void Main()
    {
        decimal isTotalMB = decimal.Parse(Console.ReadLine());
        int isMoneyForCinema = int.Parse(Console.ReadLine());
        decimal isMoneyPerHour = decimal.Parse(Console.ReadLine());
         const int seconds = 60;
         const int minutes = 60;
         const decimal fixedSpeed = 2.0M;
         const int moviesOfSize = 1500;

        decimal downloadTimeInHours = isTotalMB / fixedSpeed / seconds / minutes;
        decimal PriceForDownload = downloadTimeInHours * isMoneyPerHour;

        decimal numberOfMoviesDownloaded = isTotalMB / moviesOfSize;
        decimal cinemaPrice = numberOfMoviesDownloaded * isMoneyForCinema;
        if (PriceForDownload != cinemaPrice )
        {
            if (PriceForDownload < cinemaPrice)
            {
                Console.WriteLine("mall -> {0:f2}lv", PriceForDownload);
            }
            else
            {
                Console.WriteLine("cinema -> {0:f2}lv",cinemaPrice);
            }
        }
        else
        {
            Console.WriteLine("mall -> {0:f2}lv", PriceForDownload);
        }

    }
}