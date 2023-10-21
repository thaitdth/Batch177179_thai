using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Lab4
{
	public delegate void BalanceChangedEvenHandler(decimal newBalance);
	public class Account
	{
		public event BalanceChangedEvenHandler BalanceChanged;
		private decimal balance;
		public decimal Balance
		{
			get {return balance; }
			set
			{
				balance = value;
				OnBalanceChanged(balance);
			}
		}
		protected virtual void OnBalanceChanged(decimal newBalance)
		{
			BalanceChanged?.Invoke(newBalance);
		}
	}
	public class ExampleBalance
	{
		public void Run()
		{
			Account account = new Account();
			account.BalanceChanged += HandleBalanceChanged;
			account.Balance = 1000;
			Console.ReadLine();
		}
		void HandleBalanceChanged(decimal newBalance)
		{
			Console.WriteLine("Account balance has changed. New balance: " + newBalance);
		}
	}
}