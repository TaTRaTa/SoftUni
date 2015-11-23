using System;
using System.Text.RegularExpressions;

namespace _1.Square_Root
{
    class SquareRoot
    {
        static void Main()
        {
            //int input = ReadInteger();
            try
            {
                int input = int.Parse(Console.ReadLine());
                if (input < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                 else if (!input.Equals(@"\\d+"))
                {
                    throw new FormatException();
                }
                 else
                {
                    Console.WriteLine(Math.Sqrt((double)input));
                }
                

            }
            catch (Exception ex)
            {

                if ((ex is ArgumentOutOfRangeException) )
                {
                    Console.WriteLine("Invalid number (ArgumentOutOfRangeException)");
                }
                else if (ex is FormatException)
                {
                    Console.WriteLine("Invalid number (FormatException)");
                }
                
                
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }

        //private static int ReadInteger()
        //{
        //    var input = Console.ReadLine();

        //    try
        //    {
        //        return int.Parse(input);
        //    }
        //    catch (Exception)
        //    {

        //        Console.WriteLine("Please enter integer:");
        //        return ReadInteger();
        //    }
        //}
    }
}
