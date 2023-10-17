using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Session8
{
	public delegate double TDelegate1(double tbase, double theight);
	public delegate void TDelegate2(string mess);
	class TClass
	{
		public void Print(string mess) => Console.WriteLine(mess);
	}
	public class TriangleDelegate
	{
		private void TInvokeDelegate(TDelegate2 dele, string mess) => dele(mess);
		private double tArea(double tbase, double theight) => tbase * theight / 2;
		public void Run()
		{
			double tbase, theight;
			TDelegate1 obj1 = new TDelegate1(tArea);
			Console.WriteLine("Enter base: ");
			tbase = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter height: ");
			theight = Convert.ToDouble(Console.ReadLine());
			double tarea = obj1(tbase, theight);
			string mess = $"Area: {tarea}";
			TClass obj2 = new TClass();
			TInvokeDelegate(obj2.Print, mess);
		}
	}
}
