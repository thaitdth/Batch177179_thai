using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.ClassandMethod
{
    public class Student
    {
        void PrintName(string firstName, string lastName, float point)
        {
            Console.WriteLine("FullName: {0} {1} - Point: {2}", firstName, lastName, point);
        }
        public void Run()
        {
            Student student = new Student();
            student.PrintName("Nguyen", "Van An", 8.5f);
            student.PrintName(firstName: "Thai", lastName: "Thi Boi",point: 7.5f);
            student.PrintName(point: 9.0f, lastName: "Van Thu", firstName: "Hoang");
        }
    }
}
