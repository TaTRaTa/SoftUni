using System;
using System.Collections.Generic;

namespace _2.Enter_Numbers
{
    class EnterNumbers
    {
        public static List<int> list = new List<int>();
        public static int checkint = 11;

        private static void Main()
        {            
            const int START = 1;
            const int END = 100;

            while(checkint != 1) { 
                string input = Console.ReadLine();
                ReadNumber(input, START, END);
            }
        }

        private static void ReadNumber(string input, int start, int end)
        {           
            int num;
            bool isTrue = int.TryParse(input, out num);
            list.Add(num);
            checkint --;

            if (list.Count == 1)
            {
                if (!isTrue )
                {
                    list.RemoveAt(list.Count - 1);
                    Console.WriteLine("non-number");
                    checkint++;
                }
                if (num < start || num >= end - checkint)
                {
                    list.RemoveAt(list.Count - 1);
                    Console.WriteLine("invalid number");
                    checkint++;
                }
                
                return;
            }

            try
            {              
                if (isTrue)
                {
                    if (num < start || num > end - checkint || list[list.Count - 2] >= num)
                    {
                        list.RemoveAt(list.Count - 1);
                        checkint++;
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
            }
        }
    }
}
