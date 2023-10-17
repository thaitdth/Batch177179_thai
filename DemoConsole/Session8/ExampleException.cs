using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Session8
{
	public class ExampleException
	{
		public void Run()
			{
			string[] names = { "John", "James" };
			int numOne = 0;
			int result = 0;
			int index = 0;
			try
			{
				index = 3;
				names[index] = "Smith"; //catch at this line, break out
				result = 130 / numOne;
			}
			catch (DivideByZeroException objDivide)
			{
				Console.WriteLine("Divide by 0\n" + objDivide);
			}
			catch (IndexOutOfRangeException objIndex)
			{
				Console.WriteLine("Wrong number of arguments supplied\n" + objIndex);
			}
			catch (Exception objException)
			{
				Console.WriteLine("Error\n: " + objException);
			}
			Console.WriteLine(result);
		}
	}
}
