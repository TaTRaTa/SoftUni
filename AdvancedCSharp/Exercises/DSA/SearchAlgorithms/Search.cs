namespace SearchAlgorithms
{
    using System;
    using System.Diagnostics;

    public static class Search
    {
        public static int? LinerSearch(int[] nums, int search)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int len = nums.Length;
            for (int i = 0; i < len; i++)
            {
                if (nums[i] == search)
                {
                    sw.Stop();
                    Console.WriteLine(sw.Elapsed);

                    return nums[i];
                }
            }

            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            return null;
        }

        public static int? BinarySearch(int[] nums, int search)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int start = 0;
            int end = nums.Length - 1;
            int average = (start + end) / 2;

            while (search != nums[average])
            {
                if (start > end)
                {
                    sw.Stop();
                    Console.WriteLine(sw.Elapsed);

                    return null;
                }

                if (search == nums[average])
                {
                    return nums[average - 1];
                }
                else if (search > nums[average])
                {
                    start = average + 1;
                    average = (start + end) / 2;
                }
                else if (search < nums[average])
                {
                    end = average - 1;
                    average = (start + end) / 2;
                }
            }

            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            return nums[average];
        }

        public static int? BinarySearchWithRecursion(int[] nums, int search, int start, int end)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int average = (start + end) / 2;

            while (search != nums[average])
            {
                if (start > end)
                {
                    sw.Stop();
                    Console.WriteLine(sw.Elapsed);
                    return null;
                }

                if (search < nums[average])
                {
                    end = average - 1;
                    return BinarySearchWithRecursion(nums, search, start, end);
                }
                else
                {
                    start = average + 1;
                    return BinarySearchWithRecursion(nums, search, start, end);
                }
            }

            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            return nums[average];
        }

        public static int? InterpolationSearch(int[] nums, int search)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int? result = null;
            int start = 0;
            int end = nums.Length - 1;
            int mid = 0;
            while (start <= end)
            {
                if (nums[start] == nums[end])
                {
                    if (nums[start] == search)
                    {
                        sw.Stop();
                        Console.WriteLine(sw.Elapsed);

                        result = nums[start];
                        return result;
                    }
                    else
                    {
                        sw.Stop();
                        Console.WriteLine(sw.Elapsed);

                        return result;
                    }
                }

                double k = (search - nums[start]) / (nums[end] - nums[start]);
                if (k < 0 || k > 1)
                {
                    sw.Stop();
                    Console.WriteLine(sw.Elapsed);

                    return result;
                }

                mid = (int)Math.Round(start + k * (end - start));

                if (search < nums[mid])
                {
                    end = mid - 1;
                }
                else if (search > nums[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    sw.Stop();
                    Console.WriteLine(sw.Elapsed);
                    result = nums[mid];

                    return result;
                }
            }

            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            return null;
        }
    }
}
