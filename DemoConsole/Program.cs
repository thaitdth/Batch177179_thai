using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new tamthoi().Run();
        }
    }
    public class Member
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
