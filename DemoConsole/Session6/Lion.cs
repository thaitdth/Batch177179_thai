using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Session6
{
	public abstract class Animal2
	{
		public abstract int Id { get; set; }
		public void Eat()
		{
			Console.WriteLine("Animal Eat ...");
		}
		public abstract void AnimalSound();
		public abstract void Running();
	}

	public abstract class Animal3
	{

	}
	public class Lion : Animal2 //, Animal3, error
	{
		public override int Id { get; set; }
		public override void AnimalSound()
		{
			Lion a = new Lion();
			a.Id = 10;
			Console.WriteLine("Hello: " + a.Id);
		}
		public override void Running()
		{
			Console.WriteLine("Running...");
		}
	}
}
