namespace SearchAlgorithms
{
    using System;

    public class Engine
    {
        public Engine()
        {
        }

        public void Run()
        {
            int[] nums = { 1, 3, 5, 7, 9, 12, 18 };

            Console.WriteLine("Enter search number...");
            int search = int.Parse(Console.ReadLine());

            Console.WriteLine(
                "Please enter kind of Search:\n 1 --> LinerSearch,\n 2 --> BinarySearch,\n 3 --> Binary with recursion,\n 4 --> Interpolation,\n 5 --> Chacked all searches for time");
            int condtions = int.Parse(Console.ReadLine());
            int? result = TypeOfSearch(condtions, nums, search);

            try
            {
                Print.PrintFindDigit(result);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine();
                Console.WriteLine("Please try again...");

                this.Run();
            }
        }

        private static int? TypeOfSearch(int conditions, int[] nums, int search)
        {
            int? result;
            switch (conditions)
            {
                case 1:
                    result = Search.LinerSearch(nums, search);
                    return result;
                case 2:
                    result = Search.BinarySearch(nums, search);
                    return result;
                case 3:
                    result = Search.BinarySearchWithRecursion(nums, search, 0, nums.Length - 1);
                    return result;
                case 4:
                    result = Search.InterpolationSearch(nums, search);
                    return result;
                case 5:
                    result = Search.LinerSearch(nums, search);

                    result = Search.BinarySearch(nums, search);

                    result = Search.BinarySearchWithRecursion(nums, search, 0, nums.Length);

                    result = Search.InterpolationSearch(nums, search);

                    return result;

                default:
                    result = null;
                    return result;
            }
        }
    }
}
