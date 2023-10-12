using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Session6
{
	public interface IPerson
	{
		void Running();
	}
	public interface IMother
	{
		void Sound();
	}
	public class Teacher : IPerson, IMother
	{
		public void Sound()
		{
			Console.WriteLine("Oa Oa ... ");
		}
		public void Running()
		{
			Console.WriteLine("Running...");
		}

	}
}
