using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Session10
{
	public class ExampleGenericDelegate
	{
		//public int Add(int a, int b) => a + b;
		public int Sub(int a, int b) => a - b;
		public void Print(string msg) => Console.WriteLine(msg);
		public void Run()
		{
			int a = 100, b = 85, add, sub;
			string strResult;
			//Generic Delegate Function (allow return), not have ref and out paramter
			Func<int, int, int> AddFunc = ((a, b) => a + b); //Add;
			add = AddFunc(a, b);
			Func<int, int, int> SubFunc = Sub;
			sub = SubFunc(a, b);
			strResult = $"Add: {add, 5}, Sub: {sub, 5}";
			//Generic Delegate Action (no return, same as Func)
			Action<string> action = Print;
			action(strResult);
		}
	}
}
