using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Session11
{
	public delegate void SampleDelegate(int a, int b);
	class MathOperations
	{
		public void Add(int a, int b)
		{
			Console.WriteLine("Add Result: {0}", a + b);
		}
		public void Subtract(int a, int b)
		{
			Console.WriteLine("Subtract Result: {0}", a - b);
		}
		public void Multiply(int a, int b)
		{
			Console.WriteLine("Multiply Result: {0}", a * b);
		}
	}
	public class HomeworkDelegate
	{
		public void Run()
		{
			Console.WriteLine("***Delegate Example***");
			MathOperations m = new MathOperations();
			SampleDelegate dele = m.Add; //instantiated delegate with add method
			dele += m.Subtract;
			dele += m.Multiply;
			dele(10, 90);
			Console.ReadLine();
		}
	}
}
