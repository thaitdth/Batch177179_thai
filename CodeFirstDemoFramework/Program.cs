﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstDemoFrameWork;

namespace CodeFirstDemoFramework
{
	public class Program
	{
		public static void Main(string[] args)
		{
			using (var context = new Context())
			{
				context.Database.CreateIfNotExists();
				var person = new Person
				{
					FirstName = "Thai",
					LastName = "Tran"
				};
				context.People.Add(person);
				context.SaveChanges();
			}
		}
	}
}
