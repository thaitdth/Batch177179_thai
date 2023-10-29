using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEntityFramework
{
	public class Program
	{
		public static void Main(string[] args)
		{
			using (var context = new Context())
			{
				context.Database.CreateIfNotExists();
				var student = new Student
				{
					StudentId = 1,
					FirstName = "Thai",
					LastName = "Tran",
					Class = "7a",
					GPA = 7.5
				};
				context.Student.Add(student);
				context.SaveChanges();
			}
		}
	}
}
