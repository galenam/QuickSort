using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSort;

namespace testproject
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var items = new int[] { 4, 6, 5 };
			var sortedItems = new int[] { 4, 5, 6 };
			QuickSort.Sorter.Sort(items);
			for (var i = 0; i++ < items.Length;)
			{
				Assert.AreEqual(items[i], sortedItems[i]);
			}
		}
	}
}
