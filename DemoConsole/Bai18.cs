using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole
{
    public class Bai18
    {
        public void Run()
        {
            string[] classOne = { "Allan", "Chris", "Monica" };
            string[] classTwo = {"Katie", "Niel", "Mark"};
            Console.WriteLine("Student of Class I\tStudent of Class II");
            for (int i = 0; i < 3; i++)
                Console.WriteLine(classOne[i] + "\t\t\t" + classTwo[i]);
            Console.WriteLine("Test1");
            classTwo = classOne;
            Console.WriteLine("\nStudent of Class II after referencing Class I:");
            for (int i = 0; i < 3; i++)
                Console.Write(classTwo[i] + " ");
            Console.WriteLine();
            Console.WriteLine();
            classOne[1] = "Ben";
            classTwo[2] = "Mike";
            Console.WriteLine("Students of Class I after changing the third student of Class II");
            for (int i = 0; i < 3; i++)
                Console.WriteLine(classOne[i] + "\t" + classTwo[i]);
            Console.WriteLine("Test2");
        }
    }
}
