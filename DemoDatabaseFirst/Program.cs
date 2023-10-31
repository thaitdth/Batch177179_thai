using DemoDatabaseFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDatabaseFirst
{
	public class Program
	{
		public static void Main(string[] args)
		{
			MyStoreContext myStore = new MyStoreContext();
			var products = from p in myStore.Products
						   select new { p.ProductName, p.CategoryId };
			foreach (var p in products)
			{
				Console.WriteLine($"{p.ProductName} - {p.CategoryId}");
			}
			var categories = from q in myStore.Categories
							 select new { q.CategoryId, q.CategoryName};
			foreach (var q in categories)
			{
				Console.WriteLine($"{q.CategoryId} - {q.CategoryName}");
			}
		}
	}
}
