using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoConsole.ClassandMethod;
using DemoConsole.Operators;
using DemoConsole.Session6;

namespace DemoConsole
{
	public class Program
	{
		public static void Main(string[] args)
		{
			StudentS objStudent = new StudentS();
			Grade objGrade = new Grade();
			objStudent.PrintDetails();
			objGrade.PrintDetails();
		}
	}
}
