using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Session11
{
	public class Calculator <T>
	{
		public T add( T a,  T b)
		{
			dynamic dynamicA = a;
			dynamic dynamicB = b;
			return dynamicA + dynamicB;
		}
		public T sub( T a,  T b)
		{
			dynamic dynamicA = a;
			dynamic dynamicB = b;
			return dynamicA - dynamicB;
		}
		public T mul( T a,  T b)
		{
			dynamic dynamicA = a;
			dynamic dynamicB = b;
			return dynamicA * dynamicB;
		}
		public T div( T a,  T b)
		{
			dynamic dynamicA = a;
			dynamic dynamicB = b;
			return dynamicA / dynamicB;
		}
	}
	public class Lab3_1
	{
		private void Swap <T> (ref T a, ref T b)
		{
			T temp = a;
			a = b;
			b = temp;
		}
		public void Run()
		{
			//Swap
			int a = 10, b = 20;
			string stra = "Nguyen Van An", strb = "Hoang Thi Be";
			double doubleA = 10.5f, doubleB = 20.7f;
			Console.WriteLine($"Before swapping:\na: {a} - b: {b}");
			Swap(ref a, ref b);
			Console.WriteLine($"After swapping:\na: {a} - b: {b}");
			Console.WriteLine($"Before swapping:\nstring a: {stra} - string b: {strb}");
			Swap(ref stra, ref strb);
			Console.WriteLine($"After swapping:\nstring a: {stra} - string b: {strb}");
			Console.WriteLine($"Before swapping:\ndouble a: {doubleA} - double b: {doubleB}");
			Swap(ref doubleA, ref doubleB);
			Console.WriteLine($"After swapping:\ndouble a: {doubleA} - double b: {doubleB}");
			//***

			//Calculator
			//Run Time
			Console.WriteLine();
			Calculator<int> intCalculator = new Calculator<int>();
			int c = 20, d = 10;
			int addresult = intCalculator.add(c, d);
			int divresult = intCalculator.div(c, d);
			Console.WriteLine($"{c} + {d} = {addresult}");
			Console.WriteLine($"{c} / {d} = {divresult}");
			Calculator<double> doubleCalculator = new Calculator<double>();
			double e = 30.45f, f = 89.32f;
			double subresult = doubleCalculator.sub(e, f);
			double divresult2 = doubleCalculator.div(e, f);
			Console.WriteLine($"{e} - {f} = {subresult}");
			Console.WriteLine($"{e} / {f} = {divresult2}");
			Calculator<string> stringCalculator = new Calculator<string>();
			string str1 = "Hello ", str2 = "World!";
			string strResult = stringCalculator.add(str1, str2);
			Console.WriteLine($"{str1} + {str2} = {strResult}");
			//***
			Console.ReadLine();
		}
	}
}
