using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Session11
{
	public class Lab3_3
	{
		public void Run()
		{
			Dictionary<int, string> myDict = new Dictionary<int, string>();
			myDict.Add(1, "Sunday");
			myDict.Add(2, "Monday");
			myDict.Add(3, "Tuesday");
			myDict.Add(4, "Wednesday");
			myDict.Add(5, "Thursday");
			myDict.Add(6, "Friday");
			myDict.Add(7, "Saturday");
			if (myDict.ContainsValue("Tuesday")) Console.WriteLine("Found Tuesday!");
			else Console.WriteLine("Not Found.");
			foreach (KeyValuePair<int, string> item in myDict)
			{
				Console.WriteLine($"{item.Key} => {item.Value}");
			}
		}
	}
}
