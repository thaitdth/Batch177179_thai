using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Lab4_4
{
	public delegate void MyDelegate(decimal balance);
	public class Account
	{
		public event MyDelegate Notify;
		public void Print(decimal balance)
		{
			Console.WriteLine("This is new balance: " + balance);
		}
		public void Run()
		{
			Notify += Print;
			Notify(1000);
		}
	}
}
