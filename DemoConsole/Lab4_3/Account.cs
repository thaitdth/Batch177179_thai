using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Lab4_3
{
	public delegate void MyDelegate(decimal balance);
	public class Account
	{
		event MyDelegate Notify;
		private decimal balance;
		public void UpdateBalance(decimal balance)
			=> Console.WriteLine("This is new balance: " + balance);
		public void Run()
		{
			Notify += new MyDelegate(UpdateBalance);
			Notify(1000);
		}
	}
}
