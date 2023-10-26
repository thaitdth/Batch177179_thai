using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Exam
{
	public class Student
	{
		int StudentID;
		string Name;
		double GPA;
		private static IEnumerable<object> student;

		(int StudentID, string Name, double GPA) GetStudentInfo ()
		{
			return (StudentID, Name, GPA);
		}
		public static void Main(string[] args)
		{
			List<Student> students = new List<Student>
			{
				new Student { StudentID = 1, Name = "Tran Van Hoang", GPA = 7.5 },
				new Student { StudentID = 2, Name = "Nguyen Viet Tuan", GPA = 8.0 },
				new Student { StudentID = 3, Name = "Le Bao Hoang", GPA = 4.0 },
				new Student { StudentID = 4, Name = "Hoang Thi Tam", GPA = 9.5 },
				new Student { StudentID = 5, Name = "Trinh Thi Anh", GPA = 3.5 }
			};
			foreach (Student student in students)
			{
				var studentInfo = student.GetStudentInfo();
				Console.WriteLine($"{studentInfo.StudentID, 5} - {studentInfo.Name, 20} - {studentInfo.GPA, 5}");
			}
			Console.WriteLine();
			List<Student> above7s = students.Where(s => s.GPA > 7).ToList();
			foreach (Student student in above7s)
			{
				var studentInfo = student.GetStudentInfo();
				Console.WriteLine($"{studentInfo.StudentID,5} - {studentInfo.Name,20} - {studentInfo.GPA,5}");
			}
			Console.WriteLine();
			var hoangs = students.Where(s => s.Name.Contains("Hoang"));
			foreach (var student in hoangs)
			{
				var studentInfo = student.GetStudentInfo();
				Console.WriteLine($"{studentInfo.StudentID,5} - {studentInfo.Name,20} - {studentInfo.GPA,5}");
			}
			Console.WriteLine();
			List<Student> orderAsc = students.OrderBy(s => s.GPA).ToList();
			foreach (Student student in orderAsc)
			{
				var studentInfo = student.GetStudentInfo();
				Console.WriteLine($"{studentInfo.StudentID,5} - {studentInfo.Name,20} - {studentInfo.GPA,5}");
			}
			students.Add(new Student { StudentID = 6, Name = "Nguyen Quyet Tien", GPA = 3.0});
			Console.WriteLine();
			foreach (Student student in students)
			{
				var studentInfo = student.GetStudentInfo();
				Console.WriteLine($"{studentInfo.StudentID,5} - {studentInfo.Name,20} - {studentInfo.GPA,5}");
			}
			Console.WriteLine();
			MyGenericClass<int> myclass1 = new MyGenericClass<int>();
			myclass1.Value = 100;
			Console.WriteLine(myclass1.GetValue());
			MyGenericClass<string> myclass2 = new MyGenericClass<string>();
			myclass2.Value = "Hello";
			Console.WriteLine(myclass2.GetValue());
		}
	}
	class MyGenericClass<T>
	{
		public T Value { get; set; }
		public T GetValue()
		{
			return Value;
		}
	}
}
