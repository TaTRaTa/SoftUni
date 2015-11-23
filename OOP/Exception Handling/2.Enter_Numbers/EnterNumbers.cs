using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace _2.Enter_Numbers
{
    class EnterNumbers
    {
        public static List<int> list = new List<int>(); 
        private static void Main()
        {
            
            const int START = 1;
            const int END = 100;
            for (int i = 0; i < 10; i++)
            {
                string input = Console.ReadLine();
                ReadNumber(input, START, END);


            }
            

        }

        private static void ReadNumber(string input, int start, int end)
        {
            
            int num;
            bool isTrue = int.TryParse(input, out num);
            list.Add(num);
            if (list.Count - 1 != null)
            {
                try
                {
                    if (isTrue)
                    {
                        if (num < start || num > end || list.Count - 1 >= num)
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                    }
                    else
                    {
                        Console.WriteLine("non-number");
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("invalid number");
                    ;
                }
                
            }
            
            

        }
    }
}
