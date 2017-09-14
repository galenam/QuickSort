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
			var countOfPivot = 1;
			while(countOfWays++<indexEnd)
			{
				if (ArrayToSort[i]>=pivot){
					int indexInsert=0;
					if (ArrayToSort[i]==pivot){
						indexInsert = indexPivot+1;
						countOfPivot++;
					}
					else
					{
						 indexInsert = indexEnd+1;
					}
					ArrayToSort.Insert(indexInsert, ArrayToSort[i]);
					ArrayToSort.RemoveAt(i);					
					indexPivot--;
					continue;
				}
				i++;
			}
			if (indexBegin<indexPivot-1){
				SortInner(ArrayToSort, indexBegin, indexPivot-1);
			}
			if (indexPivot+countOfPivot< indexEnd){
				SortInner(ArrayToSort, indexPivot+1, indexEnd);
			}
		}
	}
}