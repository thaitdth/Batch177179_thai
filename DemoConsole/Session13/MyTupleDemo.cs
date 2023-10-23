using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Session13
{
	public class MyTupleDemo
	{
		(int Sum, int Count) MyTuple(int[] values)
		{
			var r = (Sum: 0, Count: 0);
			for (int i = 0 ; i < values.Length ; i++)
			{
				if (IsEven(values[i]))
				{
					Console.WriteLine(values[i]);
					r.Sum += values[i];
					r.Count++;
				}
			}
			return r;
			bool IsEven(int n)
			{
				if (n % 2 == 0)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}
		public void Run()
		{
			int[] numbers = { 2, 1, 5, 6, 3, 7, 8, 9, 10, 12, 14, 25, 38 };
			var (Sum, Count) = MyTuple(numbers);
			Console.WriteLine($"Sum: {Sum} - Count: {Count}");
		}
	}
}
