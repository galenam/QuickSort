using System;
using System.Linq;
using System.Collections.Generic;

namespace QuickSort
{ 
	public static class Sorter
	{

		public static void Sort(IEnumerable<int> ArrayToSort)
		{
			// todo : добавить проверку на пустоту
			SortInner(ArrayToSort, 0, ArrayToSort.Count());
		}

		private static void SortInner(IEnumerable<int> ArrayToSort, int indexBegin, int indexEnd)
		{
			if (ArrayToSort==null || !ArrayToSort.Any() || ArrayToSort.Take(2).Count() == 1 )
			{
				return;
			}	
			var indexBeginLocal = indexBegin, indexEndLocal = indexEndLocal;
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