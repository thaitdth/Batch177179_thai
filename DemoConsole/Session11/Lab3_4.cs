using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Session11
{
	public class Lab3_4
	{
		public void Run()
		{
			List<Brand> brands = new List<Brand>()
			{
				new Brand{ID = 1, Name = "Cong ty AAA"},
				new Brand{ID = 2, Name = "Cong ty BBB"},
				new Brand{ID = 4, Name = "Cong ty CCC"}
			};
			List<Product> products = new List<Product>()
			{
				new Product(1, "Ban Tra",400, new string[] {"Xam", "Xanh" }, 2 ),
				new Product(2, "Tranh Treo",400, new string[] {"Vang", "Xanh"}, 1 ),
				new Product(3, "Den Trum",500, new string[] {"Trang"}, 3 ),
				new Product(4, "Ban Hoc",200, new string[] {"Trang", "Xanh"}, 1 ),
				new Product(5, "Tui Da",300, new string[] {"Do", "Den", "Vang"}, 2 ),
				new Product(6, "Giuong Ngu",500, new string[] {"Trang"}, 2 ),
				new Product(7, "Tu Ao",600, new string[] {"Trang"}, 3 )
			};
			var test1 = from p1 in products
					   join b1 in brands
					   on p1.Brand equals b1.ID
					   where p1.Price == 400
					   select new
					   {
						   name = p1.Name,
						   id = p1.ID,
						   price = p1.Price,
						   colors = p1.Colors,
						   brand = b1.Name
					   };
			Console.WriteLine("Test1: ");
			foreach (var item in test1)
			{
				Console.Write($"{item.name, 10} {item.id, 5} {item.price, 5} {item.brand, 10}");
				foreach (var color in item.colors)
				{
					Console.Write($"{color, 7}");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
			var test2 = from p2 in products
						orderby p2.Price descending
						select p2;
			Console.WriteLine("Test2: ");
			foreach (var item in test2)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();
			var test3 = from p3 in products
						where p3.Colors.Contains("Vang")
						select p3;
			Console.WriteLine("Test3: ");
			foreach (var item in test3)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();
			var ketqua = from product in products join brand in brands
							on product.Brand equals brand.ID
					 select new
					 {
						 name = product.Name,
						 brand = brand.Name,
						 price = product.Price
					 };
			foreach (var item in ketqua)
			{
				Console.WriteLine($"{item.name,10} {item.price,4} {item.brand,12}");
			}
			Console.WriteLine();
			ketqua = from product in products
						 join brand in brands
						 on product.Brand equals brand.ID into t
						 from brand in t.DefaultIfEmpty()
						 select new
						 {
							name = product.Name,
							brand = (brand == null) ? "No-brand" : brand.Name,
							price = product.Price
						 };
			foreach (var item in ketqua)
			{
				Console.WriteLine($"{item.name,10} {item.price, 4} {item.brand, 12}");
			}
		}
	}
	public class Product
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
		public string[] Colors { get; set; }
		public int Brand { get; set; }
		public Product(int id, string name, double price, string[] colors, int brand)
		{
			ID = id;
			Name = name;
			Price = price;
			Colors = colors;
			Brand = brand;
		}
		public override string ToString()
			=> $"{ID, 3} {Name, 12} {Price, 5} {Brand, 2} {string.Join(",", Colors)}";
	}
	public class Brand
	{
		public string Name { get; set; }
		public int ID	{ get; set; }
	}
}
