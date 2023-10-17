using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Operators
{
	public class Test
	{
		public void Run()
		{
			string tstr = "teststring";
			int tnum = 0;
			string[] tarray = { "Adam", "Eve", "Bob"};
			try
			{
				Console.WriteLine(tstr);
				/* int result = 10 / tnum; */
				int index = 10;
				Console.WriteLine(tarray[index]);
			}
			catch (IndexOutOfRangeException objIndex)
			{
				Console.WriteLine("Wrong number of arguments supplied\n" + objIndex);
			}
			catch (DivideByZeroException objDivide)
			{
				Console.WriteLine("Divide by 0\n" + objDivide);
			}
			catch (Exception objException)
			{
				Console.WriteLine("Error\n: " + objException);
			}
		}
	}
}
