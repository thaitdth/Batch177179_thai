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
            new AreaRectangle(10, 5).Run();
            new AreaRectangle(20, 5).Run();
        }
    }
}
