
namespace DemoConsole.Session8
{
	public class University
	{
		public static string UniversityName { get; set; }
		public static string Department { get; set; }

		public void Run()
		{
			University.UniversityName = "FPT";
			University.Department = "CF";
			Console.WriteLine($"University: {University.UniversityName} - Department: {University.Department}");
		}
	}
}
