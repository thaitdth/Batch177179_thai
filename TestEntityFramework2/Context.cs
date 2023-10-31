using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TestEntityFramework2
{
	public class Context : DbContext
	{
		public Context() : base("name=connectionString") { }
		public DbSet<Student> Student { get; set; }
	}
}
