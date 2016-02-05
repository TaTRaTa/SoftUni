using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _02.ArraySlider
{
    class Program
    {
        public static int currentIndex = 0;
        static void Main()
        {
            BigInteger[] nums = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries).Select(BigInteger.Parse).ToArray();

            string input = Console.ReadLine();

            while (input != "stop")
            {
                string[] command = input.Split();
                ExecuteOperation(command, nums);
                input = Console.ReadLine();
            }
            Console.Write("[");
            Console.Write(string.Join(", ", nums));
            Console.WriteLine("]");
        }

        private static void ExecuteOperation(string[] command, BigInteger[] nums)
        {
            int offset = int.Parse(command[0].Trim()) % nums.Length;
            char operation = char.Parse(command[1].Trim());
            int operand = int.Parse(command[2].Trim());

            if (offset < 0)
            {
                offset += nums.Length;
            }

            currentIndex = (currentIndex + offset) % nums.Length;

            switch (operation)
            {
                case '+':
                    nums[currentIndex] += operand;
                    break;
                case '/':
                    nums[currentIndex] /= operand;
                    break;
                case '*':
                    nums[currentIndex] *= operand;
                    break;
                case '-':
                    nums[currentIndex] -= operand;
                    break;
                case '&':
                    nums[currentIndex] &= operand;
                    break;
                case '^':
                    nums[currentIndex] ^= operand;
                    break;
                case '|':
                    nums[currentIndex] |= operand;
                    break;
            }

            if (nums[currentIndex] < 0)
            {
                nums[currentIndex] = 0;
            }
        }
    }
}
