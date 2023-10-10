using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.ClassandMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<StudentInfo> list = new List<StudentInfo>()
            {
                new StudentInfo(id: 1,name: "Lan",age: 28,address: "Da Nang"),
                new StudentInfo(2, "Bao", 27, "Quang Nam"),
                new StudentInfo(3, "Anh", 25, "Hue")
            };
            foreach (var s in list)
            {
                Console.WriteLine("HELLO");
                Console.WriteLine(s.ToString());
            }
        }
    }
}
