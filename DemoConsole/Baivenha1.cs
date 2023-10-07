using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole
{
    public class Baivenha1
    {
        public void Run()
        {
            for (int i = 5; i > 0; i--)
            {    
                for (int j = i; j > 0; j--)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();
            for (int i = 1; i < 10; i++)
                for (int j = 1; j < 10; j++)
                    Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
            Console.ReadLine();
        }
    }
}
