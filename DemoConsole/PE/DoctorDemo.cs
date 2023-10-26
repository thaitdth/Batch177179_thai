using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.PE
{
	public class DoctorDemo
	{
		public static void Main(string[] args)
		{
			//Question 1.1:
			/*Doctor doctor = new Doctor()
			{
				Id = 1, Name = "Nguyen Van Smith", Specialization = "Cardiology"
			};*/
			//Question 1.2:
			List<Doctor> list = new List<Doctor>
			{
				new Doctor {Id = 1, Name = "Nguyen Van Smith", Specialization = "Cardiology" },
				new Doctor {Id = 2, Name = "Tran Van David", Specialization = "Cardiology" },
				new Doctor {Id = 3, Name = "Hoang Thi Lion", Specialization = "Pediatrics" },
				new Doctor {Id = 4, Name = "Le Van John", Specialization = "Cardiology" },
				new Doctor {Id = 5, Name = "Ly Dieu Smith", Specialization = "Pediatrics" }
			};
			//Question 1.3:
			foreach (Doctor doctor in list)
			{
				var doctorInfo = doctor.GetDoctorInfo();
				Console.WriteLine($"{doctorInfo.id} - {doctorInfo.name} - {doctorInfo.specialization}");
			}
			//Question 2.1:
			Console.WriteLine();
			var cardiologists = list.Where(s => s.Specialization == "Cardiology");
			foreach (var item in cardiologists)
			{
				var doctorInfo = item.GetDoctorInfo();
				Console.WriteLine($"{doctorInfo.id} - {doctorInfo.name} - {doctorInfo.specialization}");
			}
			//Question 2.2:
			Console.WriteLine();
			var smiths = list.Where(s => s.Name.Contains("Smith"));
			foreach (var item in smiths)
			{
				var doctorInfo = item.GetDoctorInfo();
				Console.WriteLine($"{doctorInfo.id} - {doctorInfo.name} - {doctorInfo.specialization}");
			}
			//Question 2.3:
			Console.WriteLine();
			var IdDes = list.OrderByDescending(s => s.Id);
			foreach (var item in IdDes)
			{
				var doctorInfo = item.GetDoctorInfo();
				Console.WriteLine($"{doctorInfo.id} - {doctorInfo.name} - {doctorInfo.specialization}");
			}
			//Question 2.4:
			list.Add(new Doctor { Id = 6, Name ="John Doe", Specialization="Pediatrics"});

			//Question 2.5:
			Console.WriteLine();
			foreach (Doctor doctor in list)
			{
				var doctorInfo = doctor.GetDoctorInfo();
				Console.WriteLine($"{doctorInfo.id} - {doctorInfo.name} - {doctorInfo.specialization}");
			}
			//Question 3.1:
			Console.WriteLine();
			List<Doctor> list1 = list.Where(s => s.Id > 3).ToList();
			foreach (Doctor doctor in list1)
			{
				var doctorInfo = doctor.GetDoctorInfo();
				Console.WriteLine($"{doctorInfo.id} - {doctorInfo.name} - {doctorInfo.specialization}");
			}
			//Question 3.2:
			Console.WriteLine();
			double Ave = list.Average(s => s.Id);
			Console.WriteLine(Ave);

			//Question 3.3:
			Console.WriteLine();
			int C = list.Count(s => s.Specialization.Contains("Pediatrics"));
			Console.WriteLine(C);

			//Question 3.4:
			Console.WriteLine();
			var list2 = list.GroupBy(s => s.Specialization).Select(g => new {specialization = g.Key, count = g.Count() });
			foreach (var item in list2)
			{
				Console.WriteLine($"{item.specialization} - {item.count}");
			}
		}
	}
}
