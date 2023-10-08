using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole
{
    public class tamthoi
    {
        public void Run()
        {
            string [,]bangcuuchuong = new string[9,9];
            for (int i = 1; i < 10; i++)
                for (int j = 1; j < 10; j++)
                {
                    int ketqua = i * j;
                    string bieuthuc = Convert.ToString(i) + " * " + Convert.ToString(j) + " = " + Convert.ToString(ketqua);
                    bangcuuchuong[i - 1,j - 1] = bieuthuc;
                }
            for (int count = 1; count < 10; count++)
                Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}{6,-15}{7,-15}{8,-15}", 
                    bangcuuchuong[0, count - 1],
                    bangcuuchuong[1, count - 1],
                    bangcuuchuong[2, count - 1],
                    bangcuuchuong[3, count - 1],
                    bangcuuchuong[4, count - 1],
                    bangcuuchuong[5, count - 1],
                    bangcuuchuong[6, count - 1],
                    bangcuuchuong[7, count - 1],
                    bangcuuchuong[8, count - 1]);
            Console.ReadLine();
        }
    }
}
