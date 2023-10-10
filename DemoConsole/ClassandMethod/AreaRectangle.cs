using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.ClassandMethod
{
    public class AreaRectangle
    {
        private double length;
        private double width;

        public AreaRectangle(double length, double width) 
        {
            this.length = length;
            this.width = width;
        }
        public double Area()
        {
            return length * width;
        }
        public void Run() 
        {
            Console.WriteLine("Area: " + Area());
        }
    }
}
