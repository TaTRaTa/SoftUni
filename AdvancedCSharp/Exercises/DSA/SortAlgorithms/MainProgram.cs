namespace SortAlgorithms
{
    using System;
    using System.Collections.Generic;
    class MainProgram
    {
        static void Main()
        {
            int[] arr = {45, 123, 31, 36, 234, 65, 12, 56, 1, 5, 8, 91, 0, 10};
            Sort.Bubble(arr);
            arr = new []{ 45, 123, 31, 36, 234, 65, 12, 56, 1, 5, 8, 91, 0, 10};
            Sort.Selection(arr);
            
            arr = new []{ 45, 123, 31, 36, 234, 65, 12, 56, 1, 5, 8, 91, 0, 10};
            Sort.Insertion(arr);

            
        }
    }
}
