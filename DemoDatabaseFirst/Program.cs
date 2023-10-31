using DemoDatabaseFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDatabaseFirst
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			MyStoreContext context = new MyStoreContext();
			//Show list of categories
			var list_category = context.Categories.ToList();
			Console.WriteLine("List of Category:");
			foreach (var category in list_category)
			{
				Console.WriteLine($"Category Id: {category.CategoryId} - Category Name: {category.CategoryName}");
			}
			//Show list of products
			var list_product = context.Products.ToList();
			Console.WriteLine("List of Product:");
			foreach (var product in list_product)
			{
				Console.WriteLine($"Product Id: {product.ProductId} - Product Name: {product.ProductName}" +
					$" - Price: {product.UnitPrice} - UnitsInStock: {product.UnitsInStock} - Category Name: {product.Category.CategoryName}");
			}
			//Show list of products by price
			var list_productByPrice = context.Products.Where(p => p.UnitPrice < 100000).OrderByDescending(p => p.ProductName).ToList();
			Console.WriteLine("List of Product by Price:");
			foreach (var product in list_productByPrice)
			{
				Console.WriteLine($"Product Id: {product.ProductId} - Product Name: {product.ProductName}" +
					$" - Price: {product.UnitPrice} - UnitsInStock: {product.UnitsInStock} - Category Name: {product.Category.CategoryName}");
			}
		}
	}
}
