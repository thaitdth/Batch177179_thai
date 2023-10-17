using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Session8
{
	public delegate double BDelegate1(double side1, double side2, double side3);
	public delegate void BDelegate2(string mess);
	class BClass
	{
		public void Print(string mess) => Console.WriteLine(mess);
	}
	public class BoxDelegate
	{
		private void InvokeDelegate(BDelegate2 dele, string mess ) => dele(mess);
		private double Area(double side1, double side2, double side3) 
			=> (side1*side2+side2*side3+side3*side1)*2;
		private double Volume(double side1, double side2, double side3) => side1 * side2 * side3;
		public void Run()
		{
			BDelegate1 obj1 = new BDelegate1(Area);
			BDelegate1 obj2 = new BDelegate1(Volume);
			double side1, side2, side3;
			Console.WriteLine("Enter side1: ");
			side1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter side2: ");
			side2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter side3: ");
			side3 = Convert.ToDouble(Console.ReadLine());
			double area = obj1(side1, side2, side3);
			double volume = obj2(side1, side2, side3);
			string mess = $"Area: {area} - Volume: {volume}";
			BClass obj3 = new BClass();
			InvokeDelegate(obj3.Print, mess);
		}
	}
}
