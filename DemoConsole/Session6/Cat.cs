using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Session6
{
	public class Cat : Animal
	{
		/*public void ToString()
		{
			//base key word
			base.Eat(); //phuong thuc
			base.DoSomething();
		}*/
		public new void Eat()
		{
			base.Eat();
			Console.WriteLine("Cat Eat...");
		}
	}
}
