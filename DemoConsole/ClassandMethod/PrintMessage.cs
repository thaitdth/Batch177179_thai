using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.ClassandMethod
{
    public class PrintMessage
    {
        void Print(string mess)
        {
            Console.WriteLine(mess);
        }
        public void Run()
        {
            string notification = "Hello World";
            //Cach 1
            Print(notification);
            PrintMessage print = new PrintMessage();
            print.Print(notification);
        }
    }
}
