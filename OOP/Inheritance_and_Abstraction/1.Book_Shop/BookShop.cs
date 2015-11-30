using System;


namespace _1.Book_Shop
{
    class BookShop
    {
        static void Main()
        {
            Book book1 = new Book("emo", "Emil Davidkov", 1000000m);
            Console.WriteLine(book1);

            GoldenEditionBook book2 = new GoldenEditionBook("Ceko", "Ceko Cekov", 2000000m);
            Console.WriteLine(book2);
        }
    }
}
