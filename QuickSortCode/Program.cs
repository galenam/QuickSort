using System;
using System.Collections.Generic;

namespace QuickSort
{
    class Program
    {
        // http://blog.cybdev.org/algoritm-bystroy-sortirovki-quick-sort-algorithm
        static void Main(string[] args)
        {
			var items = new List<int> { 3,5,7,25,89,2,5,7,9,3,68,0,3,3,7,9};		

            foreach (var item in items)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Sorter.Sort(items);
            foreach (var item in items)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
