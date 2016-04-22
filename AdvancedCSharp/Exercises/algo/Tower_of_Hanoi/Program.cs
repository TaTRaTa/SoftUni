using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tower_of_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> source = new Stack<int>(Enumerable.Range(1, 3).Reverse());
            Stack<int> temporary = new Stack<int>();
            Stack<int> destination = new Stack<int>();
            int disk = source.Count;

            Move(disk, source, destination, temporary);

            Console.WriteLine(string.Join(" ", destination));
        }

        private static void Move(int disk, Stack<int> source, Stack<int> destination, Stack<int> temporary)
        {
            if (disk < 1)
            {
                return;
            }

            Move(disk - 1, source, temporary, destination);

            destination.Push(disk);
            source.Pop();

            Move(disk - 1, temporary, destination, source);

        }
    } 
}
