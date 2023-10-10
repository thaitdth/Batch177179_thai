using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Operators
{
    public class Bai3
    {
        public void Run()
        {
            Console.WriteLine("Moi nhap gia tri a: "); //output
            int a = Convert.ToInt32(Console.ReadLine()); //input
            int b;
            Console.WriteLine("a: {0}", a);
            Console.ReadLine(); //cho nhan phim
            Console.WriteLine("Moi nhap gia tri a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Moi nhap gia tri b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a: {0} - b: {1}", a, b);
            Console.ReadLine();

            string username;
            int tuoi;
            double luong;
            Console.WriteLine("Moi Nhap Ten: ");
            username = Console.ReadLine();
            Console.WriteLine("Moi Nhap Tuoi: ");
            tuoi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Moi Nhap Luong: ");
            luong = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Name: {0}, Age: {1}, Salary: {2}", username, tuoi, luong);
            Console.ReadLine();
        }
    }
}
