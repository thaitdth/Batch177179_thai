using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Session8
{
	public delegate int MyDelegate(int num1, int num2);
	public class ExampleDelegate
	{
		private int Add(int num1, int num2) => num1 + num2;
		private int Sub(int num1, int num2) => num1 - num2;
		public void Run()
		{
			int a = 10, b = 20;
			int result;
			//Set target method
			MyDelegate obj1 = new MyDelegate(Add);
			//Invoke method
			result = obj1(a, b);
			Console.WriteLine($"{a} + {b} = {result}");
		}
	}
}
