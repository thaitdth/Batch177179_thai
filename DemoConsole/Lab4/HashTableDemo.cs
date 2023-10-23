using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DemoConsole.Lab4
{
	public class HashTableDemo
	{
		public void Run()
		{
			Hashtable daysOfWeek = new Hashtable();
			daysOfWeek.Add(1, "Monday");
			daysOfWeek.Add(2, "Tuesday");
			daysOfWeek.Add(3, "Wednesday");
			daysOfWeek.Add(4, "Thursday");
			daysOfWeek.Add(5, "Friday");
			daysOfWeek.Add(6, "Saturday");
			daysOfWeek.Add(7, "Sunday");
			if (daysOfWeek.ContainsValue("Tuesday"))
			{
				Console.WriteLine("Tuesday is found in the hashtable");
			}
			else
			{
				Console.WriteLine("Tuesday is not found in the hashtable");
			}
			foreach (DictionaryEntry entry in daysOfWeek)
			{
				Console.WriteLine("Key: {0}, Value: {1}", entry.Key, entry.Value);
			}
		}
	}
}
