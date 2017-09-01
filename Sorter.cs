using System.Linq;
using System.Collection;

namespace QuickSort
{ 
	public static class Sorter
	{
		public void Sort(IEnumerable<int> ArrayToSort, int indexBeginLocal, int indexEnd)
		{
			if (ArrayToSort==null || !ArrayToSort.Any() ||ArrayToSort.Take(2).Count == 1 )
			{
				return ArrayToSort;
			}	
			var indexBeginLocal = indexBegin, indexEndLocal = indexEndLocal;
			var length = indexEndLocal-indexBeginLocal;
			var indexPivot = indexBeginLocal + length/2
			var pivot = ArrayToSort[indexPivot];

			while(true)
			{
				if (indexBeginLocal >=indexEndLocal)
				{
					Sort(ArrayToSort, indexBegin, indexPivot-1);
					Sort(ArrayToSort, indexPivot, indexEnd);
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