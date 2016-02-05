namespace SearchAlgorithms
{
    using System;

    public class Print
    {
        public static void PrintFindDigit(int? result)
        {
            if (result == null)
            {
                throw new ArgumentNullException("Cannot be Find result");
            }
            else
            {
                Console.WriteLine("result: {0}", result);
            }
        }
    }
}
