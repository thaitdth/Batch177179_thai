﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Operators
{
    public class Bai12
    {
        public void Run()
        {
            int num = 5;
            while (num <= 11)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("{0} Is Even number", num);
                }
                num++;
            }
        }
    }
}
