using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TestEntityFramework
{
	public class Student
	{
		public int StudentId { get; set; }
		[Required]
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Class { get; set; }
		public double GPA { get; set; }
	}
}
