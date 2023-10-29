using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEntityFramework;

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
					Name = "Thai Tran",
					Class = "7a",
					GPA = 5.5f
				};
				context.Student.Add(student);
				context.SaveChanges();
			}
		}
	}
}
