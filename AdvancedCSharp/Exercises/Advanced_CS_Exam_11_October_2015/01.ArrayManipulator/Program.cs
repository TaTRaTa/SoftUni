namespace _01.ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static int[] number;

        public static void Main()
        {
            number = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                string[] arg = input.Split();
                string command = arg[0].ToLower();

                if (arg.Length == 2)
                {
                    if (command == "exchange")
                    {
                        int index = int.Parse(arg[1]);
                        Exchange(index);
                    }
                    else if (command == "max" || command == "min")
                    {
                        string oddOrEven = arg[1];
                        KindOfCommandMaxOrMin(command, oddOrEven);
                    }
                    else
                    {
                        throw new ArgumentException("Command should be MAX MIN or EXCHANGE (lowercase)");
                    }
                }
                else if (arg.Length == 3)
                {
                    int element = int.Parse(arg[1]);
                    string oddOrEven = arg[2];

                    if (command == "first")
                    {
                        First(element, oddOrEven);
                    }
                    else if (command == "last")
                    {
                        Last(element, oddOrEven);
                    }
                    else
                    {
                        throw new ArgumentException("Command should be FIRST or LAST (lowercase)");
                    }
                }

                input = Console.ReadLine().ToLower();
            }

            Console.Write("[");
            Console.Write(string.Join(", ", number));
            Console.WriteLine("]");
        }

        private static void KindOfCommandMaxOrMin(string maxOrMin, string oddOrEven)
        {
            if (maxOrMin == "max")
            {
                if (oddOrEven == "odd")
                {
                    MaxOdd();
                }
                else
                {
                    MaxEven();
                }
            }
            else if (maxOrMin == "min")
            {
                if (oddOrEven == "odd")
                {
                    MinOdd();
                }
                else
                {
                    MinEven();
                }
            }
            else
            {
                throw new ArgumentException("Should be Max or Min");
            }
        }

        private static void Last(int element, string oddOrEven)
        {
            List<int> result = new List<int>();

            if (number.Length < element)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            List<int> list = new List<int>();

            if (oddOrEven == "odd")
            {
                for (int i = 0; i < number.Length; i++)
                {
                    if (number[i] % 2 == 1)
                    {
                        list.Add(number[i]);
                    }
                }

                list.Reverse();

                if (list.Count != 0)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (i < element)
                        {
                            result.Add(list[i]);
                        }
                    }

                    result.Reverse();

                    Console.Write("[");
                    Console.Write(String.Join(", ", result));
                    Console.WriteLine("]");
                }
                else
                {
                    Console.WriteLine("[]");
                }
            }
            else
            {
                for (int i = 0; i < number.Length; i++)
                {
                    if (number[i] % 2 == 0)
                    {
                        list.Add(number[i]);
                    }
                }

                list.Reverse();

                if (list.Count != 0)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (i < element)
                        {
                            result.Add(list[i]);
                        }
                    }

                    result.Reverse();

                    Console.Write("[");
                    Console.Write(String.Join(", ", result));
                    Console.WriteLine("]");
                }
                else
                {
                    Console.WriteLine("[]");
                }
            }
        }

        private static void First(int element, string oddOrEven)
        {
            List<int> result = new List<int>();

            if (number.Length < element)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            List<int> list = new List<int>();
            if (oddOrEven == "odd")
            {
                for (int i = 0; i < number.Length; i++)
                {
                    if (number[i] % 2 == 1)
                    {
                        list.Add(number[i]);
                    }
                }

                if (list.Count != 0)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (i < element)
                        {
                            result.Add(list[i]);
                        }
                    }

                    Console.Write("[");
                    Console.Write(string.Join(", ", result));
                    Console.WriteLine("]");
                }
                else
                {
                    Console.WriteLine("[]");
                }
            }
            else
            {
                for (int i = 0; i < number.Length; i++)
                {
                    if (number[i] % 2 == 0)
                    {
                        list.Add(number[i]);
                    }
                }

                if (list.Count != 0)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (i < element)
                        {
                            result.Add(list[i]);
                        }
                    }

                    Console.Write("[");
                    Console.Write(String.Join(", ", result));
                    Console.WriteLine("]");
                }
                else
                {
                    Console.WriteLine("[]");
                }
            }
        }

        private static void MaxOdd()
        {
            Dictionary<int, int> temp = new Dictionary<int, int>();
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 == 1)
                {
                    if (temp.ContainsKey(number[i]))
                    {
                        temp[number[i]] = i;
                        continue;
                    }

                    temp.Add(number[i], i);
                }
            }

            if (temp.Count == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                int max = temp.Keys.Max();
                Console.WriteLine(temp[max]);
            }
        }

        private static void MaxEven()
        {
            Dictionary<int, int> temp = new Dictionary<int, int>();
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 == 0)
                {
                    if (temp.ContainsKey(number[i]))
                    {
                        temp[number[i]] = i;
                        continue;
                    }

                    temp.Add(number[i], i);
                }
            }

            if (temp.Count == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                int max = temp.Keys.Max();
                Console.WriteLine(temp[max]);
            }
        }

        private static void MinOdd()
        {
            Dictionary<int, int> temp = new Dictionary<int, int>();
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 == 1)
                {
                    if (temp.ContainsKey(number[i]))
                    {
                        temp[number[i]] = i;
                        continue;
                    }

                    temp.Add(number[i], i);
                }
            }

            if (temp.Count == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                int min = temp.Keys.Min();
                Console.WriteLine(temp[min]);
            }
        }

        private static void MinEven()
        {
            Dictionary<int, int> temp = new Dictionary<int, int>();
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 == 0)
                {
                    if (temp.ContainsKey(number[i]))
                    {
                        temp[number[i]] = i;
                        continue;
                    }

                    temp.Add(number[i], i);
                }
            }

            if (temp.Count == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                int min = temp.Keys.Min();
                Console.WriteLine(temp[min]);
            }
        }

        private static void Exchange(int index)
        {
            if (number.Length <= index || index < 0)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                List<int> fList = new List<int>();
                List<int> sList = new List<int>();

                for (int i = 0; i < number.Length; i++)
                {
                    if (i > index)
                    {
                        sList.Add(number[i]);
                    }
                    else
                    {
                        fList.Add(number[i]);
                    }
                }

                sList.AddRange(fList);

                for (int i = 0; i < number.Length; i++)
                {
                    number[i] = sList[i];
                }
            }
        }
    }
}
