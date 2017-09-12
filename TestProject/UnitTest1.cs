using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSort;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace testproject
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var items = new List<int> { 4, 6, 5 };			
			var sortedItems = new List<int> { 4, 5, 6 };
			BaseTestMethod(items, sortedItems);
		}

		[TestMethod]
		public void TestMethod2()
		{
			var items = new List<int> { 4, 5, 6 };			
			var sortedItems = new List<int> { 4, 5, 6 };
			BaseTestMethod(items, sortedItems);
		}

		[TestMethod]
		public void TestMethod3()
		{
			var items = new List<int> { 6, 5, 4 };			
			var sortedItems = new List<int> { 4, 5, 6 };
			BaseTestMethod(items, sortedItems);
		}

		[TestMethod]
		public void TestMethod4()
		{
			List<int> items = null;						
			QuickSort.Sorter.Sort(items);
			Assert.AreEqual(items, null, "null отсортировался не как null");
		}

		[TestMethod]
		public void TestMethod5()
		{
			var items = new List<int> {};			
			var sortedItems = new List<int> { };
			BaseTestMethod(items, sortedItems);
		}

		[TestMethod]
		public void TestMethod6()
		{
			var items = new List<int> { 1,2,3,4};			
			var sortedItems = new List<int> { 1,2,3,4 };
			BaseTestMethod(items, sortedItems);
		}


		[TestMethod]
		public void TestMethod7()
		{
			var items = new List<int> { 4, 3,2,1};			
			var sortedItems = new List<int> { 1,2,3,4 };
			BaseTestMethod(items, sortedItems);
		}

		[TestMethod]
		public void TestMethod8()
		{
			var items = new List<int> { 3,5,7,25,89,2,5,7,9,3,68,0,3,3,7,9};			
			var sortedItems = new List<int> {0,2,3,3,3,3,5,5,7,7,7,9,9,25,68,89};
			BaseTestMethod(items, sortedItems);
		}
		private void BaseTestMethod(List<int> items, List<int> sortedItems)
		{
			var errorMessInitial = GetStringFromList(items);
			QuickSort.Sorter.Sort(items);
			var errorMessSorted = GetStringFromList(items);						
			for (var i = 0; i < items.Count;i++)
			{
				Assert.AreEqual(items[i], sortedItems[i], $"Неверная сортировка. Исходный массив {errorMessInitial}. Отсортированный массив {errorMessSorted}"+
				$" не совпадает {i} элемент. Он равен {items[i]}, ожидается {sortedItems[i]}");
			}
		}

		private string GetStringFromList(List<int> items)
		{			
			return items?.Aggregate(new StringBuilder(), (sb, i) => sb.AppendFormat("{0} ", i)).ToString();
		}
	}
}
