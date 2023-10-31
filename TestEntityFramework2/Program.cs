using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEntityFramework2;

namespace TestEntityFramework2
{
	public class Program
	{
		public static void Main(string[] args)
		{
			using (var context = new Context())
			{
				context.Database.CreateIfNotExists();
				var student1 = new Student
				{
					StudentId = 1,
					FirstName = "Minh",
					LastName = "Nguyen",
					Class = "12D",
					GPA = 9.25
				};
				var student2 = new Student
				{
					StudentId = 2,
					FirstName = "Hoang",
					LastName = "Le",
					Class = "11E",
					GPA = 8.75
				};
				context.Student.Add(student1);
				context.SaveChanges();
				context.Student.Add(student2);
				context.SaveChanges();
			}
		}
	}
}
