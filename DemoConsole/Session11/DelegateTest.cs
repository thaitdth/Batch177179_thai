using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Session11
{
	public delegate void PrintDelegate(string mess);
	public delegate void CalculateDelegate(int a, int b);
	public delegate void TestDelegate(string mess);
	public class DelegateTest
	{
		private void TestMethod(string mess)
		{
			Console.WriteLine(mess);
		}
		private void Print(string mess)
		{
			Console.WriteLine("mess within method: " + mess);
		}
		private void Add(int a,int  b) => Console.WriteLine(a + b);
		private void Sub(int a,int b) => Console.WriteLine(a - b);
		private void Mul(int a,int b) => Console.WriteLine(a / b);
		private void Div(int a, int b) => Console.WriteLine(a * b);
		public void Run()
		{
			PrintDelegate dele = delegate (string mess)
			{
				Console.WriteLine("mess with delegate instantiated: " + mess);
			};
			dele += Print;
			dele("Hello World");
			CalculateDelegate dele2 = delegate
			{
				Console.WriteLine("Initiating Calculate Delegate");
			};
			CalculateDelegate obj1 = Mul;
			CalculateDelegate obj2 = Div;
			dele2 += Add;
			dele2 += Sub;
			dele2 += obj1;
			dele2 += obj2;
			dele2 += delegate (int a, int b)
			{
				Console.WriteLine(a % b);
			};
			dele2(90, 1010);
			TestDelegate testDele = new TestDelegate(TestMethod);
			testDele("Test 1");
			TestDelegate testDele2 = delegate { Console.WriteLine("Test 2"); };
			testDele2("NO Show");
			testDele += delegate { Console.WriteLine("Second Test 3"); };
			testDele("First Test 3");
			testDele += Print;
			testDele += TestMethod;
			testDele("Test 4");
		}
	}
}
