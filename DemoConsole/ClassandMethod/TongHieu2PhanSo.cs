using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.ClassandMethod
{
	public class TongHieu2PhanSo
	{
		private int a, b, c, d; //a/b and c/d
		public TongHieu2PhanSo()
		{
			a = 0;
			b = 0;
			c = 0;
			d = 0;
		}
		public TongHieu2PhanSo(int a, int b, int c, int d)
		{
			this.a = a;
			this.b = b;
			this.c = c;
			this.d = d;
		}
		private int[] RutGonPhanSo(int tuso, int mauso)
		{
			int ucln = UCLN(tuso, mauso);
			return new int[] {tuso/ucln, mauso/ucln};
		}
		private int UCLN(int a, int b)
		{
			while (b != 0)
			{
				int r = a % b;
				a = b;
				b = r;
			}
			return a;
		}
		private int[] calculateAdd()
		{
			int tuso, mauso;
			mauso = b * d;
			tuso = a * d + b * c;
			return RutGonPhanSo(tuso, mauso);
		}
		private int[] calculateSub()
		{
			int tuso, mauso;
			mauso = b * d;
			tuso = a * d - b * c;
			return RutGonPhanSo(tuso, mauso);
		}
		public void Run()
		{
			Console.WriteLine("Moi nhap a: ");
			a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Moi nhap b: ");
			b = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Moi nhap c: ");
			c = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Moi nhap d: ");
			d = Convert.ToInt32(Console.ReadLine());
			int[] tong = calculateAdd();
			Console.WriteLine("Tong: {0}/{1}", tong[0], tong[1]);
			int[] hieu = calculateSub();
			Console.WriteLine("Hieu: {0}/{1}", hieu[0], hieu[1]);
			Console.ReadLine();
		}
    }
}
