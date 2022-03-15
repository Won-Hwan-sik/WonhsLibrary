using System;
using WonhsLibrary;

namespace WonhsLibrary.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 7, 109, 67, 87, 2 };

            int[] result = Test.Library.SelectionSort(data);

            foreach (var n in result)
            {
                Console.WriteLine($"{n}");
            }
        }
    }
}
