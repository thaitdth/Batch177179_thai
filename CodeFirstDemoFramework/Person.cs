using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace CodeFirstDemoFrameWork
{
	public class Person
	{
		public int PersonId { get; set; }
		[Required]
		public string LastName { get; set; }
		public string FirstName { get; set; }
	}
}
