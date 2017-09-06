using System;
using System.Linq;
using System.Collections.Generic;

namespace QuickSort
{ 
	public static class Sorter
	{

		public static void Sort(int[] ArrayToSort)
		{
			if (ArrayToSort==null) {return;}
			SortInner(ArrayToSort, 0, ArrayToSort.Length );
		}

		private static void SortInner(int[] ArrayToSort, int indexBegin, int indexEnd)
		{
			if (ArrayToSort==null || !ArrayToSort.Any() || ArrayToSort.Take(2).Count() == 1 )
			{
				return;
			}	
			var indexBeginLocal = indexBegin;
			var indexEndLocal = indexEnd;
			var length = indexEndLocal-indexBeginLocal;
			var indexPivot = indexBeginLocal + length/2;
			var pivot = ArrayToSort[indexPivot];

			while(true)
			{
				if (indexBeginLocal >=indexEndLocal)
				{
					SortInner(ArrayToSort, indexBegin, indexPivot-1);
					SortInner(ArrayToSort, indexPivot, indexEnd);
					break;
				}
				if (ArrayToSort[indexBeginLocal]> pivot && ArrayToSort[indexEndLocal]< pivot)
				{
					var tempElement = ArrayToSort[indexBeginLocal];
					ArrayToSort[indexBeginLocal] = ArrayToSort[indexEndLocal];
					ArrayToSort[indexEndLocal] = tempElement;
					indexBeginLocal++;
					indexEndLocal--;
				}

				if (ArrayToSort[indexBeginLocal]<= pivot && ArrayToSort[indexEndLocal] > pivot)
				{
					indexBeginLocal++;
					indexEndLocal--;
				}

				if (ArrayToSort[indexBeginLocal]>pivot && ArrayToSort[indexEndLocal] > pivot)
				{
					indexEndLocal--;
				}

				if (ArrayToSort[indexBeginLocal] <=pivot && ArrayToSort[indexEndLocal] < pivot)
				{
					indexBeginLocal++;
				}
			}
		}
	}
}