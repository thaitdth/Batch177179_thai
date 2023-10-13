using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Session6
{
	public class BaseClass
	{
		public virtual void ToString()
		{
			Console.WriteLine("This is Base Class.");
		}
	}
	public class TestVirtual : BaseClass
	{
		public override void ToString()
		{
			Console.WriteLine("Day la phuong thuc Override o lop con.");
		}
	}
}
