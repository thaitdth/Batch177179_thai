using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Operators
{
    public class Bai8
    {
        public void Run()
        {
            int ValueA = 10;
            int ValueB = 20;
            int ValueC = 0;
            ValueC = ValueA++ + ValueB;
            Console.WriteLine("ValueC= " + ValueC); //30
            ValueC = ++ValueA - ValueB;
            Console.WriteLine("ValueC= " + ValueC); //-8
            ValueC = ++ValueA + ++ValueB;
            Console.WriteLine("ValueC= " + ValueC); //34
            ValueC = --ValueA + ValueB--;
            Console.WriteLine("ValueC= " + ValueC); //33
        }
    }
}
