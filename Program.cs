﻿using System;

namespace QuickSort
{
    class Program
    {
        // https://ru.wikipedia.org/wiki/%D0%91%D1%8B%D1%81%D1%82%D1%80%D0%B0%D1%8F_%D1%81%D0%BE%D1%80%D1%82%D0%B8%D1%80%D0%BE%D0%B2%D0%BA%D0%B0
        static void Main(string[] args)
        {
            var array = new int[]{1,2,3,4};
            foreach (var item in new Sorter(array).Sort())
            {
                Console.Write()
            }
        }
    }
}
