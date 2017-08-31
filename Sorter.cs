using System.Linq;
using System.Collection;

namespace QuickSort
{ 
	public class Sorter
	{
		public IEnumerable<int> ArrayToSort {get;set;}
		public Sorter (IEnumerable<int> _array)
		{
			ArrayToSort = _array;
		}

		public IEnumerable<int> Sort()
		{
			if (ArrayToSort==null || !ArrayToSort.Any() ||ArrayToSort.Take(2).Count == 1 )
			{
				return ArrayToSort;
			}

			var length = ArrayToSort.Count();
			var pivot = ArrayToSort[length/2];
			var indexBegin=0, indexEnd=length-1;

// todo : подумать, что делать с циклом, зачем он мне тут. Объединить if-ы. Поставить ограничения и выход из цикла по достижению середины
			for (int i = 0; i < length; i++)
			{
				if (ArrayToSort[indexBegin]> pivot && ArrayToSort[indexEnd]< pivot)
				{
					var tempElement = ArrayToSort[indexBegin];
					ArrayToSort[indexBegin] = ArrayToSort[indexEnd];
					ArrayToSort[indexEnd] = tempElement;
					indexBegin++;
					indexEnd--;
				}

				if (ArrayToSort[indexBegin]<= pivot && ArrayToSort[indexEnd] > pivot)
				{
					indexBegin++;
					indexEnd--;
				}

				if (ArrayToSort[indexBegin]>pivot && ArrayToSort[indexEnd] > pivot)
				{
					indexEnd--;
				}

				if (ArrayToSort[indexBegin] <=pivot && ArrayToSort[indexEnd] < pivot)
				{
					indexBegin++;
				}
			}

			return Enumerable.Empty<int>();
		}
	}
}