using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DemoConsole.Operators
{
    public class Bai2
    {
        public void Run ()
        {
            ///Comment!
            bool boolTest = true; //this is value type XML comment
            short byteTest = 19;
            int intTest;
            string stringTest = "David";
            float floatTest;
            intTest = 140000;
            floatTest = 14.5f;
            /*
             * Multiple Lines!
             * */
            const float constant1 = 10.5f;
            Console.WriteLine("Constant1 {0}", constant1);
            Console.ReadLine();
            Console.WriteLine("Bool Test {0}, Byte Test {1}", boolTest, byteTest);
            Console.WriteLine("Int Test {0}, String Test {1}, Float Test {2}", intTest, stringTest, floatTest);
            Console.ReadLine();
            Console.WriteLine("Int Test " + intTest);
            Console.WriteLine("String Test " + stringTest);
            Console.ReadLine();
        }
    }
}
