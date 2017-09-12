using System;
using System.Linq;
using System.Collections.Generic;

namespace QuickSort
{ 
	public static class Sorter
	{
		public static void Sort(List<int> ArrayToSort)
		{
			if (ArrayToSort==null || !ArrayToSort.Any() || ArrayToSort.Take(2).Count() == 1 )
			{
				return;
			}
			SortInner(ArrayToSort, 0, ArrayToSort.Count-1 );
		}

		private static void SortInner(List<int> ArrayToSort, int indexBegin, int indexEnd)
		{	
			var pivot = ArrayToSort[indexEnd];
			var i=indexBegin;
			var countOfWays = indexBegin;
			var indexPivot = indexEnd;
			while(countOfWays++<indexEnd)
			{
				// если ArrayToSort[i]=pivot надо вставлять прямо после pivot, а не в конец, считатать количество элементов =pivot и проматывать их 
				// при вложенных  SortInner
				if (ArrayToSort[i]>=pivot){
					// во вложенных SortInner нужно добавлять не в конец массива ArrayToSort.Add, а вставлять в конец подмассива ArrayToSort[indexEnd]
					ArrayToSort.Add(ArrayToSort[i]);
					ArrayToSort.RemoveAt(i);					
					indexPivot--;
					continue;
				}
				i++;
			}
			if (indexBegin<indexPivot-1){
				SortInner(ArrayToSort, indexBegin, indexPivot-1);
			}
			if (indexPivot+1< indexEnd){
				SortInner(ArrayToSort, indexPivot+1, indexEnd);
			}
		}
	}
}