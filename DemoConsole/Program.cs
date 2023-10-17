using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoConsole.ClassandMethod;
using DemoConsole.Operators;
using DemoConsole.Session6;
using DemoConsole.Session8;
using ABC = Automotive;
namespace DemoConsole
{
	public class Program
	{
		public static void Main(string[] args)
		{
			new DivisionError().Run();
		}
	}
}

namespace Automotive
{
	public class SpareParts
	{
		string _spareName;
		public SpareParts() { _spareName = "Gear Box"; }
		public void Display()
		{
			Console.WriteLine("Spare Part name: " + _spareName);
		}
	}
}
