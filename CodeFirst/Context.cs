﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstDemo
{
	public class Context : DbContext
	{
		//public Context() : base("name=connectionString") { }
		public DbSet<Person> People { get; set; }
	}
}
