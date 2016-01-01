using System;
using System.Collections.Generic;
using System.Linq;

namespace Algo_2
{
    class subset
    {
        static void Main()
        {
            Console.WriteLine("Please enter range of numbers");
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Console.WriteLine("please enter target");
            int targetSum = int.Parse(Console.ReadLine());
            var result = CalcSubset(numbers, targetSum);

            if (result.ContainsKey(targetSum))
            {
                var subset = FindSubset(numbers, targetSum, result);

                Console.Write("result: " + targetSum + " = ");
                Console.WriteLine(string.Join(" + ", subset));
            }

        }

        public static IDictionary<int, int> CalcSubset(int[] nums, int targetSum)
        {
            var possibleSum = new Dictionary<int, int> { { 0, 0 } };
            for (int i = 0; i < nums.Length; i++)
            {
                var newSums = new Dictionary<int, int>();
                foreach (var sum in possibleSum.Keys)
                {
                    int newSum = sum + nums[i];
                    if (!possibleSum.ContainsKey(newSum))
                    {
                        newSums.Add(newSum, nums[i]);
                    }
                }
                foreach (var sum in newSums)
                {
                    possibleSum.Add(sum.Key, sum.Value);
                }


            }
            return possibleSum;
        }

        public static IEnumerable<int> FindSubset(int[] nums, int targetSum, IDictionary<int, int> possibleSums)
        {
            var subset = new List<int>();
            while (targetSum > 0)
            {
                var lastNum = possibleSums[targetSum];
                subset.Add(lastNum);
                targetSum -= lastNum;
            }
            return subset;
        }
    }
}