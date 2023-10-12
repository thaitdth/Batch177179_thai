using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.ClassandMethod
{
    public class PhuongTrinhBac2
    {
        private double a, b, c;
		private double x1, x2;
		private bool vonghiem;
        public PhuongTrinhBac2()
        {
            a  = 0.0f;
            b = 0.0f;
            c = 0.0f;
			x1 = 0.0f;
			x2 = 0.0f;
			vonghiem = false;
        }
        public PhuongTrinhBac2(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        private void GiaiPhuongTrinh()
        {
			if (a == 0)
			{
				x1 = (0 - c) / b;
				x2 = (0 - c) / b;
			}
			else
			{
				double delta = Math.Pow(b, 2.0) - 4 * a * c;
				if (delta < 0) vonghiem = true;
				else if (delta == 0)
				{
					x1 = (0 - b) / (2 * a);
					x2 = (0 - b) / (2 * a);
				}
				else
				{
					x1 = (0 - b + Math.Sqrt(delta)) / (2 * a);
					x2 = (0 - b - Math.Sqrt(delta)) / (2 * a);
				}
			}
        }
        public void Run()
        {
            Console.WriteLine("Moi nhap a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Moi nhap b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Moi nhap c: ");
            c = Convert.ToDouble(Console.ReadLine());
			GiaiPhuongTrinh();
			if (vonghiem)
				Console.WriteLine("Phuong Trinh Vo Nghiem.");
			else
				Console.WriteLine("Nghiem thu 1: {0}, Nghiem thu 2: {1}", x1, x2);
			Console.ReadLine();
		}
    }
}
