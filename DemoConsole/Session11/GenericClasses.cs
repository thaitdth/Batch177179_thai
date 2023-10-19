using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Session11
{
	class MyClass<T>
	{
		public T Data { get; set; }
		public override string ToString()
		{
			return $"Data: {Data}";
		}
	}
	public class GenericClasses
	{
		public void Run()
		{
			MyClass<string> myclass1 = new MyClass<string> { Data = "Hello World" };
			Console.WriteLine(myclass1);
			MyClass<float> myclass2 = new MyClass<float> { Data = 5.6f};
			Console.WriteLine(myclass2);
			dynamic obj = new { Id = 1, Name = "David" };
			MyClass<dynamic> myclass3 = new MyClass<dynamic> { Data = obj };
			Console.WriteLine(myclass3);
		}
	}
}
