using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Session8
{
	public delegate double RDelegate(double width, double length); //one delegate used for 2 methods
	public delegate void RDelegate2(string mess);
	public class RClass
	{
		public void Print(string mess) => Console.WriteLine(mess);
	}
	public class RectangleDelegate2
	{
		private void InvokeDelegate(RDelegate2 dele, string mess) => dele(mess);
		private double Area(double width, double length) => width * length;
		private double Perimeter(double width, double length) => (width + length) * 2;
		public void Run()
		{
			double width, length, area, perimeter;
			RDelegate obj1 = new RDelegate(Area);
			RDelegate obj2 = new RDelegate(Perimeter);
			Console.WriteLine("Nhap chieu dai hinh chu nhat: ");
			length = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Nhap chieu rong hinh chu nhat: ");
			width = Convert.ToDouble(Console.ReadLine());
			area = obj1(length, width);
			perimeter = obj2(length, width);
			string mess = $"Dien tich hinh chu nhat: {area}\nChu vi hinh chu nhat: {perimeter}";
		    RClass obj3 = new RClass();
			InvokeDelegate(obj3.Print, mess);
		}
	}
}
