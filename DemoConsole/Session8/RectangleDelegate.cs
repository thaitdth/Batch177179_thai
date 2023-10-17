using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Session8
{
	//Create Delegate
	public delegate double RecDelegate(double width, double length);
	public delegate void RecDelegate2(string msg);
	class RecClass
	{
		public void PrintMessage(string mess) => Console.WriteLine(mess);
	}
	public class RectangleDelegate
	{
		private void InvokeDelegate(RecDelegate2 dele, string msg) => dele(msg);
		private double Area(double width, double length) => width * length;
		private double Perimeter(double width, double length) => (width + length ) * 2;
		public void Run()
		{
			double width, length;
			Console.WriteLine("Enter width: ");
			width = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter length: ");
			length = Convert.ToDouble(Console.ReadLine());
			double area, perimeter;
			//Set target method
			RecDelegate obj1 = new RecDelegate(Area);
			RecDelegate obj2 = new RecDelegate(Perimeter);
			//Invoke method
			area = obj1(width, length);
			perimeter = obj2(width, length);
			string msg = $"Area: {area} - Perimeter: {perimeter}";
			RecClass obj3 = new RecClass();
			InvokeDelegate(obj3.PrintMessage, msg);
		}
	}
}
