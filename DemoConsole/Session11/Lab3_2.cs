using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DemoConsole.Session11
{
	public class Product
	{
		public string Name { get; set; }
		public double Cost { get; set; }
		public int Quantity { get; set; }
		public override string ToString()
		{
			return $"Name: {Name, 30} - Cost: {Cost, 20} - Quantity: {Quantity, 20}";
		}
	}
	public class Lab3_2
	{
		public void Run()
		{
			List<Product> list = new List<Product>
			{
				new Product {Name = "Table", Cost = 500.50f, Quantity = 50 },
				new Product {Name = "Chair", Cost = 750.00f, Quantity = 100 },
				new Product {Name = "Wardrope", Cost = 200.50f, Quantity = 20 },
				new Product {Name = "Door", Cost = 350f, Quantity = 50 },
				new Product {Name = "Bookshelf", Cost = 600.50f, Quantity = 70 }
			};
			foreach (var product in list.OrderBy(s => s.Name))
			{
				Console.WriteLine(product);
			}
		}
	}
}
