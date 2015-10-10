namespace Arrays
{
    using System;
    using System.Linq;

    public class ArraysMain
    {
        

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());
            long[] array = new long[sizeOfArray];
            array = Console.ReadLine().Split().Select(long.Parse).ToArray();

            string command = Console.ReadLine();

            while (!command.Equals("stop"))
            {
                string[] stringParams = command.Split();
                int[] args = new int[2];
                command = stringParams[0]; // command
                if (stringParams.Length > 1)
                {
                    args[0] = int.Parse(stringParams[1]); // first arg
                    args[1] = int.Parse(stringParams[2]); // second arg
                }
                
                

                if (command == "add"    || command == "subtract" || command == "multiply" ||
                    command == "lshift" || command == "rshift")
                {
                   array = PerformAction(array, command, args);
                }

                PrintArray(array);
                //Console.WriteLine('\n');

                command = Console.ReadLine();
            }
        }

        static long[] PerformAction(long[] arr, string action, int[] args)
        {
            long[] array = arr.Clone() as long[];
            int pos = args[0];
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[pos - 1] *= value;
                    break;
                case "add":
                    array[pos - 1] += value;
                    break;
                case "subtract": 
                    array[pos - 1] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(array);
                    break;
                case "rshift":
                    ArrayShiftRight(array);
                    break;                  
            }
            return array;
        }

        private static void ArrayShiftRight(long[] array)
        {
            long temp = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = temp;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long temp = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {                
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = temp;
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
                if (i == array.Length - 1)
                {
                    Console.WriteLine();    
                }
            }
        }
    }
}
