using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Lab4
{
	public class Product
	{
		public string Name { get; set; }
		public decimal Price { get; set; }
		public List<string> Colors { get; set; }
		public override string ToString()
		{
			string str = $"Name: {Name} - Price: {Price} - Color: ";
			foreach (string color in Colors)
			{
				str += (color + " ");
			}
			return str;
		}
	}
	public class ProductDemo
	{
		public void Run()
		{
			List<Product> products = new List<Product>
			{
				new Product {Name = " Product 1", Price = 400, Colors = new List<string> {"Red", "Blue", "Black" } },
				new Product { Name = " Product 2", Price = 200, Colors = new List<string> { "Green", "Yellow", "Purple" } },
				new Product {Name = " Product 3", Price = 440, Colors = new List<string> {"Yellow", "Orange", "Black" } }
			};
			//Loc ra nhung san pham co gia 400
			List<Product> priceProducts = products.Where(p => p.Price == 400).ToList();
			Console.WriteLine("Price=400:");
			foreach (Product product in priceProducts)
			{
				Console.WriteLine(product);
			}
			//Loc ra nhung san pham co mau vang
			List<Product> colorProducts = products.Where(s => s.Colors.Contains("Yellow")).ToList();
			Console.WriteLine("Yellow Products:");
			foreach (Product product in colorProducts)
			{
				Console.WriteLine(product);
			}
			List<Product> orderDesProducts = products.OrderByDescending(p => p.Price).ToList();
			Console.WriteLine("Price Descending:");
			foreach (Product product in orderDesProducts)
			{
				Console.WriteLine(product);
			}

		}
	}
}
