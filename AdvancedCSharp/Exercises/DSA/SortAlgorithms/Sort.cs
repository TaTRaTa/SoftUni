namespace SortAlgorithms
{
    using System;
    using System.Diagnostics;

    public static class Sort
    {
        public static void Bubble(int[] arr)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }

        public static void Selection(int[] arr)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            int temp = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }

        public static void Insertion(int[] arr)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();

            for (int i = 1; i < arr.Length; i++)
            {
                int value = arr[i];
                int index = i;

                while (index > 0 && arr[index - 1] > value)
                {
                    arr[index] = arr[index - 1];
                    index--;
                }

                arr[index] = value;
            }

            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }

        public static void Merge(int[] arr)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();

            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }
    }
}
