using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using DemoConsole.Lab4;
using DemoConsole.Session11;

namespace DemoConsole.Session13
{
	public class Doctor
	{
		public int DoctorID;
		public string Name;
		public string Specialization;
		public (int DoctorID, string Name, string Specialization) GetDoctorInfo()
		{
			return (DoctorID, Name, Specialization);
		}
		public override string ToString()
		{
			return $"DoctorId: {DoctorID} - Name: {Name} - Specialization: {Specialization}";
		}
	}
	public class Exercise1
	{
		public void Run()
		{
			List<Doctor> doctors = new List<Doctor>()
			{
				new Doctor{ DoctorID = 1, Name = "Smith", Specialization = "Cardiology"},
				new Doctor{ DoctorID = 2, Name = "Ben", Specialization = "Cardiology"},
				new Doctor{ DoctorID = 3, Name = "Smith", Specialization = "Chiropractic"},
				new Doctor{ DoctorID = 4, Name = "Carol", Specialization = "Pediatrics"},
				new Doctor{ DoctorID = 5, Name = "Michelle", Specialization = "Surgery"}
			};
			foreach (var doctor in doctors)
			{
				var r = doctor.GetDoctorInfo();
				Console.WriteLine($"DoctorId: {r.DoctorID} - Name: {r.Name} - Specialization: {r.Specialization}");
			}
			Console.WriteLine();
			List<Doctor> cardiologists = doctors.Where(s => s.Specialization.Equals("Cardiology")).ToList();
			foreach (Doctor doctor in cardiologists)
			{
				Console.WriteLine(doctor);
			}
			Console.WriteLine();
			string keyword = "Smith";
			List<Doctor> smiths = doctors.Where(s => s.Name.Equals("Smith")).ToList();
			foreach (Doctor doctor in smiths)
			{
				Console.WriteLine(doctor);
			}
			Console.WriteLine();
			List<Doctor> DoctorIDDes = doctors.OrderByDescending(s => s.DoctorID).ToList();
			foreach (var doctor in DoctorIDDes)
			{
				Console.WriteLine(doctor);
			}
			Console.WriteLine();
			doctors.Add(new Doctor { DoctorID = 6, Name = "David", Specialization = "Pediatrics" });
			foreach (var doctor in doctors)
			{
				Console.WriteLine(doctor);
			}
			Console.WriteLine();
			var list1 = doctors.Where(s => s.DoctorID > 3);
			foreach (var doctor in list1)
			{
				Console.WriteLine(doctor.Name);
			}
			Console.WriteLine();
			double aveID = doctors.Average(s => s.DoctorID);
			Console.WriteLine(aveID);
			Console.WriteLine();
			int count = doctors.Count(s => s.Specialization.Equals("Pediatrics"));
			Console.WriteLine(count);
			Console.WriteLine();
			var list2 = doctors.GroupBy(s => s.Specialization).Select(g => new { Specialization = g.Key, Count = g.Count() });
			foreach (var doctor in list2)
			{
				Console.WriteLine(doctor.Specialization + " " + doctor.Count);
			}
		}
	}
}
