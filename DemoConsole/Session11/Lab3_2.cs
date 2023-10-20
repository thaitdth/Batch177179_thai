using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DemoConsole.Session11
{
	public class Productt
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
			List<Productt> list = new List<Productt>
			{
				new Productt {Name = "Table", Cost = 500.50f, Quantity = 50 },
				new Productt {Name = "Chair", Cost = 750.00f, Quantity = 100 },
				new Productt {Name = "Wardrope", Cost = 200.50f, Quantity = 20 },
				new Productt {Name = "Door", Cost = 350f, Quantity = 50 },
				new Productt {Name = "Bookshelf", Cost = 600.50f, Quantity = 70 }
			};
			foreach (var product in list.OrderBy(s => s.Name))
			{
				Console.WriteLine(product);
			}
		}
	}
}
